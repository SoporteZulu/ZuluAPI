using System;
using System.Collections.Generic;

namespace Zulu.API.Models;

public partial class SUC_PUNTOFACTURACION
{
    public int pfac_id { get; set; }

    public int identidad { get; set; }

    public DateTime fecha_alta { get; set; }

    public int? usuario_alta { get; set; }

    public DateTime? fecha_modificacion { get; set; }

    public int? usuario_modificacion { get; set; }

    public DateTime? fecha_baja { get; set; }

    public byte[] timestamp { get; set; } = null!;

    public int id_sucursal { get; set; }

    public int pfac_prefijo_comprobante { get; set; }

    public string pfac_descripcion { get; set; } = null!;

    public int tpf_id { get; set; }

    public int id_moneda { get; set; }

    public int pfac_remitos_automaticos { get; set; }

    public int pfac_IngresoPrecioVenta { get; set; }

    public int pfac_recibos_automaticos { get; set; }

    public int? pfac_Impuesto { get; set; }

    public int? pfac_Impuesto_Compra { get; set; }

    public bool pfac_IngresoPrecioCompra { get; set; }

    public virtual ICollection<COMPROBANTES> COMPROBANTES { get; set; } = new List<COMPROBANTES>();
}
