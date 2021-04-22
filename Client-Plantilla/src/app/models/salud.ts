export interface Salud {
    idDatosSalud?: number; /// y cambien de lo que estaba en Guid a number otra vez
    idPersona?: number;
    estadoSalud?:String;
    detalleEnfermedad?: String;
    medicacion?: String;
    adolescentePerdiodoGestacion?: number;
    algunaDiscapacidad?: number;
    tipoDiscapacidad?: String;
    porcentajeDiscapacidad?: String;
    numeroCarnet?: String;
}