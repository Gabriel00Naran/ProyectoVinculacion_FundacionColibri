import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Persona } from '../models/persona';
import { Guid } from 'guid-typescript';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {

  private Server = 'https://localhost:5001/';
  //private Server = 'https://localhost:44351/';

  /////////////API-REST/////////////////////////
  private GET ='api/Persona/GetPersona';
  private GETbyID ='api/Persona/GetPersonaById?idPersona='
  private POST ='api/Persona/AddPersona/';
  private PUT = 'api/Persona/UpdatePersona?idPersona=';
  private DELETE ='api/Persona/DeletePersona?idPersona=';
  /////////////////////////////////////////////

  constructor(private http: HttpClient) { }

  getPersona(): Observable<any> {
    return this.http.get(this.Server + this.GET);
  }

  deletePersona(idPersona: number): Observable<any> {
    return this.http.delete(this.Server + this.DELETE + idPersona);
  }

  addPersona(persona: Persona): Observable<any> {
    return this.http.post(this.Server + this.POST, persona);
  }

  //// volvi a dejar el tipo de dato en number ya que antes estana en Guid
  getPersonaById(idPersona: number): Observable<any> {
    return this.http.get(this.Server + this.GETbyID + idPersona);
  }
//// lo mismo en el update.
  updatePersona(idPersona: number, persona: Persona): Observable<any> {
    return this.http.put( this.Server + this.PUT + idPersona, persona);
  }
}
