using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Zulu.API.Models;

public partial class ZuluContext : DbContext
{
    //public ZuluContext()
    //{
    //}

    public ZuluContext(DbContextOptions<ZuluContext> options)
        : base(options)
    {
    }

    public virtual DbSet<COMPROBANTES> COMPROBANTES { get; set; }

    public virtual DbSet<COMPROBANTESDETALLES> COMPROBANTESDETALLES { get; set; }

    public virtual DbSet<COMPROBANTESFORMAPAGOS> COMPROBANTESFORMAPAGOS { get; set; }

    public virtual DbSet<ITEMS> ITEMS { get; set; }

    public virtual DbSet<MOVIMIENTOSTOCK> MOVIMIENTOSTOCK { get; set; }

    public virtual DbSet<SUC_PUNTOFACTURACION> SUC_PUNTOFACTURACION { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { 
    
    }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<COMPROBANTES>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("tr_InsertarComprobantes"));

            entity.HasIndex(e => new { e.id_persona, e.id_Sucursal, e.anulada, e.Prefijo, e.FechaComprobante }, "IX_COMPROBANTES");

            entity.HasIndex(e => new { e.PeriodoIVA, e.NroComprobanteSucursal, e.Estado, e.anulada, e.Id_TipoComprobante }, "IX_COMPROBANTES_11");

            entity.Property(e => e.id)
                .ValueGeneratedNever()
                .HasComment("Campo ID generado por Código con StoreProcedure Generar_ID buscando en la Tabla Contador la clave \"Comprobantes\"");
            entity.Property(e => e.CUIT_CUIL)
                .HasMaxLength(15)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Comision).HasColumnType("money");
            entity.Property(e => e.CondicionIVA).HasComment("Condición de IVA de la Persona al momento de Generación del Comprobante. Permite modificar la Condición de IVA de la Persona en la Tabla Personas sin problemas.");
            entity.Property(e => e.Descuento).HasColumnType("money");
            entity.Property(e => e.DescuentoMC).HasColumnType("money");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(250)
                .HasComment("Domicilio de la Persona al momento de Generación del Comprobante. Permite modificar la Domicilio  de la Persona en la Tabla Personas sin problemas.")
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.DomicilioEntrega)
                .HasMaxLength(250)
                .HasComment("Domicilio de Entrega. Se utiliza para entrega de mercadería")
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Estado)
                .HasDefaultValueSql("((0))")
                .HasComment("Tabla EstadosComprobantes");
            entity.Property(e => e.FechaComprobante).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaVencimientoCAI).HasColumnType("datetime");
            entity.Property(e => e.Fecha_alta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Id_TipoComprobante).HasComment("Tipo de Comprobante. Tabla \"TipoComprobantes\"");
            entity.Property(e => e.ImporteIVARI).HasColumnType("money");
            entity.Property(e => e.ImporteIVARIMC).HasColumnType("money");
            entity.Property(e => e.ImporteIVARNI).HasColumnType("money");
            entity.Property(e => e.Impuesto).HasColumnType("money");
            entity.Property(e => e.Impuesto1).HasColumnType("money");
            entity.Property(e => e.Impuesto2).HasColumnType("money");
            entity.Property(e => e.Impuesto3).HasColumnType("money");
            entity.Property(e => e.Legajo)
                .HasMaxLength(50)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.LegajoSucursal)
                .HasMaxLength(50)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Municipalidad).HasColumnType("money");
            entity.Property(e => e.MunicipalidadMC).HasColumnType("money");
            entity.Property(e => e.NetoGravado).HasColumnType("money");
            entity.Property(e => e.NetoGravadoMC).HasColumnType("money");
            entity.Property(e => e.NetoNoGravado).HasColumnType("money");
            entity.Property(e => e.NetoNoGravadoMC).HasColumnType("money");
            entity.Property(e => e.NroCAI)
                .HasMaxLength(14)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.NroCompGanancias)
                .HasMaxLength(10)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.NroCompIngBrutos)
                .HasMaxLength(13)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Observacion)
                .HasMaxLength(4000)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ObservacionHabilitacion)
                .HasMaxLength(250)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ObservacionSeguimiento)
                .HasMaxLength(250)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.PercepcionGanancias).HasColumnType("money");
            entity.Property(e => e.PercepcionGananciasMC).HasColumnType("money");
            entity.Property(e => e.PercepcionIVA).HasColumnType("money");
            entity.Property(e => e.PercepcionIVAMC).HasColumnType("money");
            entity.Property(e => e.PercepcionIngresosBrutos).HasColumnType("money");
            entity.Property(e => e.PercepcionIngresosBrutosMC).HasColumnType("money");
            entity.Property(e => e.Periodo).HasColumnType("datetime");
            entity.Property(e => e.PeriodoIVA).HasColumnType("smalldatetime");
            entity.Property(e => e.PorcentajeComision).HasColumnType("money");
            entity.Property(e => e.PorcentajeDescuento).HasColumnType("money");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(250)
                .HasComment("Razón Social de la Persona al momento de Generación del Comprobante. Permite modificar la Razón Social de la Persona en la Tabla Personas sin problemas.")
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.RetencionIVA).HasColumnType("money");
            entity.Property(e => e.RetencionIVAMC).HasColumnType("money");
            entity.Property(e => e.RetencionesGanancias).HasColumnType("money");
            entity.Property(e => e.RetencionesGananciasMC).HasColumnType("money");
            entity.Property(e => e.RetencionesIngresosBrutos).HasColumnType("money");
            entity.Property(e => e.RetencionesIngresosBrutosMC).HasColumnType("money");
            entity.Property(e => e.TEEntrega)
                .HasMaxLength(255)
                .HasComment("Telefono del Lugar de Entrega antes mencionado")
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.TotalComprobante).HasColumnType("money");
            entity.Property(e => e.TotalComprobanteMC).HasColumnType("money");
            entity.Property(e => e.anulada).HasDefaultValueSql("((0))");
            entity.Property(e => e.cae).HasColumnType("decimal(20, 0)");
            entity.Property(e => e.cmp_CondicionPago)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.cmp_Destino)
                .HasMaxLength(100)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.cmp_Vendedor)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.cmp_codigobarras)
                .HasMaxLength(40)
                .HasDefaultValueSql("('')")
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.cmp_retAcumuladasMes).HasColumnType("money");
            entity.Property(e => e.cmp_retAlicuota).HasColumnType("money");
            entity.Property(e => e.cmp_retBaseImponible).HasColumnType("money");
            entity.Property(e => e.cmp_retMinImponible).HasColumnType("money");
            entity.Property(e => e.cmp_retNetoAAcumular).HasColumnType("money");
            entity.Property(e => e.cotizacion).HasColumnType("money");
            entity.Property(e => e.fecha_anulacion).HasColumnType("datetime");
            entity.Property(e => e.fecha_vto_cae).HasColumnType("datetime");
            entity.Property(e => e.id_Sucursal).HasComment("Sucursal de la Persona a la que pertenece el Comprobante. Tipo de Comprobante. Tabla \"Perosnas\"");
            entity.Property(e => e.id_Vendedor).HasComment("Vendedor de la operación");
            entity.Property(e => e.id_cobrador).HasComment("Combrador de la Operación");
            entity.Property(e => e.id_condicion).HasComment("Condición de la operación (Contado, Cta Cte, etc) Tabla \"Condicion\"");
            entity.Property(e => e.id_localidad)
                .HasDefaultValueSql("((0))")
                .HasComment("Localidad de la Persona al momento de Generación del Comprobante. Permite modificar la Localidad de la Persona en la Tabla Personas sin problemas.");
            entity.Property(e => e.id_persona).HasComment("Persona a la que pertenece el Comprobante. Tipo de Comprobante. Tabla \"Personas\"");
            entity.Property(e => e.id_usuario).HasDefaultValueSql("((0))");
            entity.Property(e => e.nroTimbrado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.saldo).HasColumnType("money");
            entity.Property(e => e.saldoMC).HasColumnType("money");
            entity.Property(e => e.tcmp_codigofiscaltipocomprobante)
                .HasMaxLength(10)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.tcxpf_codigobarras_genera).HasComment("0- no aplica | 1- hereda de tcxpf | 2- hereda de tcxpf, regenera y validada | 3- generar en comp");

            entity.HasOne(d => d.pfac).WithMany(p => p.COMPROBANTES)
                .HasForeignKey(d => d.pfac_id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPROBANTES_SUC_PUNTOFACTURACION");
        });

        modelBuilder.Entity<COMPROBANTESDETALLES>(entity =>
        {
            entity.ToTable(tb => tb.HasTrigger("tr_InsertarComprobantesDetalles"));

            entity.HasIndex(e => e.id_Comprobante, "IX_COMPROBANTESDETALLES");

            entity.Property(e => e.id).ValueGeneratedNever();
            entity.Property(e => e.Cantidad).HasColumnType("money");
            entity.Property(e => e.CantidadBonificada).HasColumnType("money");
            entity.Property(e => e.CantidadCancelada).HasColumnType("money");
            entity.Property(e => e.CantidadEntregada).HasColumnType("money");
            entity.Property(e => e.CantidadNeta).HasColumnType("money");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CodigoIntegradora)
                .HasMaxLength(50)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Concepto)
                .HasMaxLength(250)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.ConceptoIntegradora)
                .HasMaxLength(250)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.CostoUnitario).HasColumnType("money");
            entity.Property(e => e.CotizacionCosto).HasColumnType("money");
            entity.Property(e => e.CotizacionMC).HasColumnType("money");
            entity.Property(e => e.Fecha_alta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Garantia)
                .HasMaxLength(50)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.MontoDescuentoGeneralMB).HasColumnType("money");
            entity.Property(e => e.MontoDescuentoGeneralMC).HasColumnType("money");
            entity.Property(e => e.MontoDescuentoMB).HasColumnType("money");
            entity.Property(e => e.MontoDescuentoMC).HasColumnType("money");
            entity.Property(e => e.MontoDescuentoTotalMB).HasColumnType("money");
            entity.Property(e => e.MontoDescuentoTotalMC).HasColumnType("money");
            entity.Property(e => e.MontoIVAMB).HasColumnType("money");
            entity.Property(e => e.MontoIVAMC).HasColumnType("money");
            entity.Property(e => e.Observacion)
                .HasMaxLength(4000)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Peso).HasDefaultValueSql("(0)");
            entity.Property(e => e.PorcentajeDescuento)
                .HasComment("Porcentaje de Descuento")
                .HasColumnType("money");
            entity.Property(e => e.PorcentajeDescuentoGeneral)
                .HasComment("PorcentajeDescuento de Comprobantes")
                .HasColumnType("money");
            entity.Property(e => e.PorcentajeIVA).HasColumnType("money");
            entity.Property(e => e.Precio).HasColumnType("money");
            entity.Property(e => e.PrecioListaNeto).HasColumnType("money");
            entity.Property(e => e.PrecioListaNetoMC).HasColumnType("money");
            entity.Property(e => e.PrecioMC).HasColumnType("money");
            entity.Property(e => e.Total)
                .HasComment("Precio X (Cantidad - CantidadBonificada) ")
                .HasColumnType("money");
            entity.Property(e => e.TotalConDescuento)
                .HasComment("Precio X (Cantidad - CantidadBonificada) * PorcentajeDescuento")
                .HasColumnType("money");
            entity.Property(e => e.TotalConDescuentoGeneral)
                .HasComment("(Precio X (Cantidad - CantidadBonificada) * PorcentajeDescuento) * PorcentajeDescuento Comprobantes")
                .HasColumnType("money");
            entity.Property(e => e.TotalConDescuentoGeneralMC).HasColumnType("money");
            entity.Property(e => e.TotalConDescuentoMC).HasColumnType("money");
            entity.Property(e => e.TotalConDescuentosImpuestos)
                .HasComment("Total Renglon con Descuento e IVA e Impuestos")
                .HasColumnType("money");
            entity.Property(e => e.TotalConDescuentosImpuestosMC).HasColumnType("money");
            entity.Property(e => e.TotalMC).HasColumnType("money");
            entity.Property(e => e.Volumen).HasDefaultValueSql("(0)");
            entity.Property(e => e.cantidad_bultos).HasColumnType("decimal(19, 9)");
            entity.Property(e => e.cpri_id).HasDefaultValueSql("((0))");
            entity.Property(e => e.dcmp_FechaRequerido).HasColumnType("datetime");
            entity.Property(e => e.id_itemsprecio).HasDefaultValueSql("(0)");
            entity.Property(e => e.porcentajeMargen).HasColumnType("money");
            entity.Property(e => e.renglonTipo).HasDefaultValueSql("((2))");

            entity.HasOne(d => d.id_ComprobanteNavigation).WithMany(p => p.COMPROBANTESDETALLES)
                .HasForeignKey(d => d.id_Comprobante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPROBANTESDETALLES_COMPROBANTES");

            entity.HasOne(d => d.id_ItemNavigation).WithMany(p => p.COMPROBANTESDETALLES)
                .HasForeignKey(d => d.id_Item)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COMPROBANTESDETALLES_ITEMS");
        });

        modelBuilder.Entity<COMPROBANTESFORMAPAGOS>(entity =>
        {
            entity.HasIndex(e => e.id_Comprobante, "IX_COMPROBANTESFORMAPAGOS_I");

            entity.Property(e => e.Cotizacion).HasColumnType("money");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(250)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Importe).HasColumnType("money");
            entity.Property(e => e.Observacion)
                .HasMaxLength(4000)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.fecha).HasColumnType("smalldatetime");
            entity.Property(e => e.fecha_alta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.id_ComprobanteNavigation).WithMany(p => p.COMPROBANTESFORMAPAGOS)
                .HasForeignKey(d => d.id_Comprobante)
                .HasConstraintName("FK_COMPROBANTESFORMAPAGOS_COMPROBANTES");
        });

        modelBuilder.Entity<ITEMS>(entity =>
        {
            entity.ToTable(tb =>
                {
                    tb.HasTrigger("ValidarSistema_Delete");
                    tb.HasTrigger("ValidarSistema_Insert");
                    tb.HasTrigger("ValidarSistema_Update");
                });

            entity.HasIndex(e => e.id, "IX_ITEMS").IsUnique();

            entity.Property(e => e.id).ValueGeneratedNever();
            entity.Property(e => e.CodigoEstructura)
                .HasMaxLength(50)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Costo).HasColumnType("money");
            entity.Property(e => e.Financiero).HasDefaultValueSql("(0)");
            entity.Property(e => e.MargenGanancia)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Observacion)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'')")
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Peso).HasDefaultValueSql("(0)");
            entity.Property(e => e.PorcentajeIVA).HasColumnType("money");
            entity.Property(e => e.PorcentajeIVACompra)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money");
            entity.Property(e => e.PuntoReposicion)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money");
            entity.Property(e => e.RecibeMovimiento).HasDefaultValueSql("(1)");
            entity.Property(e => e.Sistema).HasDefaultValueSql("(0)");
            entity.Property(e => e.StockMaximo)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money");
            entity.Property(e => e.StockMinimo)
                .HasDefaultValueSql("(0)")
                .HasColumnType("money");
            entity.Property(e => e.StockSINO).HasDefaultValueSql("(0)");
            entity.Property(e => e.Unidad)
                .HasMaxLength(13)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.Volumen).HasDefaultValueSql("(0)");
            entity.Property(e => e.codigo)
                .HasMaxLength(50)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.codigo2)
                .HasMaxLength(50)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.codigoOrganismo).HasMaxLength(50);
            entity.Property(e => e.descripcion)
                .HasMaxLength(500)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.esrubro).HasDefaultValueSql("(0)");
            entity.Property(e => e.fecha_alta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.foto)
                .HasMaxLength(250)
                .HasDefaultValueSql("('')")
                .UseCollation("Modern_Spanish_CI_AS");

            entity.HasOne(d => d.id_integradoraNavigation).WithMany(p => p.Inverseid_integradoraNavigation)
                .HasForeignKey(d => d.id_integradora)
                .HasConstraintName("FK_ITEMS_ITEMS");
        });

        modelBuilder.Entity<MOVIMIENTOSTOCK>(entity =>
        {
            entity.Property(e => e.cantidad).HasColumnType("money");
            entity.Property(e => e.fecha_alta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.fecha_anulacion).HasColumnType("datetime");
            entity.Property(e => e.ite_cantidad_componente).HasColumnType("money");

            entity.HasOne(d => d.cmpd).WithMany(p => p.MOVIMIENTOSTOCK)
                .HasForeignKey(d => d.cmpd_id)
                .HasConstraintName("FK_MOVIMIENTOSTOCK_COMPROBANTESDETALLES");

            entity.HasOne(d => d.id_comprobanteNavigation).WithMany(p => p.MOVIMIENTOSTOCK)
                .HasForeignKey(d => d.id_comprobante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MOVIMIENTOSTOCK_COMPROBANTES");

            entity.HasOne(d => d.id_itemNavigation).WithMany(p => p.MOVIMIENTOSTOCKid_itemNavigation)
                .HasForeignKey(d => d.id_item)
                .HasConstraintName("FK_MOVIMIENTOSTOCK_ITEMS");

            entity.HasOne(d => d.ite_id_packNavigation).WithMany(p => p.MOVIMIENTOSTOCKite_id_packNavigation)
                .HasForeignKey(d => d.ite_id_pack)
                .HasConstraintName("FK_MOVIMIENTOSTOCK_ITEMS1");
        });

        modelBuilder.Entity<SUC_PUNTOFACTURACION>(entity =>
        {
            entity.HasKey(e => e.pfac_id);

            entity.Property(e => e.pfac_id).ValueGeneratedNever();
            entity.Property(e => e.fecha_alta)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.fecha_baja).HasColumnType("datetime");
            entity.Property(e => e.fecha_modificacion).HasColumnType("datetime");
            entity.Property(e => e.identidad).ValueGeneratedOnAdd();
            entity.Property(e => e.pfac_Impuesto).HasDefaultValueSql("((0))");
            entity.Property(e => e.pfac_IngresoPrecioVenta).HasDefaultValueSql("(1)");
            entity.Property(e => e.pfac_descripcion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("Modern_Spanish_CI_AS");
            entity.Property(e => e.pfac_recibos_automaticos).HasDefaultValueSql("((1))");
            entity.Property(e => e.timestamp)
                .IsRowVersion()
                .IsConcurrencyToken();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
