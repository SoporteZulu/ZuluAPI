using System;
using System.Collections.Generic;

namespace Zulu.API.Models;

public partial class COMPROBANTESFORMAPAGOS
{
    public int id { get; set; }

    public int? id_Comprobante { get; set; }

    public int? id_FormaPago { get; set; }

    public DateTime? fecha { get; set; }

    public decimal? Importe { get; set; }

    public DateTime? fecha_alta { get; set; }

    public int? Prefijo { get; set; }

    public string? Descripcion { get; set; }

    public string? Observacion { get; set; }

    public int? valido { get; set; }

    public int? id_Moneda { get; set; }

    public decimal? Cotizacion { get; set; }

    public int? id_cc { get; set; }

    public int? sincronizado { get; set; }

    public virtual COMPROBANTES? id_ComprobanteNavigation { get; set; }
}
