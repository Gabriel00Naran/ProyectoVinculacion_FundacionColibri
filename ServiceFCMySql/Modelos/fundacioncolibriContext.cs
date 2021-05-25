using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WebServiceFCMySql.Autenticacion;

#nullable disable

namespace WebServiceFCMySql.Modelos
{
    public partial class fundacioncolibriContext : IdentityDbContext<AplicacionUsuario>
    {
        public fundacioncolibriContext()
        {

        }
        public fundacioncolibriContext(DbContextOptions<fundacioncolibriContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Canton> Cantons { get; set; }
        public virtual DbSet<Casaacogimiento> Casaacogimientos { get; set; }
        public virtual DbSet<Datosjudicialpenal> Datosjudicialpenals { get; set; }
        public virtual DbSet<Datossalud> Datossaluds { get; set; }
        public virtual DbSet<Estadoprocesal> Estadoprocesals { get; set; }
        public virtual DbSet<Etnium> Etnia { get; set; }
        public virtual DbSet<Familiarreferente> Familiarreferentes { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Historialcronologico> Historialcronologicos { get; set; }
        public virtual DbSet<Infracciondenunciadum> Infracciondenunciada { get; set; }
        public virtual DbSet<Medidum> Medida { get; set; }
        public virtual DbSet<Modalidad> Modalidads { get; set; }
        public virtual DbSet<Motivoingreso> Motivoingresos { get; set; }
        public virtual DbSet<Nacionalidad> Nacionalidads { get; set; }
        public virtual DbSet<Nivelacademico> Nivelacademicos { get; set; }
        public virtual DbSet<Nudoscritico> Nudoscriticos { get; set; }
        public virtual DbSet<Organizacion> Organizacions { get; set; }
        public virtual DbSet<Parroquium> Parroquia { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Pgf> Pgfs { get; set; }
        public virtual DbSet<Provincium> Provincia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=123456;database=fundacioncolibri;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Canton>(entity =>
            {
                entity.HasKey(e => e.Idcanton)
                    .HasName("PRIMARY");

                entity.ToTable("canton");

                entity.HasIndex(e => e.Idprovincia, "fk_canton_provincia");

                entity.Property(e => e.Idcanton).HasColumnName("idcanton");

                entity.Property(e => e.Descripcioncanton)
                    .HasColumnType("longtext")
                    .HasColumnName("descripcioncanton");

                entity.Property(e => e.Idprovincia).HasColumnName("idprovincia");

                entity.HasOne(d => d.IdprovinciaNavigation)
                    .WithMany(p => p.Cantons)
                    .HasForeignKey(d => d.Idprovincia)
                    .HasConstraintName("fk_canton_provincia");
            });

            modelBuilder.Entity<Casaacogimiento>(entity =>
            {
                entity.HasKey(e => e.Idnombrecasaanterior)
                    .HasName("PRIMARY");

                entity.ToTable("casaacogimiento");

                entity.Property(e => e.Idnombrecasaanterior).HasColumnName("idnombrecasaanterior");

                entity.Property(e => e.Descripcioncasaacogimiento)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("descripcioncasaacogimiento");
            });

            modelBuilder.Entity<Datosjudicialpenal>(entity =>
            {
                entity.HasKey(e => e.Idjudicialpenal)
                    .HasName("PRIMARY");

                entity.ToTable("datosjudicialpenal");

                entity.HasIndex(e => e.Idestadoprocesal, "fk_datosjudicialpenal_estadoprocesal");

                entity.HasIndex(e => e.Idinfracciondenunciada, "fk_datosjudicialpenal_infracciondenunciada");

                entity.HasIndex(e => e.Idmedida, "fk_datosjudicialpenal_medida");

                entity.HasIndex(e => e.Idnudoscriticos, "fk_datosjudicialpenal_nudoscriticos");

                entity.HasIndex(e => e.Idpersona, "fk_datosjudicialpenal_persona");

                entity.Property(e => e.Idjudicialpenal).HasColumnName("idjudicialpenal");

                entity.Property(e => e.Descripciondelito)
                    .HasColumnType("longtext")
                    .HasColumnName("descripciondelito");

                entity.Property(e => e.Egresoporreinsercion)
                    .HasColumnType("bit(1)")
                    .HasColumnName("egresoporreinsercion");

                entity.Property(e => e.EncuentrainsertSpavt)
                    .HasColumnType("bit(1)")
                    .HasColumnName("encuentrainsert@spavt");

                entity.Property(e => e.Existecausapenal)
                    .HasColumnType("bit(1)")
                    .HasColumnName("existecausapenal");

                entity.Property(e => e.Fechaegreso)
                    .HasColumnType("date")
                    .HasColumnName("fechaegreso");

                entity.Property(e => e.Fechareinsercion)
                    .HasColumnType("date")
                    .HasColumnName("fechareinsercion");

                entity.Property(e => e.Fecharesoluciontraslado)
                    .HasColumnType("date")
                    .HasColumnName("fecharesoluciontraslado");

                entity.Property(e => e.Fechasalidaunidadactual)
                    .HasColumnType("date")
                    .HasColumnName("fechasalidaunidadactual");

                entity.Property(e => e.Idcanton).HasColumnName("idcanton");

                entity.Property(e => e.Idestadoprocesal).HasColumnName("idestadoprocesal");

                entity.Property(e => e.Idinfracciondenunciada).HasColumnName("idinfracciondenunciada");

                entity.Property(e => e.Idmedida).HasColumnName("idmedida");

                entity.Property(e => e.Idnudoscriticos).HasColumnName("idnudoscriticos");

                entity.Property(e => e.Idpersona).HasColumnName("idpersona");

                entity.Property(e => e.Idprovincia).HasColumnName("idprovincia");

                entity.Property(e => e.Ncasofiscalia)
                    .HasMaxLength(50)
                    .HasColumnName("ncasofiscalia");

                entity.Property(e => e.Ncausaacogimiento)
                    .HasMaxLength(150)
                    .HasColumnName("ncausaacogimiento");

                entity.Property(e => e.Nprocesopenalesatje)
                    .HasMaxLength(50)
                    .HasColumnName("nprocesopenalesatje");

                entity.Property(e => e.Observacion)
                    .HasColumnType("longtext")
                    .HasColumnName("observacion");

                entity.Property(e => e.Unidadjudicial)
                    .HasMaxLength(150)
                    .HasColumnName("unidadjudicial");

                entity.Property(e => e.Unidadtraslado)
                    .HasColumnType("longtext")
                    .HasColumnName("unidadtraslado");

                entity.HasOne(d => d.IdestadoprocesalNavigation)
                    .WithMany(p => p.Datosjudicialpenals)
                    .HasForeignKey(d => d.Idestadoprocesal)
                    .HasConstraintName("fk_datosjudicialpenal_estadoprocesal");

                entity.HasOne(d => d.IdinfracciondenunciadaNavigation)
                    .WithMany(p => p.Datosjudicialpenals)
                    .HasForeignKey(d => d.Idinfracciondenunciada)
                    .HasConstraintName("fk_datosjudicialpenal_infracciondenunciada");

                entity.HasOne(d => d.IdmedidaNavigation)
                    .WithMany(p => p.Datosjudicialpenals)
                    .HasForeignKey(d => d.Idmedida)
                    .HasConstraintName("fk_datosjudicialpenal_medida");

                entity.HasOne(d => d.IdnudoscriticosNavigation)
                    .WithMany(p => p.Datosjudicialpenals)
                    .HasForeignKey(d => d.Idnudoscriticos)
                    .HasConstraintName("fk_datosjudicialpenal_nudoscriticos");

                entity.HasOne(d => d.IdpersonaNavigation)
                    .WithMany(p => p.Datosjudicialpenals)
                    .HasForeignKey(d => d.Idpersona)
                    .HasConstraintName("fk_datosjudicialpenal_persona");
            });

            modelBuilder.Entity<Datossalud>(entity =>
            {
                entity.HasKey(e => e.Iddatossalud)
                    .HasName("PRIMARY");

                entity.ToTable("datossalud");

                entity.HasIndex(e => e.Idpersona, "fk_datossalud_persona");

                entity.Property(e => e.Iddatossalud).HasColumnName("iddatossalud");

                entity.Property(e => e.Adolescenteperdiodogestacion)
                    .HasColumnType("bit(1)")
                    .HasColumnName("adolescenteperdiodogestacion");

                entity.Property(e => e.Algunadiscapacidad)
                    .HasColumnType("bit(1)")
                    .HasColumnName("algunadiscapacidad");

                entity.Property(e => e.Detalleenfermedad)
                    .HasMaxLength(120)
                    .HasColumnName("detalleenfermedad");

                entity.Property(e => e.Estadosalud)
                    .HasMaxLength(15)
                    .HasColumnName("estadosalud")
                    .IsFixedLength(true);

                entity.Property(e => e.Idpersona).HasColumnName("idpersona");

                entity.Property(e => e.Medicacion)
                    .HasColumnType("bit(1)")
                    .HasColumnName("medicacion");

                entity.Property(e => e.Numerocarnet)
                    .HasMaxLength(40)
                    .HasColumnName("numerocarnet");

                entity.Property(e => e.Porcentajediscapacidad)
                    .HasMaxLength(6)
                    .HasColumnName("porcentajediscapacidad");

                entity.Property(e => e.Tipodiscapacidad)
                    .HasMaxLength(50)
                    .HasColumnName("tipodiscapacidad");
            });

            modelBuilder.Entity<Estadoprocesal>(entity =>
            {
                entity.HasKey(e => e.Idestadoprocesal)
                    .HasName("PRIMARY");

                entity.ToTable("estadoprocesal");

                entity.Property(e => e.Idestadoprocesal).HasColumnName("idestadoprocesal");

                entity.Property(e => e.Descripcionprocesal)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionprocesal");
            });

            modelBuilder.Entity<Etnium>(entity =>
            {
                entity.HasKey(e => e.Idetnia)
                    .HasName("PRIMARY");

                entity.ToTable("etnia");

                entity.Property(e => e.Idetnia).HasColumnName("idetnia");

                entity.Property(e => e.Descripcionetnia)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionetnia");
            });

            modelBuilder.Entity<Familiarreferente>(entity =>
            {
                entity.HasKey(e => e.Idfamiliarreferente)
                    .HasName("PRIMARY");

                entity.ToTable("familiarreferente");

                entity.Property(e => e.Idfamiliarreferente).HasColumnName("idfamiliarreferente");

                entity.Property(e => e.Descripcionfamiliarreferente)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionfamiliarreferente");
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.Idgenero)
                    .HasName("PRIMARY");

                entity.ToTable("genero");

                entity.Property(e => e.Idgenero).HasColumnName("idgenero");

                entity.Property(e => e.Descripciongenero)
                    .HasMaxLength(50)
                    .HasColumnName("descripciongenero");
            });

            modelBuilder.Entity<Historialcronologico>(entity =>
            {
                entity.HasKey(e => e.Idhistorial)
                    .HasName("PRIMARY");

                entity.ToTable("historialcronologico");

                entity.HasIndex(e => e.Idnombrecasaanterior, "fk_historialcronologico_casaacogimiento");

                entity.HasIndex(e => e.Idpersona, "fk_historialcronologico_persona");

                entity.Property(e => e.Idhistorial).HasColumnName("idhistorial");

                entity.Property(e => e.Estuboacogimiento)
                    .HasColumnType("bit(1)")
                    .HasColumnName("estuboacogimiento");

                entity.Property(e => e.Fechaegreso)
                    .HasColumnType("date")
                    .HasColumnName("fechaegreso");

                entity.Property(e => e.Fechaingreso)
                    .HasColumnType("date")
                    .HasColumnName("fechaingreso");

                entity.Property(e => e.Idnombrecasaanterior).HasColumnName("idnombrecasaanterior");

                entity.Property(e => e.Idpersona).HasColumnName("idpersona");

                entity.HasOne(d => d.IdnombrecasaanteriorNavigation)
                    .WithMany(p => p.Historialcronologicos)
                    .HasForeignKey(d => d.Idnombrecasaanterior)
                    .HasConstraintName("fk_historialcronologico_casaacogimiento");

                entity.HasOne(d => d.IdpersonaNavigation)
                    .WithMany(p => p.Historialcronologicos)
                    .HasForeignKey(d => d.Idpersona)
                    .HasConstraintName("fk_historialcronologico_persona");
            });

            modelBuilder.Entity<Infracciondenunciadum>(entity =>
            {
                entity.HasKey(e => e.Idinfracciondenunciada)
                    .HasName("PRIMARY");

                entity.ToTable("infracciondenunciada");

                entity.Property(e => e.Idinfracciondenunciada).HasColumnName("idinfracciondenunciada");

                entity.Property(e => e.Descripcioninfracciondenuncia)
                    .HasMaxLength(50)
                    .HasColumnName("descripcioninfracciondenuncia");
            });

            modelBuilder.Entity<Medidum>(entity =>
            {
                entity.HasKey(e => e.Idmedida)
                    .HasName("PRIMARY");

                entity.ToTable("medida");

                entity.Property(e => e.Idmedida).HasColumnName("idmedida");

                entity.Property(e => e.Descripcionmedida)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionmedida");
            });

            modelBuilder.Entity<Modalidad>(entity =>
            {
                entity.HasKey(e => e.Idmodalidad)
                    .HasName("PRIMARY");

                entity.ToTable("modalidad");

                entity.Property(e => e.Idmodalidad).HasColumnName("idmodalidad");

                entity.Property(e => e.Descripcionmodalidad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("descripcionmodalidad");
            });

            modelBuilder.Entity<Motivoingreso>(entity =>
            {
                entity.HasKey(e => e.Idmotivoingreso)
                    .HasName("PRIMARY");

                entity.ToTable("motivoingreso");

                entity.Property(e => e.Idmotivoingreso).HasColumnName("idmotivoingreso");

                entity.Property(e => e.Descripcionmotivoingreso)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionmotivoingreso");
            });

            modelBuilder.Entity<Nacionalidad>(entity =>
            {
                entity.HasKey(e => e.Idnacionalidad)
                    .HasName("PRIMARY");

                entity.ToTable("nacionalidad");

                entity.Property(e => e.Idnacionalidad).HasColumnName("idnacionalidad");

                entity.Property(e => e.Descripcionnacionalidad)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionnacionalidad");
            });

            modelBuilder.Entity<Nivelacademico>(entity =>
            {
                entity.HasKey(e => e.Idnivelacademico)
                    .HasName("PRIMARY");

                entity.ToTable("nivelacademico");

                entity.Property(e => e.Idnivelacademico).HasColumnName("idnivelacademico");

                entity.Property(e => e.Descripcionacademico)
                    .HasMaxLength(50)
                    .HasColumnName("descripcionacademico");
            });

            modelBuilder.Entity<Nudoscritico>(entity =>
            {
                entity.HasKey(e => e.Idnudoscriticos)
                    .HasName("PRIMARY");

                entity.ToTable("nudoscriticos");

                entity.Property(e => e.Idnudoscriticos).HasColumnName("idnudoscriticos");

                entity.Property(e => e.Descripcionnudoscriticos)
                    .HasColumnType("longtext")
                    .HasColumnName("descripcionnudoscriticos");
            });

            modelBuilder.Entity<Organizacion>(entity =>
            {
                entity.HasKey(e => e.Idorganizacion)
                    .HasName("PRIMARY");

                entity.ToTable("organizacion");

                entity.Property(e => e.Idorganizacion).HasColumnName("idorganizacion");

                entity.Property(e => e.Descripcionorganizacion)
                    .HasColumnType("longtext")
                    .HasColumnName("descripcionorganizacion");
            });

            modelBuilder.Entity<Parroquium>(entity =>
            {
                entity.HasKey(e => e.Idparroquia)
                    .HasName("PRIMARY");

                entity.ToTable("parroquia");

                entity.HasIndex(e => e.Idcanton, "fk_parroquia_canton");

                entity.Property(e => e.Idparroquia).HasColumnName("idparroquia");

                entity.Property(e => e.Descripcionparroquia)
                    .HasColumnType("longtext")
                    .HasColumnName("descripcionparroquia");

                entity.Property(e => e.Idcanton).HasColumnName("idcanton");

                entity.HasOne(d => d.IdcantonNavigation)
                    .WithMany(p => p.Parroquia)
                    .HasForeignKey(d => d.Idcanton)
                    .HasConstraintName("fk_parroquia_canton");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.Idpersona)
                    .HasName("PRIMARY");

                entity.ToTable("persona");

                entity.HasIndex(e => e.Idcanton, "fk_persona_canton");

                entity.HasIndex(e => e.Idetnia, "fk_persona_etnia");

                entity.HasIndex(e => e.Idgenero, "fk_persona_genero");

                entity.HasIndex(e => e.Idmodalidad, "fk_persona_modalidad");

                entity.HasIndex(e => e.Idmotivoingreso, "fk_persona_motivoingreso");

                entity.HasIndex(e => e.Idnacionalidad, "fk_persona_nacionalidad");

                entity.HasIndex(e => e.Idorganizacion, "fk_persona_organizacion");

                entity.HasIndex(e => e.Idparroquia, "fk_persona_parroquia");

                entity.HasIndex(e => e.Idprovincia, "fk_persona_provincia");

                entity.Property(e => e.Idpersona).HasColumnName("idpersona");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .HasColumnName("apellidos");

                entity.Property(e => e.Barrio)
                    .HasColumnType("longtext")
                    .HasColumnName("barrio");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(120)
                    .HasColumnName("direccion");

                entity.Property(e => e.Documentoidentidad)
                    .HasMaxLength(20)
                    .HasColumnName("documentoidentidad");

                entity.Property(e => e.Edad)
                    .HasMaxLength(3)
                    .HasColumnName("edad")
                    .IsFixedLength(true);

                entity.Property(e => e.Edadingreso)
                    .HasMaxLength(10)
                    .HasColumnName("edadingreso");

                entity.Property(e => e.Fechadeingresounidadatencion)
                    .HasColumnType("date")
                    .HasColumnName("fechadeingresounidadatencion");

                entity.Property(e => e.Fechanacimiento)
                    .HasColumnType("date")
                    .HasColumnName("fechanacimiento");

                entity.Property(e => e.Fecharegistro)
                    .HasColumnType("datetime(6)")
                    .HasColumnName("fecharegistro");

                entity.Property(e => e.Idcanton).HasColumnName("idcanton");

                entity.Property(e => e.Idetnia).HasColumnName("idetnia");

                entity.Property(e => e.Idgenero).HasColumnName("idgenero");

                entity.Property(e => e.Idmodalidad).HasColumnName("idmodalidad");

                entity.Property(e => e.Idmotivoingreso).HasColumnName("idmotivoingreso");

                entity.Property(e => e.Idnacionalidad).HasColumnName("idnacionalidad");

                entity.Property(e => e.Idorganizacion).HasColumnName("idorganizacion");

                entity.Property(e => e.Idparroquia).HasColumnName("idparroquia");

                entity.Property(e => e.Idprovincia).HasColumnName("idprovincia");

                entity.Property(e => e.Nombrecompleto)
                    .HasMaxLength(100)
                    .HasColumnName("nombrecompleto");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .HasColumnName("nombres");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasColumnName("telefono");

                entity.Property(e => e.Tiempopermanenciaannios)
                    .HasMaxLength(50)
                    .HasColumnName("tiempopermanenciaaños");

                entity.HasOne(d => d.IdcantonNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Idcanton)
                    .HasConstraintName("fk_persona_canton");

                entity.HasOne(d => d.IdetniaNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Idetnia)
                    .HasConstraintName("fk_persona_etnia");

                entity.HasOne(d => d.IdgeneroNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Idgenero)
                    .HasConstraintName("fk_persona_genero");

                entity.HasOne(d => d.IdmodalidadNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Idmodalidad)
                    .HasConstraintName("fk_persona_modalidad");

                entity.HasOne(d => d.IdmotivoingresoNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Idmotivoingreso)
                    .HasConstraintName("fk_persona_motivoingreso");

                entity.HasOne(d => d.IdnacionalidadNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Idnacionalidad)
                    .HasConstraintName("fk_persona_nacionalidad");

                entity.HasOne(d => d.IdorganizacionNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Idorganizacion)
                    .HasConstraintName("fk_persona_organizacion");

                entity.HasOne(d => d.IdparroquiaNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Idparroquia)
                    .HasConstraintName("fk_persona_parroquia");

                entity.HasOne(d => d.IdprovinciaNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.Idprovincia)
                    .HasConstraintName("fk_persona_provincia");
            });

            modelBuilder.Entity<Pgf>(entity =>
            {
                entity.HasKey(e => e.Idpgf)
                    .HasName("PRIMARY");

                entity.ToTable("pgf");

                entity.HasIndex(e => e.Idcanton, "fk_pgf_canton");

                entity.HasIndex(e => e.Idfamiliarreferente, "fk_pgf_familiarreferente");

                entity.HasIndex(e => e.Idnivelacademico, "fk_pgf_idnivelacademico");

                entity.HasIndex(e => e.Idperonsa, "fk_pgf_persona");

                entity.HasIndex(e => e.Idprovincia, "fk_pgf_provincia");

                entity.Property(e => e.Idpgf).HasColumnName("idpgf");

                entity.Property(e => e.Direccion)
                    .HasColumnType("longtext")
                    .HasColumnName("direccion");

                entity.Property(e => e.Idcanton).HasColumnName("idcanton");

                entity.Property(e => e.Idfamiliarreferente).HasColumnName("idfamiliarreferente");

                entity.Property(e => e.Idnivelacademico).HasColumnName("idnivelacademico");

                entity.Property(e => e.Idperonsa).HasColumnName("idperonsa");

                entity.Property(e => e.Idprovincia).HasColumnName("idprovincia");

                entity.Property(e => e.NnaInsertosistemaeducativo)
                    .HasColumnType("bit(1)")
                    .HasColumnName("nna_insertosistemaeducativo");

                entity.Property(e => e.Nombrefamiliar)
                    .HasMaxLength(50)
                    .HasColumnName("nombrefamiliar");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdcantonNavigation)
                    .WithMany(p => p.Pgfs)
                    .HasForeignKey(d => d.Idcanton)
                    .HasConstraintName("fk_pgf_canton");

                entity.HasOne(d => d.IdfamiliarreferenteNavigation)
                    .WithMany(p => p.Pgfs)
                    .HasForeignKey(d => d.Idfamiliarreferente)
                    .HasConstraintName("fk_pgf_familiarreferente");

                entity.HasOne(d => d.IdnivelacademicoNavigation)
                    .WithMany(p => p.Pgfs)
                    .HasForeignKey(d => d.Idnivelacademico)
                    .HasConstraintName("fk_pgf_idnivelacademico");

                entity.Property(e => e.nombreunidad)
                    .HasMaxLength(60)
                    .HasColumnName("nombreunidad");

                entity.HasOne(d => d.IdperonsaNavigation)
                    .WithMany(p => p.Pgfs)
                    .HasForeignKey(d => d.Idperonsa)
                    .HasConstraintName("fk_pgf_persona");

                entity.HasOne(d => d.IdprovinciaNavigation)
                    .WithMany(p => p.Pgfs)
                    .HasForeignKey(d => d.Idprovincia)
                    .HasConstraintName("fk_pgf_provincia");
            });

            modelBuilder.Entity<Provincium>(entity =>
            {
                entity.HasKey(e => e.Idprovincia)
                    .HasName("PRIMARY");

                entity.ToTable("provincia");

                entity.Property(e => e.Idprovincia).HasColumnName("idprovincia");

                entity.Property(e => e.Descripcionprovincia)
                    .HasColumnType("longtext")
                    .HasColumnName("descripcionprovincia");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
