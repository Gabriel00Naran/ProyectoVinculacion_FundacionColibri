using System;
using System.Collections.Generic;
using WebServiceFC.Modelos;
namespace WebServiceFC.IServicios
{
    public interface IPersonaService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="persona"></param>  
        /// <returns></returns>  
        IEnumerable<Persona> GetPersona();
        Persona GetPersonaById(Guid idPersona);
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        Persona DeletePersona(Guid idPersona);
    }

    public interface ICantonService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="canton"></param>  
        /// <returns></returns>  
        IEnumerable<Canton> GetCanton();
        Canton GetCantonById(int idCanton);
        Canton AddCanton(Canton canton);
        Canton UpdateCanton(Canton canton);
        Canton DeleteCanton(int idCanton);
    }


    public interface ICasaAcogimientoService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="casaAcogimiento"></param>  
        /// <returns></returns>  
        IEnumerable<CasaAcogimiento> GetCasaAcogimiento();
        CasaAcogimiento GetCasaAcogimientoById(int idNombreCasaAnterior);
        CasaAcogimiento AddCasaAcogimiento(CasaAcogimiento casaAcogimiento);
        CasaAcogimiento UpdateCasaAcogimiento(CasaAcogimiento casaAcogimiento);
        CasaAcogimiento DeleteCasaAcogimiento(int idNombreCasaAnterior);
    }

    public interface IDatosJudicialPenalService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="datosJudicialPenal"></param>  
        /// <returns></returns>  
        IEnumerable<DatosJudicialPenal> GetDatosJudicialPenal();
        DatosJudicialPenal GetDatosJudicialPenalById(Guid idDatosJudicialPenal);
        DatosJudicialPenal AddDatosJudicialPenal(DatosJudicialPenal datosJudicialPenal);
        DatosJudicialPenal UpdateDatosJudicialPenal(DatosJudicialPenal datosJudicialPenal);
        DatosJudicialPenal DeleteDatosJudicialPenal(Guid idDatosJudicialPenal);
    }

    public interface IDatosSaludService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="datosSalud"></param>  
        /// <returns></returns>  
        IEnumerable<DatosSalud> GetDatosSalud();
        DatosSalud GetDatosSaludById(Guid idDatosSalud);
        DatosSalud AddDatosSalud(DatosSalud datosSalud);
        DatosSalud UpdateDatosSalud(DatosSalud datosSalud);
        DatosSalud DeleteDatosSalud(Guid idDatosSalud);
    }

    public interface IEstadoProcesalService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="estadoProcesal"></param>  
        /// <returns></returns>  
        IEnumerable<EstadoProcesal> GetEstadoProcesal();
        EstadoProcesal GetEstadoProcesalById(int idEstadoProcesal);
        EstadoProcesal AddEstadoProcesal(EstadoProcesal estadoProcesal);
        EstadoProcesal UpdateEstadoProcesal(EstadoProcesal estadoProcesal);
        EstadoProcesal DeleteEstadoProcesal(int idEstadoProcesal);
    }

    public interface IEtniaService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="etnia"></param>  
        /// <returns></returns>  
        IEnumerable<Etnium> GetEtnia();
        Etnium GetEtniaById(int idEtnia);
        Etnium AddEtnia(Etnium etnia);
        Etnium UpdateEtnia(Etnium etnia);
        Etnium DeleteEtnia(int idEtnia);
    }

    public interface IFamiliarReferenteService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="familiarReferencia"></param>  
        /// <returns></returns>  
        IEnumerable<FamiliarReferente> GetFamiliarReferente();
        FamiliarReferente GetFamiliarReferenteById(int idFamiliarReferente);
        FamiliarReferente AddFamiliarReferente(FamiliarReferente familiarReferencia);
        FamiliarReferente UpdateFamiliarReferente(FamiliarReferente familiarReferencia);
        FamiliarReferente DeleteFamiliarReferente(int idFamiliarReferente);
    }

    public interface IGeneroService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="genero"></param>  
        /// <returns></returns>  
        IEnumerable<Genero> GetGenero();
        Genero GetGeneroById(int idGenero);
        Genero AddGenero(Genero genero);
        Genero UpdateGenero(Genero genero);
        Genero DeleteGenero(int idGenero);
    }

    public interface IHistorialCronologicoService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="historial"></param>  
        /// <returns></returns>  
        IEnumerable<HistorialCronologico> GetHistorialCronologico();
        HistorialCronologico GetHistorialCronologicoById(Guid idHistorial);
        HistorialCronologico GetHistorialCronologicoByIdPersona(Guid idPersona);
        HistorialCronologico AddHistorialCronologico(HistorialCronologico historial);
        HistorialCronologico UpdateHistorialCronologico(HistorialCronologico historial);
        HistorialCronologico DeleteHistorialCronologico(Guid idHistorial);
    }

    public interface IInfraccionDenunciadaService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="infraccionDenunciada"></param>  
        /// <returns></returns>  
        IEnumerable<InfraccionDenunciadum> GetInfraccionDenunciada();
        InfraccionDenunciadum GetInfraccionDenunciadaById(int idInfraccionDenunciada);
        InfraccionDenunciadum AddInfraccionDenunciada(InfraccionDenunciadum infraccionDenunciada);
        InfraccionDenunciadum UpdateInfraccionDenunciada(InfraccionDenunciadum infraccionDenunciada);
        InfraccionDenunciadum DeleteInfraccionDenunciada(int idInfraccionDenunciada);
    }

    public interface IMedidaService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="medida"></param>  
        /// <returns></returns>  
        IEnumerable<Medidum> GetMedida();
        Medidum GetMedidaById(int idMedida);
        Medidum AddMedida(Medidum medida);
        Medidum UpdateMedida(Medidum medida);
        Medidum DeleteMedida(int idMedida);
    }
    public interface IModalidadService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="modalidad"></param>  
        /// <returns></returns>  
        IEnumerable<Modalidad> GetModalidad();
        Modalidad GetModalidadById(int idModalidad);
        Modalidad AddModalidad(Modalidad modalidad);
        Modalidad UpdateModalidad(Modalidad modalidad);
        Modalidad DeleteModalidad(int idModalidad);
    }

    public interface IMotivoIngresoService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="motivoIngreso"></param>  
        /// <returns></returns>  
        IEnumerable<MotivoIngreso> GetMotivoIngreso();
        MotivoIngreso GetMotivoIngresoById(int idMotivoIngreso);
        MotivoIngreso AddMotivoIngreso(MotivoIngreso motivoIngreso);
        MotivoIngreso UpdateMotivoIngreso(MotivoIngreso motivoIngreso);
        MotivoIngreso DeleteMotivoIngreso(int idMotivoIngreso);
    }

 
    public interface INacionalidadService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="nacionalidad"></param>  
        /// <returns></returns>  
        IEnumerable<Nacionalidad> GetNacionalidad();
        Nacionalidad GetNacionalidadById(int idNacionalidad);
        Nacionalidad AddNacionalidad(Nacionalidad nacionalidad);
        Nacionalidad UpdateNacionalidad(Nacionalidad nacionalidad);
        Nacionalidad DeleteNacionalidad(int idNacionalidad); 
    }

    public interface INivelAcademicoService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="nivelAcademico"></param>  
        /// <returns></returns>  
        IEnumerable<NivelAcademico> GetNivelAcademico();
        NivelAcademico GetNivelAcademicoById(int idNivelAcademico);
        NivelAcademico AddNivelAcademico(NivelAcademico persona);
        NivelAcademico UpdateNivelAcademico(NivelAcademico persona);
        NivelAcademico DeleteNivelAcademico(int idNivelAcademico);
    }

    public interface INudosCriticoService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="NudosCriticos"></param>  
        /// <returns></returns>  
        IEnumerable<NudosCritico> GetNudosCritico();
        NudosCritico GetNudosCriticoById(int idNudosCriticos);
        NudosCritico AddNudosCritico(NudosCritico NudosCriticos);
        NudosCritico UpdateNudosCritico(NudosCritico NudosCriticos);
        NudosCritico DeleteNudosCritico(int idNudosCriticos);
    }

    public interface IOrganizacionService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="organizacion"></param>  
        /// <returns></returns>  
        IEnumerable<Organizacion> GetOrganizacion();
        Organizacion GetOrganizacionById(int idOrganizacion);
        Organizacion AddOrganizacion(Organizacion organizacion);
        Organizacion UpdateOrganizacion(Organizacion organizacion);
        Organizacion DeleteOrganizacion(int idOrganizacion);
    }

    public interface IParroquiaService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="parroquia"></param>  
        /// <returns></returns>  
        IEnumerable<Parroquium> GetParroquia();
        Parroquium GetParroquiaById(int idParroquia);
        Parroquium AddParroquia(Parroquium persona);
        Parroquium UpdateParroquia(Parroquium persona);
        Parroquium DeleteParroquia(int idParroquia);
    }

    public interface IPgfService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="pgf"></param>  
        /// <returns></returns>  
        IEnumerable<Pgf> GetPgf();
        Pgf GetPgfById(Guid idPgf);
        Pgf AddPgf(Pgf pgf);
        Pgf UpdatePgf(Pgf pgf);
        Pgf DeletePgf(Guid idPgf);
    }
   

    public interface IProvinciaService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="provincia"></param>  
        /// <returns></returns>  
        IEnumerable<Provincium> GetProvincia();
        Provincium GetProvinciaById(int idProvincia);
        Provincium AddProvincia(Provincium provincia);
        Provincium UpdateProvincia(Provincium provincia);
        Provincium DeleteProvincia(int idProvincia);
    }

}




