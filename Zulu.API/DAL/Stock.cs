using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Zulu.API;
using Zulu.API.Models;

namespace Zulu.API.DAL
{
    public class Stock
    {

        public void Ajustar(List<AjusteStock> ajuste)
        {

            var _lstAjuste = new List<Models.COMPROBANTES>();

            foreach (AjusteStock stock in ajuste)
            {
                var mod = GetModelComprobante(stock);
                _lstAjuste.Add(mod);
            }

            using (var context = new ZuluContext())
            {
                context.COMPROBANTES.AddRange(_lstAjuste);
                context.SaveChanges();
            }

        }

        private int GetPrefijoComprobante(int pfac_id)
        {

            using (var context = new ZuluContext())
            {
                return context.SUC_PUNTOFACTURACION
                                        .Where(p => p.pfac_id == pfac_id)
                                        .Select(p => p.pfac_prefijo_comprobante)
                                        .FirstOrDefault();
            }
        }

        public Models.ITEMS GetItem(string codigoitem)
        {
         
            using (var context = new ZuluContext())
            {
                return context.ITEMS
                       .Where(p => p.codigo == codigoitem)
                       .FirstOrDefault();
            }
        }

        private Models.COMPROBANTES GetModelComprobante(AjusteStock stock)
        {
            var _prefijo = this.GetPrefijoComprobante(stock.FN_pfac_id);
            var _idComprobante= new DAL.UtilsDB().GenerarId("COMPROBANTES");
            var _ajusteStk = new Models.COMPROBANTES
            {
                NroComprobanteSucursal = 0,
                Domicilio = "",
                Id_TipoComprobante = 78,
                id_persona = 0,
                RazonSocial = "",
                CondicionIVA = 0,
                CUIT_CUIL = "",
                DomicilioEntrega = "",
                TEEntrega = "",
                id_condicion = 1,
                id_Vendedor = null,
                id_cobrador = null,
                id_transporte = null,
                ImporteIVARI = 0,
                ImporteIVARNI = 0,
                NetoGravado = 0,
                NetoNoGravado = 0,
                TotalComprobante = 0,
                DebeHaber = 1,
                id_moneda = 1,
                cotizacion = 1,
                NroCompIngBrutos = "",
                NroCompGanancias = "",
                PercepcionIVA = 0,
                PercepcionIngresosBrutos = 0,
                PercepcionGanancias = 0,
                RetencionIVA = 0,
                RetencionesIngresosBrutos = 0,
                RetencionesGanancias = 0,
                Municipalidad = 0,
                Descuento = 0,
                PorcentajeDescuento = 0,
                Impuesto = 0,
                Impuesto1 = 0,
                Impuesto2 = 0,
                Impuesto3 = 0,
                Estado = 0,
                Observacion = "",
                Fecha_alta = DateTime.Now,
                id_asientocontable = 0,
                id_planCuentas = 0,
                SaleLibroIVA = 0,
                Habilitada = 0,
                ObservacionHabilitacion = "",
                saldo = 0,
                Nrocierre = 0,
                anulada = 0
            };

            _ajusteStk.id = _idComprobante;
            _ajusteStk.FechaComprobante = stock.FechaComprobante;
            _ajusteStk.Prefijo = _prefijo;
            _ajusteStk.id_usuario = stock.idUsuario;
            _ajusteStk.pfac_id = stock.FN_pfac_id;

            /*ver si hay que validar que el prefijo sea nulo?*/

            var _renglon = 1;
            foreach (var itemDetalle in stock.Detalle)
            {
                var _item = this.GetItem(itemDetalle.codigoItem);

                var _compDetalle = GetModelComprobanteDetalle(itemDetalle, _renglon, _prefijo, _item);
                var _idComprobanteDetalle = new DAL.UtilsDB().GenerarId("COMPROBANTESDETALLES");
                var _movimStk= this.GetModelMovimientoStock(itemDetalle, _item);

                _compDetalle.id = _idComprobanteDetalle;
                _compDetalle.cpri_id = 5;
                _ajusteStk.COMPROBANTESDETALLES.Add(_compDetalle);
                _ajusteStk.MOVIMIENTOSTOCK.Add(_movimStk);

                _renglon++;
            }

            _ajusteStk.COMPROBANTESFORMAPAGOS.Add(this.GetModelComprobantesFormasPagos(_ajusteStk));
            return _ajusteStk;
        }

        private Models.COMPROBANTESDETALLES GetModelComprobanteDetalle(DetailAjusteStock detail, int renglonID, int Prefijo, ITEMS item)
        {

            var _compDetalle = new Models.COMPROBANTESDETALLES
            {
                Observacion = "",
                CostoUnitario = 0,
                CantidadBonificada = 0,
                Precio = 0,
                PrecioListaNeto = 0,
                id_itemsprecio = 0,
                PorcentajeIVA = 0,
                PorcentajeDescuento = 0,
                TotalConDescuento = 0,
                PorcentajeDescuentoGeneral = 0,
                TotalConDescuentoGeneral = 0,
                id_plancuentas = null,
                Peso = 0,
                Volumen = 0,
                Codigo = "",
                Total = null,
                id_integradora = null,
                CodigoIntegradora = null,
                TotalConDescuentosImpuestos = null,
                Id_MonedaCosto = null,
                CotizacionCosto = null,
                Garantia = null,
                CantidadEntregada = null,
                CantidadCancelada = null,
                ConceptoIntegradora = null,
                MontoIVAMB = null,
                MontoIVAMC = null,
                TotalConDescuentosImpuestosMC = null,
                TotalMC = null,
                est_id = null,
                dcmp_FechaRequerido = null,
                CantidadNeta = null,
                id_MonedaComprobante = null,
                CotizacionMC = null,
                PrecioMC = null,
                PrecioListaNetoMC = null,
                MontoDescuentoMB = null,
                MontoDescuentoMC = null,
                TotalConDescuentoMC = null,
                MontoDescuentoGeneralMB = null,
                MontoDescuentoGeneralMC = null,
                MontoDescuentoTotalMB = null,
                MontoDescuentoTotalMC = null,
                TotalConDescuentoGeneralMC = null,
                id_cc = null,
                sincronizado = null,
                renglonTipo = 0,
                porcentajeMargen = 0,
                nivel = 0,
                cpri_id = null
            };

            _compDetalle.Fecha_alta = DateTime.Now;
            _compDetalle.Renglon = renglonID;
            _compDetalle.id_unidad = 0; /***************************/
            _compDetalle.id_unidad_manipulacion = 0;/***************************/
            _compDetalle.cantidad_bultos = 0;/***************************/
            _compDetalle.id_Item = item.id;
            _compDetalle.Concepto = item.descripcion;
            _compDetalle.Cantidad = detail.Cantidad;
            _compDetalle.Prefijo = Prefijo;

            return _compDetalle;

        }

        private Models.MOVIMIENTOSTOCK GetModelMovimientoStock(DetailAjusteStock detail,ITEMS item)
        {

            var _movimStk = new Models.MOVIMIENTOSTOCK
            {
                id_item = item.id,
                cantidad = detail.Cantidad,
                debehaber = 1,
                id_deposito = 8,
                fecha_alta = DateTime.Now,
                anulada = null,
                fecha_anulacion = null,
                cmpd_id = null,
                ite_id_pack = null,
                ite_cantidad_componente = null,
                id_cc = null,
                sincronizado = null
            };

            return _movimStk;

        }

        private Models.COMPROBANTESFORMAPAGOS GetModelComprobantesFormasPagos(Models.COMPROBANTES comprobantes)
        {
            var _comprobanteFormaPago = new Models.COMPROBANTESFORMAPAGOS
            {
                id_FormaPago = 1,
                fecha = comprobantes.FechaComprobante,
                Importe = 0,
                fecha_alta = DateTime.Now,
                Prefijo = comprobantes.Prefijo,
                Descripcion = "",
                Observacion = "",
                valido = 1,
                id_Moneda = null,
                Cotizacion = null,
                id_cc = null,
                sincronizado = null
            };

            return _comprobanteFormaPago;

        }

    }
}
