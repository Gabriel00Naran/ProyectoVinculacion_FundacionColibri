using System;
using System.Collections.Generic;
using WebServiceFCMySql.Modelos;

namespace WebServiceFCMySql.IServicios
{
    public interface IPersonaService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="persona"></param>  
        /// <returns></returns>  
        IEnumerable<Persona> GetPersona(int id);
        Persona GetPersonaById(int idPersona);
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        Persona DeletePersona(int idPersona);
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

        List<Canton> GetCantonByIdProvincia(int idprovincia);
    }


    public interface ICasaAcogimientoService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="casaAcogimiento"></param>  
        /// <returns></returns>  
        IEnumerable<Casaacogimiento> GetCasaAcogimiento();
        Casaacogimiento GetCasaAcogimientoById(int idNombreCasaAnterior);
        Casaacogimiento AddCasaAcogimiento(Casaacogimiento casaAcogimiento);
        Casaacogimiento UpdateCasaAcogimiento(Casaacogimiento casaAcogimiento);
        Casaacogimiento DeleteCasaAcogimiento(int idNombreCasaAnterior);
    }

    public interface IDatosJudicialPenalService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="datosJudicialPenal"></param>  
        /// <returns></returns>  
        IEnumerable<Datosjudicialpenal> GetDatosJudicialPenal();
        Datosjudicialpenal GetDatosJudicialPenalById(int idDatosJudicialPenal);

        List<Datosjudicialpenal> GetDatosJudicialPenalByIdPersona(int idpersona);

        Datosjudicialpenal AddDatosJudicialPenal(Datosjudicialpenal datosJudicialPenal);
        Datosjudicialpenal UpdateDatosJudicialPenal(Datosjudicialpenal datosJudicialPenal);
        Datosjudicialpenal DeleteDatosJudicialPenal(int idDatosJudicialPenal);
    }

    public interface IDatosSaludService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="datosSalud"></param>  
        /// <returns></returns>  
        IEnumerable<Datossalud> GetDatosSalud();
        Datossalud GetDatosSaludById(int idDatosSalud);

        List<Datossalud> GetDatosSaludByIdPersona(int idpersona);
        Datossalud AddDatosSalud(Datossalud datosSalud);
        Datossalud UpdateDatosSalud(Datossalud datosSalud);
        Datossalud DeleteDatosSalud(int idDatosSalud);
    }

    public interface IEstadoProcesalService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="estadoProcesal"></param>  
        /// <returns></returns>  
        IEnumerable<Estadoprocesal> GetEstadoProcesal();
        Estadoprocesal GetEstadoProcesalById(int idEstadoProcesal);
        Estadoprocesal AddEstadoProcesal(Estadoprocesal estadoProcesal);
        Estadoprocesal UpdateEstadoProcesal(Estadoprocesal estadoProcesal);
        Estadoprocesal DeleteEstadoProcesal(int idEstadoProcesal);
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
        IEnumerable<Familiarreferente> GetFamiliarReferente();
        Familiarreferente GetFamiliarReferenteById(int idFamiliarReferente);
        Familiarreferente AddFamiliarReferente(Familiarreferente familiarReferencia);
        Familiarreferente UpdateFamiliarReferente(Familiarreferente familiarReferencia);
        Familiarreferente DeleteFamiliarReferente(int idFamiliarReferente);
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
        IEnumerable<Historialcronologico> GetHistorialCronologico();
        Historialcronologico GetHistorialCronologicoById(int idHistorial);
        List<Historialcronologico> GetHistorialCronologicoByIdPersona(int idpersona);
        Historialcronologico AddHistorialCronologico(Historialcronologico historial);
        Historialcronologico UpdateHistorialCronologico(Historialcronologico historial);
        Historialcronologico DeleteHistorialCronologico(int idHistorial);
    }

    public interface IInfraccionDenunciadaService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="infraccionDenunciada"></param>  
        /// <returns></returns>  
        IEnumerable<Infracciondenunciadum> GetInfraccionDenunciada();
        Infracciondenunciadum GetInfraccionDenunciadaById(int idInfraccionDenunciada);
        Infracciondenunciadum AddInfraccionDenunciada(Infracciondenunciadum infraccionDenunciada);
        Infracciondenunciadum UpdateInfraccionDenunciada(Infracciondenunciadum infraccionDenunciada);
        Infracciondenunciadum DeleteInfraccionDenunciada(int idInfraccionDenunciada);
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
        IEnumerable<Motivoingreso> GetMotivoIngreso();
        Motivoingreso GetMotivoIngresoById(int idMotivoIngreso);
        Motivoingreso AddMotivoIngreso(Motivoingreso motivoIngreso);
        Motivoingreso UpdateMotivoIngreso(Motivoingreso motivoIngreso);
        Motivoingreso DeleteMotivoIngreso(int idMotivoIngreso);
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
        IEnumerable<Nivelacademico> GetNivelAcademico();
        Nivelacademico GetNivelAcademicoById(int idNivelAcademico);
        Nivelacademico AddNivelAcademico(Nivelacademico nivelAcademico);
        Nivelacademico UpdateNivelAcademico(Nivelacademico nivelAcademico);
        Nivelacademico DeleteNivelAcademico(int idNivelAcademico);
    }

    public interface INudosCriticoService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="NudosCriticos"></param>  
        /// <returns></returns>  
        IEnumerable<Nudoscritico> GetNudosCritico();
        Nudoscritico GetNudosCriticoById(int idNudosCriticos);
        Nudoscritico AddNudosCritico(Nudoscritico NudosCriticos);
        Nudoscritico UpdateNudosCritico(Nudoscritico NudosCriticos);
        Nudoscritico DeleteNudosCritico(int idNudosCriticos);
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
        List<Parroquium> GetParroquiaByIdCanton(int idcanton);

    }

    public interface IPgfService
    {

        /// <summary>  
        /// aqui se implementan las interfaces de los metodos
        /// </summary>  
        /// <param name="pgf"></param>  
        /// <returns></returns>  
        IEnumerable<Pgf> GetPgf();
        Pgf GetPgfById(int idPgf);
        Pgf AddPgf(Pgf pgf);
        Pgf UpdatePgf(Pgf pgf);
        Pgf DeletePgf(int idPgf);
        List<Pgf> GetPgfByIdPersona(int idpersona);
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




