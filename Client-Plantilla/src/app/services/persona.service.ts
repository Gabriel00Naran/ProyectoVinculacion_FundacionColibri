import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Persona } from '../models/persona';
import { Guid } from 'guid-typescript';
import { environment } from 'src/environments/environment';
import { map } from 'rxjs/operators';
import { Canton } from '../models/canton';
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


  // private Server = 'https://localhost:44351/';

  ///////////// API-REST/////////////////////////
  private GET = 'api/Persona/GetPersona';
  private GETbyID = 'api/Persona/GetPersonaById?idPersona=';
  private POST = 'api/Persona/AddPersona/';
  private PUT = 'api/Persona/EditPersona';
  private DELETE = 'api/Persona/DeletePersona?idPersona=';
  private GETbyIDCronologico = 'api​/HistorialCronologico​/GetHistorialCronologicoByIdPersona?idPersona=';
  private GETbyIDCanton = '/api/Canton/GetCantonById?idCanton=';
  /////////////////////////////////////////////

  constructor(private http: HttpClient) { }

  getPersona(): Observable<any> {
    return this.http.get(environment.SERVER + this.GET);
  }

  getCronologico(idPersona): Observable<any> {
    return this.http.get(environment.SERVER + this.GETbyIDCronologico + idPersona);
  }

  deletePersona(url): Observable<any> {
    return this.http.delete(environment.SERVER + url);
  }

  addPersona(persona: Persona): Observable<any> {
    return this.http.post(environment.SERVER + this.POST, persona);
  }

  //// volvi a dejar el tipo de dato en number ya que antes estana en Guid
  getPersonaById(url): Observable<any> {
    return this.http.get(environment.SERVER + url);
  }

  getPersonaByCantonId(idCanton): Observable<Canton[]> {
    return this.http.get<Canton[]>(environment.SERVER + this.GETbyIDCanton + idCanton);
  }
  //// lo mismo en el update.
  updatePersona(persona: Persona): Observable<any> {
    return this.http.put((environment.SERVER + this.PUT), persona);
  }

  get(url: string) {
    return this.http.get(environment.SERVER + url).pipe(
      map(data => {
        return data;
      })
    );
  }


  post(url, data: any) {
    return this.http.post(environment.SERVER + url, data).subscribe(
      response => {

      },
      error => {
      }

    );
  }

  put(url, data: any) {
    return this.http.put(environment.SERVER + url, data).subscribe(
      response => {

      },
      error => {
      }

    );
  }
}
