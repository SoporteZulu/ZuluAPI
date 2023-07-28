using System;
using System.Collections.Generic;

namespace Zulu.API.Models;

public partial class MOVIMIENTOSTOCK
{
    public int id { get; set; }

    public int id_item { get; set; }

    public decimal cantidad { get; set; }

    public short debehaber { get; set; }

    public int id_comprobante { get; set; }

    public DateTime fecha_alta { get; set; }

    public int id_deposito { get; set; }

    public int? anulada { get; set; }

    public DateTime? fecha_anulacion { get; set; }

    public int? cmpd_id { get; set; }

    public int? ite_id_pack { get; set; }

    public decimal? ite_cantidad_componente { get; set; }

    public int? id_cc { get; set; }

    public int? sincronizado { get; set; }

    public virtual COMPROBANTESDETALLES? cmpd { get; set; }

    public virtual COMPROBANTES id_comprobanteNavigation { get; set; } = null!;

    public virtual ITEMS id_itemNavigation { get; set; } = null!;

    public virtual ITEMS? ite_id_packNavigation { get; set; }
}
