using System;
using System.Collections.Generic;

namespace Zulu.API.Models;

public partial class COMPROBANTESDETALLES
{
    public int id { get; set; }

    public int id_Comprobante { get; set; }

    public int id_Item { get; set; }

    public string? Concepto { get; set; }

    public string? Observacion { get; set; }

    public decimal? CostoUnitario { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? CantidadBonificada { get; set; }

    public decimal? Precio { get; set; }

    public decimal? PrecioListaNeto { get; set; }

    public int? id_itemsprecio { get; set; }

    public decimal? PorcentajeIVA { get; set; }

    /// <summary>
    /// Porcentaje de Descuento
    /// </summary>
    public decimal? PorcentajeDescuento { get; set; }

    /// <summary>
    /// Precio X (Cantidad - CantidadBonificada) * PorcentajeDescuento
    /// </summary>
    public decimal? TotalConDescuento { get; set; }

    /// <summary>
    /// PorcentajeDescuento de Comprobantes
    /// </summary>
    public decimal? PorcentajeDescuentoGeneral { get; set; }

    /// <summary>
    /// (Precio X (Cantidad - CantidadBonificada) * PorcentajeDescuento) * PorcentajeDescuento Comprobantes
    /// </summary>
    public decimal? TotalConDescuentoGeneral { get; set; }

    public int? id_plancuentas { get; set; }

    public double? Peso { get; set; }

    public double? Volumen { get; set; }

    public DateTime? Fecha_alta { get; set; }

    public int? Prefijo { get; set; }

    public int? Renglon { get; set; }

    public string? Codigo { get; set; }

    /// <summary>
    /// Precio X (Cantidad - CantidadBonificada) 
    /// </summary>
    public decimal? Total { get; set; }

    public int? id_integradora { get; set; }

    public string? CodigoIntegradora { get; set; }

    /// <summary>
    /// Total Renglon con Descuento e IVA e Impuestos
    /// </summary>
    public decimal? TotalConDescuentosImpuestos { get; set; }

    public int? Id_MonedaCosto { get; set; }

    public decimal? CotizacionCosto { get; set; }

    public string? Garantia { get; set; }

    public decimal? CantidadEntregada { get; set; }

    public decimal? CantidadCancelada { get; set; }

    public string? ConceptoIntegradora { get; set; }

    public decimal? MontoIVAMB { get; set; }

    public decimal? MontoIVAMC { get; set; }

    public decimal? TotalConDescuentosImpuestosMC { get; set; }

    public decimal? TotalMC { get; set; }

    public int? est_id { get; set; }

    public DateTime? dcmp_FechaRequerido { get; set; }

    public decimal? CantidadNeta { get; set; }

    public int? id_MonedaComprobante { get; set; }

    public decimal? CotizacionMC { get; set; }

    public decimal? PrecioMC { get; set; }

    public decimal? PrecioListaNetoMC { get; set; }

    public decimal? MontoDescuentoMB { get; set; }

    public decimal? MontoDescuentoMC { get; set; }

    public decimal? TotalConDescuentoMC { get; set; }

    public decimal? MontoDescuentoGeneralMB { get; set; }

    public decimal? MontoDescuentoGeneralMC { get; set; }

    public decimal? MontoDescuentoTotalMB { get; set; }

    public decimal? MontoDescuentoTotalMC { get; set; }

    public decimal? TotalConDescuentoGeneralMC { get; set; }

    public int? id_unidad { get; set; }

    public int? id_unidad_manipulacion { get; set; }

    public decimal? cantidad_bultos { get; set; }

    public int? id_cc { get; set; }

    public int? sincronizado { get; set; }

    public int? renglonTipo { get; set; }

    public decimal? porcentajeMargen { get; set; }

    public int? nivel { get; set; }

    public int? cpri_id { get; set; }

    public virtual ICollection<MOVIMIENTOSTOCK> MOVIMIENTOSTOCK { get; set; } = new List<MOVIMIENTOSTOCK>();

    public virtual COMPROBANTES id_ComprobanteNavigation { get; set; } = null!;

    public virtual ITEMS id_ItemNavigation { get; set; } = null!;
}
