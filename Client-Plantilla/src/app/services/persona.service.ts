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
  private PUT = 'api/Persona/EditPersona';

  /////////////////////////////////////////////

  constructor(private http: HttpClient) { }

  getPersona(auth_token): Observable<any> {
    const httpOptions  = {
      headers: new HttpHeaders({  
      Authorization: `Bearer ${auth_token}`
    })
    };
    return this.http.get(environment.SERVER + this.GET, httpOptions);
  }

  deletePersona(url, auth_token): Observable<any> {
    const httpOptions  = {
      headers: new HttpHeaders({  
      Authorization: `Bearer ${auth_token}`
    })
    };
    return this.http.delete(environment.SERVER + url, httpOptions);
  }
  //// volvi a dejar el tipo de dato en number ya que antes estana en Guid
  getPersonaById(url, auth_token): Observable<any> {
    const httpOptions  = {
      headers: new HttpHeaders({  
      Authorization: `Bearer ${auth_token}`
    })
    };
    return this.http.get(environment.SERVER + url, httpOptions);
  }

  //// lo mismo en el update.
  updatePersona(persona: Persona , auth_token): Observable<any> {
    const httpOptions  = {
      headers: new HttpHeaders({  
      Authorization: `Bearer ${auth_token}`
    })
    };
    return this.http.put((environment.SERVER + this.PUT), persona, httpOptions);
  }

  get(url: string, auth_token) {
    const httpOptions  = {
      headers: new HttpHeaders({  
      Authorization: `Bearer ${auth_token}`
    })
    };
    return this.http.get(environment.SERVER + url, httpOptions).pipe(
      map(data => {
        return data;
      })
    );
  }


  post(url, data: any , auth_token) {
    const httpOptions  = {
      headers: new HttpHeaders({  
      Authorization: `Bearer ${auth_token}`
    })
    };
    return this.http.post(environment.SERVER + url , data, httpOptions).subscribe(
      response => {

      },
      error => {
      }

    );
  }

  put(url, data: any, auth_token) {
    const httpOptions  = {
      headers: new HttpHeaders({  
      Authorization: `Bearer ${auth_token}`
    })
    };
    return this.http.put(environment.SERVER + url, data, httpOptions ).subscribe(
      response => {

      },
      error => {
      }

    );
  }



}
