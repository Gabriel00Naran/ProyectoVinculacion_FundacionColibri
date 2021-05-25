export interface Persona {
    idPersona?: number; /// y cambien de lo que estaba en Guid a number otra vez
    idOrganizacion?: number;
    idModalidad?: number;
    nombres?: string;
    apellidos?: string;
    nombreCompleto?: string;
    telefono?: string;
    documentoIdentidad?: string;
    idGenero?: number;
    idEtnia?: number;
    idNacionalidad?: number;
    fechaNaciento?: Date;
    fechaRegistro?: Date;
    edad?: string;
    idProvincia?: number;
    idCanton?: number;
    idParroquia?: number;
    barrio?: string;
    direccion?: string;
    fechaDeIngresoUnidadAtencion?: Date;
    edadIngreso?: string;
    tiempoPermanenciaAños?: string;
    idMotivoIngreso?: number;
}
