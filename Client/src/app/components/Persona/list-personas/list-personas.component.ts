import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Persona } from 'src/app/models/persona';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-list-personas',
  templateUrl: './list-personas.component.html',
  styleUrls: ['./list-personas.component.css']
})
export class ListPersonasComponent implements OnInit {

  listPersonas: Persona[] = [];

  constructor(private _personaService: PersonaService,
       private toastr: ToastrService) { }

  ngOnInit(): void {
    this.getPersonaList();
  }

  getPersonaList() {
    this._personaService.getPersona().subscribe(data => {
      this.listPersonas = data;
    }, error => {
      this.toastr.error('el servidor no funciona','Error');
      console.log(error);
    })
  }

  eliminarPersona(idPersona: any) {
    console.log(idPersona);
    this._personaService.deletePersona(idPersona).subscribe(data => {
      this.getPersonaList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!','Registro eliminado');
    }, error => {
      this.toastr.error('el servidor no responde','Error');
      console.log(error);
    })
  }
}
