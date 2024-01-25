using System;
using System.Collections.Generic;

namespace Zulu.API.Models;

public partial class TIPOSCOMPROBANTESPUNTOFACTURACION
{
    public int id { get; set; }

    public int id_tipocomprobante { get; set; }

    public int? id_CtaContableIVARI { get; set; }

    public string? id_CtaContableIVARNI { get; set; }

    public DateTime? fecha_alta { get; set; }

    public int prefijo { get; set; }

    public int NumeroComprobanteProximo { get; set; }

    public int FilasCantidad { get; set; }

    public int FilasAnchoMaximo { get; set; }

    public int? id_reporte { get; set; }

    public int? id_ReporteConFormato { get; set; }

    public DateTime ultimocierre { get; set; }

    public DateTime ultimocierreVta { get; set; }

    public int VarianteNroUnico { get; set; }

    public int CantidadCopias { get; set; }

    public int VistaPrevia { get; set; }

    public int ImprimirControladorFiscal { get; set; }

    public int Id_Moneda { get; set; }

    public int PermitirSeleccionMoneda { get; set; }

    public int PermitirCambioCotizacion { get; set; }

    public int Editable { get; set; }

    public int? ControlIntervalo { get; set; }

    public int? NumeroDesde { get; set; }

    public int? NumeroHasta { get; set; }

    public int pfac_id { get; set; }

    public int Confirma { get; set; }

    public int tcxpf_heredanumeracion { get; set; }

    public int tcxpf_cai_control { get; set; }

    public string? tcxpf_cai { get; set; }

    public DateTime? tcxpf_cai_fechavencimiento { get; set; }

    /// <summary>
    /// 0- no aplica | 1- hereda de tcxpf | 2- hereda de tcxpf, regenera y validada | 3- generar en comp
    /// </summary>
    public int tcxpf_codigobarras_genera { get; set; }

    public int? tcxpf_codigoverificador { get; set; }

    public string tcxpf_codigobarras { get; set; } = null!;

    public int tcxpf_controlnumerosecundario { get; set; }

    /// <summary>
    /// [0 NO / 1 solo una vez / 2 por cada copia]
    /// </summary>
    public int Impresion_SolicitaConfirmacion { get; set; }

    /// <summary>
    /// [0 vbModeless / 1 vbModal]
    /// </summary>
    public int Impresion_VistaPreviaModal { get; set; }

    public bool? Impresion_MostrarDialogo { get; set; }

    public bool Impresion_MostrarSinDatos { get; set; }

    public bool? ExportarPDF { get; set; }

    public bool? ExportarImprimir { get; set; }

    public int? Categoria { get; set; }

    public string? Mascara_Moneda { get; set; }
}
