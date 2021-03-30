using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebServiceFC.Modelos
{
    public partial class FundacionColibriContext : DbContext
    {
        public FundacionColibriContext()
        {
        }

        public FundacionColibriContext(DbContextOptions<FundacionColibriContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Canton> Cantons { get; set; }
        public virtual DbSet<CasaAcogimiento> CasaAcogimientos { get; set; }
        public virtual DbSet<DatosJudicialPenal> DatosJudicialPenals { get; set; }
        public virtual DbSet<DatosSalud> DatosSaluds { get; set; }
        public virtual DbSet<EstadoProcesal> EstadoProcesals { get; set; }
        public virtual DbSet<Etnium> Etnia { get; set; }
        public virtual DbSet<FamiliarReferente> FamiliarReferentes { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<HistorialCronologico> HistorialCronologicos { get; set; }
        public virtual DbSet<InfraccionDenunciadum> InfraccionDenunciada { get; set; }
        public virtual DbSet<Medidum> Medida { get; set; }
        public virtual DbSet<Modalidad> Modalidads { get; set; }
        public virtual DbSet<MotivoIngreso> MotivoIngresos { get; set; }
        public virtual DbSet<Nacionalidad> Nacionalidads { get; set; }
        public virtual DbSet<NivelAcademico> NivelAcademicos { get; set; }
        public virtual DbSet<NudosCritico> NudosCriticos { get; set; }
        public virtual DbSet<Organizacion> Organizacions { get; set; }
        public virtual DbSet<Parroquium> Parroquia { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Pgf> Pgfs { get; set; }
        public virtual DbSet<Provincium> Provincia { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=localhost;Database=FundacionColibri;Trusted_Connection=true;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Canton>(entity =>
            {
                entity.HasKey(e => e.IdCanton)
                    .HasName("PK_idCantones");

                entity.ToTable("Canton");

                entity.Property(e => e.IdCanton)
                    .ValueGeneratedNever()
                    .HasColumnName("idCanton");

                entity.Property(e => e.DescripcionCanton).HasColumnName("descripcionCanton");

                entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Cantons)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("FK_Canton_Provincia");
            });

            modelBuilder.Entity<CasaAcogimiento>(entity =>
            {
                entity.HasKey(e => e.IdNombreCasaAnterior);

                entity.ToTable("CasaAcogimiento");

                entity.Property(e => e.IdNombreCasaAnterior)
                    .ValueGeneratedNever()
                    .HasColumnName("idNombreCasaAnterior");

                entity.Property(e => e.DescripcionCasaAcogimiento)
                    .IsRequired()
                    .HasColumnName("descripcionCasaAcogimiento");
            });

            modelBuilder.Entity<DatosJudicialPenal>(entity =>
            {
                entity.HasKey(e => e.IdJudicialPenal);

                entity.ToTable("DatosJudicialPenal");

                entity.Property(e => e.IdJudicialPenal)
                    .ValueGeneratedNever()
                    .HasColumnName("idJudicialPenal");

                entity.Property(e => e.EgresoPorReinsercion).HasColumnName("egresoPorReinsercion");

                entity.Property(e => e.EncuentraInsertSpavt).HasColumnName("encuentraInsert@SPAVT");

                entity.Property(e => e.FechaEgreso)
                    .HasColumnType("date")
                    .HasColumnName("fechaEgreso");

                entity.Property(e => e.FechaReinsercion)
                    .HasColumnType("date")
                    .HasColumnName("fechaReinsercion");

                entity.Property(e => e.FechaResolucionTraslado)
                    .HasColumnType("date")
                    .HasColumnName("fechaResolucionTraslado");

                entity.Property(e => e.FechaSalidaUnidadActual)
                    .HasColumnType("date")
                    .HasColumnName("fechaSalidaUnidadActual");

                entity.Property(e => e.IdCanton).HasColumnName("idCanton");

                entity.Property(e => e.IdEstadoProcesal).HasColumnName("idEstadoProcesal");

                entity.Property(e => e.IdInfraccionDenunciada).HasColumnName("idInfraccionDenunciada");

                entity.Property(e => e.IdMedida).HasColumnName("idMedida");

                entity.Property(e => e.IdNudosCriticos).HasColumnName("idNudosCriticos");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");

                entity.Property(e => e.NºcasoFiscalia)
                    .HasMaxLength(50)
                    .HasColumnName("NºCasoFiscalia");

                entity.Property(e => e.NºcausaAcogimiento)
                    .HasMaxLength(150)
                    .HasColumnName("NºCausaAcogimiento");

                entity.Property(e => e.NºprocesoPenaleSatje)
                    .HasMaxLength(50)
                    .HasColumnName("NºProcesoPenaleSatje");

                entity.Property(e => e.Observacion).HasColumnName("observacion");

                entity.Property(e => e.UnidadJudicial)
                    .HasMaxLength(150)
                    .HasColumnName("unidadJudicial");

                entity.Property(e => e.UnidadTraslado).HasColumnName("unidadTraslado");

                entity.HasOne(d => d.IdEstadoProcesalNavigation)
                    .WithMany(p => p.DatosJudicialPenals)
                    .HasForeignKey(d => d.IdEstadoProcesal)
                    .HasConstraintName("FK_DatosJudicialPenal_EstadoProcesal");

                entity.HasOne(d => d.IdInfraccionDenunciadaNavigation)
                    .WithMany(p => p.DatosJudicialPenals)
                    .HasForeignKey(d => d.IdInfraccionDenunciada)
                    .HasConstraintName("FK_DatosJudicialPenal_InfraccionDenunciada");

                entity.HasOne(d => d.IdMedidaNavigation)
                    .WithMany(p => p.DatosJudicialPenals)
                    .HasForeignKey(d => d.IdMedida)
                    .HasConstraintName("FK_DatosJudicialPenal_Medida");

                entity.HasOne(d => d.IdNudosCriticosNavigation)
                    .WithMany(p => p.DatosJudicialPenals)
                    .HasForeignKey(d => d.IdNudosCriticos)
                    .HasConstraintName("FK_DatosJudicialPenal_NudosCriticos");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.DatosJudicialPenals)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_DatosJudicialPenal_Persona");
            });

            modelBuilder.Entity<DatosSalud>(entity =>
            {
                entity.HasKey(e => e.IdDatosSalud);

                entity.ToTable("DatosSalud");

                entity.Property(e => e.IdDatosSalud)
                    .ValueGeneratedNever()
                    .HasColumnName("idDatosSalud");

                entity.Property(e => e.AdolescentePerdiodoGestacion).HasColumnName("adolescentePerdiodoGestacion");

                entity.Property(e => e.AlgunaDiscapacidad).HasColumnName("algunaDiscapacidad");

                entity.Property(e => e.DetalleEnfermedad)
                    .HasMaxLength(120)
                    .HasColumnName("detalleEnfermedad");

                entity.Property(e => e.EstadoSalud)
                    .HasMaxLength(15)
                    .HasColumnName("estadoSalud")
                    .IsFixedLength(true);

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.Property(e => e.Medicacion).HasColumnName("medicacion");

                entity.Property(e => e.NumeroCarnet)
                    .HasMaxLength(40)
                    .HasColumnName("numeroCarnet");

                entity.Property(e => e.PorcentajeDiscapacidad)
                    .HasMaxLength(6)
                    .HasColumnName("porcentajeDiscapacidad");

                entity.Property(e => e.TipoDiscapacidad)
                    .HasMaxLength(50)
                    .HasColumnName("tipoDiscapacidad");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.DatosSaluds)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_DatosSalud_Persona");
            });

            modelBuilder.Entity<EstadoProcesal>(entity =>
            {
                entity.HasKey(e => e.IdEstadoProcesal);

                entity.ToTable("EstadoProcesal");

                entity.Property(e => e.IdEstadoProcesal)
                    .ValueGeneratedNever()
                    .HasColumnName("idEstadoProcesal");

                entity.Property(e => e.DescripcionProcesal)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionProcesal");
            });

            modelBuilder.Entity<Etnium>(entity =>
            {
                entity.HasKey(e => e.IdEtnia);

                entity.Property(e => e.IdEtnia)
                    .ValueGeneratedNever()
                    .HasColumnName("idEtnia");

                entity.Property(e => e.DescripcionEtnia)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionEtnia");
            });

            modelBuilder.Entity<FamiliarReferente>(entity =>
            {
                entity.HasKey(e => e.IdFamiliarReferente);

                entity.ToTable("FamiliarReferente");

                entity.Property(e => e.IdFamiliarReferente)
                    .ValueGeneratedNever()
                    .HasColumnName("idFamiliarReferente");

                entity.Property(e => e.DescripcionFamiliarReferente)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionFamiliarReferente");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero);

                entity.ToTable("Genero");

                entity.Property(e => e.IdGenero)
                    .ValueGeneratedNever()
                    .HasColumnName("idGenero");

                entity.Property(e => e.DescripcionGenero)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionGenero");
            });

            modelBuilder.Entity<HistorialCronologico>(entity =>
            {
                entity.HasKey(e => e.IdHistorial);

                entity.ToTable("HistorialCronologico");

                entity.Property(e => e.IdHistorial)
                    .ValueGeneratedNever()
                    .HasColumnName("idHistorial");

                entity.Property(e => e.EstuboAcogimiento).HasColumnName("estuboAcogimiento");

                entity.Property(e => e.FechaEgreso)
                    .HasColumnType("date")
                    .HasColumnName("fechaEgreso");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnType("date")
                    .HasColumnName("fechaIngreso");

                entity.Property(e => e.IdNombreCasaAnterior).HasColumnName("idNombreCasaAnterior");

                entity.Property(e => e.IdPersona).HasColumnName("idPersona");

                entity.HasOne(d => d.IdNombreCasaAnteriorNavigation)
                    .WithMany(p => p.HistorialCronologicos)
                    .HasForeignKey(d => d.IdNombreCasaAnterior)
                    .HasConstraintName("FK_HistorialCronologico_CasaAcogimiento");

                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.HistorialCronologicos)
                    .HasForeignKey(d => d.IdPersona)
                    .HasConstraintName("FK_HistorialCronologico_Persona");
            });

            modelBuilder.Entity<InfraccionDenunciadum>(entity =>
            {
                entity.HasKey(e => e.IdInfraccionDenunciada);

                entity.Property(e => e.IdInfraccionDenunciada)
                    .ValueGeneratedNever()
                    .HasColumnName("idInfraccionDenunciada");

                entity.Property(e => e.DescripcionInfraccionDenuncia)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionInfraccionDenuncia");
            });

            modelBuilder.Entity<Medidum>(entity =>
            {
                entity.HasKey(e => e.IdMedida);

                entity.Property(e => e.IdMedida)
                    .ValueGeneratedNever()
                    .HasColumnName("idMedida");

                entity.Property(e => e.DescripcionMedida)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionMedida");
            });

            modelBuilder.Entity<Modalidad>(entity =>
            {
                entity.HasKey(e => e.IdModalidad);

                entity.ToTable("Modalidad");

                entity.Property(e => e.IdModalidad)
                    .ValueGeneratedNever()
                    .HasColumnName("idModalidad");

                entity.Property(e => e.DescripcionModalidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("descripcionModalidad");
            });

            modelBuilder.Entity<MotivoIngreso>(entity =>
            {
                entity.HasKey(e => e.IdMotivoIngreso);

                entity.ToTable("MotivoIngreso");

                entity.Property(e => e.IdMotivoIngreso)
                    .ValueGeneratedNever()
                    .HasColumnName("idMotivoIngreso");

                entity.Property(e => e.DescripcionMotivoIngreso)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionMotivoIngreso");
            });

            modelBuilder.Entity<Nacionalidad>(entity =>
            {
                entity.HasKey(e => e.IdNacionalidad);

                entity.ToTable("Nacionalidad");

                entity.Property(e => e.IdNacionalidad)
                    .ValueGeneratedNever()
                    .HasColumnName("idNacionalidad");

                entity.Property(e => e.DescripcionNacionalidad)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionNacionalidad");
            });

            modelBuilder.Entity<NivelAcademico>(entity =>
            {
                entity.HasKey(e => e.IdNivelAcademico)
                    .HasName("PK_idNivelAcademico");

                entity.ToTable("NivelAcademico");

                entity.Property(e => e.IdNivelAcademico)
                    .ValueGeneratedNever()
                    .HasColumnName("idNivelAcademico");

                entity.Property(e => e.DescripcionAcademico)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionAcademico");
            });

            modelBuilder.Entity<NudosCritico>(entity =>
            {
                entity.HasKey(e => e.IdNudosCriticos);

                entity.Property(e => e.IdNudosCriticos)
                    .ValueGeneratedNever()
                    .HasColumnName("idNudosCriticos");

                entity.Property(e => e.DescripcionNudosCriticos).HasColumnName("descripcionNudosCriticos");
            });

            modelBuilder.Entity<Organizacion>(entity =>
            {
                entity.HasKey(e => e.IdOrganizacion)
                    .HasName("PK_organizacion");

                entity.ToTable("Organizacion");

                entity.Property(e => e.IdOrganizacion)
                    .ValueGeneratedNever()
                    .HasColumnName("idOrganizacion");

                entity.Property(e => e.DescripcionOrganizacion).HasColumnName("descripcionOrganizacion");
            });

            modelBuilder.Entity<Parroquium>(entity =>
            {
                entity.HasKey(e => e.IdParroquia);

                entity.Property(e => e.IdParroquia)
                    .ValueGeneratedNever()
                    .HasColumnName("idParroquia");

                entity.Property(e => e.DescripcionParroquia).HasColumnName("descripcionParroquia");

                entity.Property(e => e.IdCanton).HasColumnName("idCanton");

                entity.HasOne(d => d.IdCantonNavigation)
                    .WithMany(p => p.Parroquia)
                    .HasForeignKey(d => d.IdCanton)
                    .HasConstraintName("FK_Parroquia_Canton");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona);

                entity.ToTable("Persona");

                entity.Property(e => e.IdPersona)
                    .ValueGeneratedNever()
                    .HasColumnName("idPersona");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Barrio).HasColumnName("barrio");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(120)
                    .HasColumnName("direccion");

                entity.Property(e => e.DocumentoIdentidad)
                    .HasMaxLength(20)
                    .HasColumnName("documentoIdentidad");

                entity.Property(e => e.Edad)
                    .HasMaxLength(3)
                    .HasColumnName("edad")
                    .IsFixedLength(true);

                entity.Property(e => e.EdadIngreso)
                    .HasMaxLength(10)
                    .HasColumnName("edadIngreso");

                entity.Property(e => e.FechaDeIngresoUnidadAtencion)
                    .HasColumnType("date")
                    .HasColumnName("fechaDeIngresoUnidadAtencion");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechaNacimiento");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("fechaRegistro");

                entity.Property(e => e.IdCanton).HasColumnName("idCanton");

                entity.Property(e => e.IdEtnia).HasColumnName("idEtnia");

                entity.Property(e => e.IdGenero).HasColumnName("idGenero");

                entity.Property(e => e.IdModalidad).HasColumnName("idModalidad");

                entity.Property(e => e.IdMotivoIngreso).HasColumnName("idMotivoIngreso");

                entity.Property(e => e.IdNacionalidad).HasColumnName("idNacionalidad");

                entity.Property(e => e.IdOrganizacion).HasColumnName("idOrganizacion");

                entity.Property(e => e.IdParroquia).HasColumnName("idParroquia");

                entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(100)
                    .HasColumnName("nombreCompleto");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .HasColumnName("nombres");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasColumnName("telefono");

                entity.Property(e => e.TiempoPermanenciaAños)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tiempoPermanenciaAños");

                entity.HasOne(d => d.IdCantonNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdCanton)
                    .HasConstraintName("FK_Persona_Canton");

                entity.HasOne(d => d.IdEtniaNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdEtnia)
                    .HasConstraintName("FK_Persona_Etnia");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdGenero)
                    .HasConstraintName("FK_Persona_Genero");

                entity.HasOne(d => d.IdModalidadNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdModalidad)
                    .HasConstraintName("FK_Persona_Modalidad");

                entity.HasOne(d => d.IdMotivoIngresoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdMotivoIngreso)
                    .HasConstraintName("FK_Persona_MotivoIngreso");

                entity.HasOne(d => d.IdNacionalidadNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdNacionalidad)
                    .HasConstraintName("FK_Persona_Nacionalidad");

                entity.HasOne(d => d.IdOrganizacionNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdOrganizacion)
                    .HasConstraintName("FK_Persona_Organizacion");

                entity.HasOne(d => d.IdParroquiaNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdParroquia)
                    .HasConstraintName("FK_Persona_Parroquia");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("FK_Persona_Provincia");
            });

            modelBuilder.Entity<Pgf>(entity =>
            {
                entity.HasKey(e => e.IdPgf);

                entity.ToTable("PGF");

                entity.Property(e => e.IdPgf)
                    .ValueGeneratedNever()
                    .HasColumnName("idPGF");

                entity.Property(e => e.IdCanton).HasColumnName("idCanton");

                entity.Property(e => e.IdFamiliarReferente).HasColumnName("idFamiliarReferente");

                entity.Property(e => e.IdNivelAcademico).HasColumnName("idNivelAcademico");

                entity.Property(e => e.IdPeronsa).HasColumnName("idPeronsa");

                entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");

                entity.Property(e => e.NnaInsertoSistemaEducativo).HasColumnName("NNA_insertoSistemaEducativo");

                entity.Property(e => e.NombreFamiliar)
                    .HasMaxLength(50)
                    .HasColumnName("nombreFamiliar");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdCantonNavigation)
                    .WithMany(p => p.Pgfs)
                    .HasForeignKey(d => d.IdCanton)
                    .HasConstraintName("FK_PGF_Canton");

                entity.HasOne(d => d.IdFamiliarReferenteNavigation)
                    .WithMany(p => p.Pgfs)
                    .HasForeignKey(d => d.IdFamiliarReferente)
                    .HasConstraintName("FK_PGF_FamiliarReferente");

                entity.HasOne(d => d.IdNivelAcademicoNavigation)
                    .WithMany(p => p.Pgfs)
                    .HasForeignKey(d => d.IdNivelAcademico)
                    .HasConstraintName("FK_PGF_idNivelAcademico");

                entity.HasOne(d => d.IdPeronsaNavigation)
                    .WithMany(p => p.Pgfs)
                    .HasForeignKey(d => d.IdPeronsa)
                    .HasConstraintName("FK_PGF_Persona");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Pgfs)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("FK_PGF_Provincia");
            });

            modelBuilder.Entity<Provincium>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.Property(e => e.IdProvincia)
                    .ValueGeneratedNever()
                    .HasColumnName("idProvincia");

                entity.Property(e => e.DescripcionProvincia).HasColumnName("descripcionProvincia");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
