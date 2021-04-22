export interface Historial {
    idHistorial?: number; /// y cambien de lo que estaba en Guid a number otra vez
    idPersona?: number;
    estuvoAcogimiento?:number;
    idNombreCasaAnterior?: number;
    fechaEgreso?: Date;
    fechaIngreso?: Date;
}