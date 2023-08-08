using System;
using System.Collections.Generic;

namespace Zulu.API.Models;

public partial class Aspirante
{
    public int NumeroDeRegistroConsecutivo { get; set; }

    public int NumeroDePrelacion { get; set; }

    public string NumeroDeRegistroInformativo { get; set; } = null!;

    public string CUIL { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string? CorreoElectronico { get; set; }

    public string? KilometrosDispuestoADesplazarse { get; set; }

    public bool? AutonomiaPersonalTraslado { get; set; }

    public bool? RequiereAcompaniante { get; set; }

    public bool? RequiereElementoApoyo { get; set; }

    public bool Historico { get; set; }

    public int Id_ElementoApoyo { get; set; }

    public string? OtroElementoDeApoyo { get; set; }

    public int? Id_EstadoDelAspirante { get; set; }

    public int? Id_TipoCertificado { get; set; }

    public string NumeroDeCertificado { get; set; } = null!;

    public int? Id_TipoDiscapacidad { get; set; }

    public int? Id_TipoDeLey { get; set; }

    public string? LeyNumero { get; set; }

    public string? LeyDescripcion { get; set; }

    public DateTime? FechaEmisionCertificado { get; set; }

    public DateTime? FechaVencimientoCertificado { get; set; }

    public string? EnteCertificador { get; set; }

    public int id_Domicilio { get; set; }

    public bool DiscapacidadACargo { get; set; }

    public DateTime? FechaNacimiento { get; set; }

    public string? Genero { get; set; }

    public int Id_EstadoCivil { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public bool? DomicilioDelDNIEsElActual { get; set; }

    public bool? Reempadronado { get; set; }

    public string? OrganismoBrindaEspacio { get; set; }

    public string? Telefonos { get; set; }
}
