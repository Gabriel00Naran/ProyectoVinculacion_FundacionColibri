import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Persona } from 'src/app/models/persona';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-ver-persona',
  templateUrl: './ver-persona.component.html',
  styleUrls: ['./ver-persona.component.css']
})
export class VerPersonaComponent implements OnInit {

  idPersona: number;
  persona: Persona | undefined;

  constructor(private aRoute: ActivatedRoute,
              private _personaService: PersonaService) {
    this.idPersona =+ this.aRoute.snapshot.paramMap.get('idPersona')!;
   }

  ngOnInit(): void {
    this.getPersonaId();
  }
  

  getPersonaId() {
    this._personaService.getPersonaById(this.idPersona).subscribe(data => {
      this.persona = data;
    }, error => {
      console.log(error);
    })
  }

}
