using System;
using System.Collections.Generic;

namespace Zulu.API.Models;

public partial class ITEMS
{
    public int id { get; set; }

    public string? codigo { get; set; }

    public string? codigo2 { get; set; }

    public string? descripcion { get; set; }

    public DateTime? fecha_alta { get; set; }

    public string? Unidad { get; set; }

    public double? Peso { get; set; }

    public double? Volumen { get; set; }

    public decimal? Costo { get; set; }

    public int? Sistema { get; set; }

    public int? Financiero { get; set; }

    public int? StockSINO { get; set; }

    public decimal? StockMinimo { get; set; }

    public decimal? StockMaximo { get; set; }

    public decimal? PuntoReposicion { get; set; }

    public int? id_plancuentas { get; set; }

    public int? id_plancuentasCompra { get; set; }

    public string Observacion { get; set; } = null!;

    public int? Compra { get; set; }

    public int? Venta { get; set; }

    public string foto { get; set; } = null!;

    public decimal? PorcentajeIVA { get; set; }

    public int? id_integradora { get; set; }

    public int? RecibeMovimiento { get; set; }

    public int? esrubro { get; set; }

    public decimal? PorcentajeIVACompra { get; set; }

    public int? Nivel { get; set; }

    public int? Orden_Nivel { get; set; }

    public string? CodigoEstructura { get; set; }

    public int Impuesto { get; set; }

    public bool fraccionario { get; set; }

    public double? medida { get; set; }

    public int? ume_id { get; set; }

    public bool ite_esPack { get; set; }

    public bool ite_controlStockPack { get; set; }

    public bool ite_PermiteStockNegativo { get; set; }

    public int? esRPT { get; set; }

    public string? codigoOrganismo { get; set; }

    public decimal? MargenGanancia { get; set; }

    public bool chkEstructuraValor { get; set; }

    public int? id_marca { get; set; }

    public virtual ICollection<COMPROBANTESDETALLES> COMPROBANTESDETALLES { get; set; } = new List<COMPROBANTESDETALLES>();

    public virtual ICollection<ITEMS> Inverseid_integradoraNavigation { get; set; } = new List<ITEMS>();

    public virtual ICollection<MOVIMIENTOSTOCK> MOVIMIENTOSTOCKid_itemNavigation { get; set; } = new List<MOVIMIENTOSTOCK>();

    public virtual ICollection<MOVIMIENTOSTOCK> MOVIMIENTOSTOCKite_id_packNavigation { get; set; } = new List<MOVIMIENTOSTOCK>();

    public virtual ITEMS? id_integradoraNavigation { get; set; }
}
