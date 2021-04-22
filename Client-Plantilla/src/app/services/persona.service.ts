import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Persona } from '../models/persona';
import { Guid } from 'guid-typescript';
import { environment } from 'src/environments/environment';
import { map } from 'rxjs/operators';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
    Accept: 'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class PersonaService {

  
  //private Server = 'https://localhost:44351/';

  /////////////API-REST/////////////////////////
  private GET ='api/Persona/GetPersona';
  private GETbyID ='api/Persona/GetPersonaById?idPersona='
  private POST ='api/Persona/AddPersona/';
  private PUT = 'api/Persona/EditPersona';
  private DELETE ='api/Persona/DeletePersona?idPersona=';
  private GETbyIDCronologico = 'api​/HistorialCronologico​/GetHistorialCronologicoByIdPersona?idPersona='
  /////////////////////////////////////////////

  constructor(private http: HttpClient) { }

  getPersona(): Observable<any> {
    return this.http.get(environment.SERVER + this.GET );
  }

  getCronologico(idPersona): Observable<any> {
    return this.http.get(environment.SERVER + this.GETbyIDCronologico + idPersona);
  }

  deletePersona(idPersona: number): Observable<any> {
    return this.http.delete(environment.SERVER + this.DELETE + idPersona);
  }

  addPersona(persona: Persona): Observable<any> {
    return this.http.post(environment.SERVER+ this.POST, persona);
  }

  //// volvi a dejar el tipo de dato en number ya que antes estana en Guid
  getPersonaById(idPersona): Observable<any> {
    return this.http.get(environment.SERVER + this.GETbyID + idPersona);
  }
//// lo mismo en el update.
  updatePersona(persona: Persona): Observable<any> {
    return this.http.put((environment.SERVER+ this.PUT), persona);
  }

  get(url: string) {
    return this.http.get(environment.SERVER + url).pipe(
      map(data => {
        return data;
      })
    );
  }


  post(data: any) {
    return this.http.post(environment.SERVER + this.POST, data).subscribe(
      response => {

      },
      error => {
      }

    );
  }

  put(data: any) {
    return this.http.put(environment.SERVER + this.PUT, data).subscribe(
      response => {

      },
      error => {
      }

    );
  }
}
