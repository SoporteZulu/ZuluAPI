using System;
using System.Collections.Generic;

namespace Zulu.API.Models;

public partial class COMPROBANTES
{
    /// <summary>
    /// Campo ID generado por Código con StoreProcedure Generar_ID buscando en la Tabla Contador la clave &quot;Comprobantes&quot;
    /// </summary>
    public int id { get; set; }

    /// <summary>
    /// Tipo de Comprobante. Tabla &quot;TipoComprobantes&quot;
    /// </summary>
    public int Id_TipoComprobante { get; set; }

    /// <summary>
    /// Persona a la que pertenece el Comprobante. Tipo de Comprobante. Tabla &quot;Personas&quot;
    /// </summary>
    public int? id_persona { get; set; }

    /// <summary>
    /// Sucursal de la Persona a la que pertenece el Comprobante. Tipo de Comprobante. Tabla &quot;Perosnas&quot;
    /// </summary>
    public int? id_Sucursal { get; set; }

    /// <summary>
    /// Razón Social de la Persona al momento de Generación del Comprobante. Permite modificar la Razón Social de la Persona en la Tabla Personas sin problemas.
    /// </summary>
    public string? RazonSocial { get; set; }

    /// <summary>
    /// Domicilio de la Persona al momento de Generación del Comprobante. Permite modificar la Domicilio  de la Persona en la Tabla Personas sin problemas.
    /// </summary>
    public string? Domicilio { get; set; }

    /// <summary>
    /// Localidad de la Persona al momento de Generación del Comprobante. Permite modificar la Localidad de la Persona en la Tabla Personas sin problemas.
    /// </summary>
    public int? id_localidad { get; set; }

    /// <summary>
    /// Condición de IVA de la Persona al momento de Generación del Comprobante. Permite modificar la Condición de IVA de la Persona en la Tabla Personas sin problemas.
    /// </summary>
    public int CondicionIVA { get; set; }

    public string? CUIT_CUIL { get; set; }

    /// <summary>
    /// Domicilio de Entrega. Se utiliza para entrega de mercadería
    /// </summary>
    public string? DomicilioEntrega { get; set; }

    /// <summary>
    /// Telefono del Lugar de Entrega antes mencionado
    /// </summary>
    public string? TEEntrega { get; set; }

    /// <summary>
    /// Condición de la operación (Contado, Cta Cte, etc) Tabla &quot;Condicion&quot;
    /// </summary>
    public int? id_condicion { get; set; }

    /// <summary>
    /// Vendedor de la operación
    /// </summary>
    public int? id_Vendedor { get; set; }

    /// <summary>
    /// Combrador de la Operación
    /// </summary>
    public int? id_cobrador { get; set; }

    public int? id_transporte { get; set; }

    public int NroComprobanteSucursal { get; set; }

    public int? NroComprobante { get; set; }

    public DateTime? FechaComprobante { get; set; }

    public decimal? ImporteIVARI { get; set; }

    public decimal? ImporteIVARNI { get; set; }

    public decimal? NetoGravado { get; set; }

    public decimal? NetoNoGravado { get; set; }

    public decimal? TotalComprobante { get; set; }

    public int? DebeHaber { get; set; }

    public int id_moneda { get; set; }

    public decimal? cotizacion { get; set; }

    public string? NroCompIngBrutos { get; set; }

    public string? NroCompGanancias { get; set; }

    public decimal PercepcionIVA { get; set; }

    public decimal? PercepcionIngresosBrutos { get; set; }

    public decimal? PercepcionGanancias { get; set; }

    public decimal? RetencionIVA { get; set; }

    public decimal? RetencionesIngresosBrutos { get; set; }

    public decimal? RetencionesGanancias { get; set; }

    public decimal? Municipalidad { get; set; }

    public decimal Descuento { get; set; }

    public decimal PorcentajeDescuento { get; set; }

    public decimal Impuesto { get; set; }

    public decimal Impuesto1 { get; set; }

    public decimal Impuesto2 { get; set; }

    public decimal Impuesto3 { get; set; }

    /// <summary>
    /// Tabla EstadosComprobantes
    /// </summary>
    public int? Estado { get; set; }

    public int? Nrocierre { get; set; }

    public string? Observacion { get; set; }

    public DateTime? Fecha_alta { get; set; }

    public int? Prefijo { get; set; }

    public int? id_asientocontable { get; set; }

    public int? id_planCuentas { get; set; }

    public int? SaleLibroIVA { get; set; }

    public DateTime? PeriodoIVA { get; set; }

    public int? Habilitada { get; set; }

    public string? ObservacionHabilitacion { get; set; }

    public decimal? saldo { get; set; }

    public int? anulada { get; set; }

    public DateTime? fecha_anulacion { get; set; }

    public decimal Comision { get; set; }

    public decimal PorcentajeComision { get; set; }

    public int? id_usuario { get; set; }

    public DateTime? Periodo { get; set; }

    public string? Legajo { get; set; }

    public string? LegajoSucursal { get; set; }

    public string? NroCAI { get; set; }

    public int? id_TipoCategoriaComprobante { get; set; }

    public DateTime? FechaVencimientoCAI { get; set; }

    public string? ObservacionSeguimiento { get; set; }

    public int? id_plazo { get; set; }

    public int pfac_id { get; set; }

    public decimal? cmp_retNetoAAcumular { get; set; }

    public decimal? cmp_retAlicuota { get; set; }

    public decimal? cmp_retBaseImponible { get; set; }

    public decimal? cmp_retMinImponible { get; set; }

    public decimal? cmp_retAcumuladasMes { get; set; }

    public string tcmp_codigofiscaltipocomprobante { get; set; } = null!;

    /// <summary>
    /// 0- no aplica | 1- hereda de tcxpf | 2- hereda de tcxpf, regenera y validada | 3- generar en comp
    /// </summary>
    public int tcxpf_codigobarras_genera { get; set; }

    public int? tcxpf_codigoverificador { get; set; }

    public string? cmp_codigobarras { get; set; }

    public string? cmp_Destino { get; set; }

    public int? cmot_id { get; set; }

    public int? cori_id { get; set; }

    public int? cpri_id { get; set; }

    public int? ctip_id { get; set; }

    public int? cmp_NroComprobanteSucursalSecundario { get; set; }

    public int? cmp_NroComprobanteSecundario { get; set; }

    public decimal? ImporteIVARIMC { get; set; }

    public decimal? NetoGravadoMC { get; set; }

    public decimal? NetoNoGravadoMC { get; set; }

    public decimal? TotalComprobanteMC { get; set; }

    public decimal? PercepcionIVAMC { get; set; }

    public decimal? PercepcionIngresosBrutosMC { get; set; }

    public decimal? PercepcionGananciasMC { get; set; }

    public decimal? RetencionIVAMC { get; set; }

    public decimal? RetencionesIngresosBrutosMC { get; set; }

    public decimal? RetencionesGananciasMC { get; set; }

    public decimal? MunicipalidadMC { get; set; }

    public decimal? DescuentoMC { get; set; }

    public decimal? saldoMC { get; set; }

    public int? are_id { get; set; }

    public string? cmp_CondicionPago { get; set; }

    public string? cmp_Vendedor { get; set; }

    public decimal? cae { get; set; }

    public DateTime? fecha_vto_cae { get; set; }

    public int? id_cc { get; set; }

    public int? sincronizado { get; set; }

    public long? id_transportista { get; set; }

    public int? Sucursal_Prefijo { get; set; }

    public long? HojaRutaNro { get; set; }

    public int? id_usuario_anula { get; set; }

    public int? nroComprobanteSucursalCompra { get; set; }

    public bool? CompDirectoIndistinto { get; set; }

    public string? nroTimbrado { get; set; }

    public virtual ICollection<COMPROBANTESDETALLES> COMPROBANTESDETALLES { get; set; } = new List<COMPROBANTESDETALLES>();

    public virtual ICollection<COMPROBANTESFORMAPAGOS> COMPROBANTESFORMAPAGOS { get; set; } = new List<COMPROBANTESFORMAPAGOS>();

    public virtual ICollection<MOVIMIENTOSTOCK> MOVIMIENTOSTOCK { get; set; } = new List<MOVIMIENTOSTOCK>();

    public virtual SUC_PUNTOFACTURACION pfac { get; set; } = null!;
}
