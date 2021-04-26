import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Persona } from 'src/app/models/persona';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-persona',
  templateUrl: './persona.component.html',
  styleUrls: ['./persona.component.scss']
})
export class PersonaComponent implements OnInit {
  persona: Persona[] = [];
  formData: Persona;
  cols: any[];
  constructor(private personaService: PersonaService,
              private router: Router,
              private toastr: ToastrService,
              private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
    this.spinner.show();
    setTimeout(() => {
      this.getPersonaList();
      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.cols = [
      { field: 'nombrecompleto', header: 'Nombre Completo' },
      { field: 'documentoidentidad', header: 'Documento de Identidad' },
      { field: 'edad', header: 'Edad' },

    ];

  }


  getPersonaList() {
    this.personaService.getPersona().subscribe(data => {
      this.formData = data;
    }, error => {
      this.toastr.error('El servidor no funciona', 'Error');
      console.log(error);
    });
  }

  eliminarPersona(idPersona: any) {
    console.log(idPersona);
    this.personaService.deletePersona('api/Persona/DeletePersona?idPersona=' + idPersona).subscribe(data => {
      this.getPersonaList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');
    }, error => {
      this.toastr.error('El servidor no responde', 'Error');
      console.log(error);
    });
  }

  edit(id) {
    console.log('ID' + id);
    this.router.navigate(['/Editar-Persona', id], {
      skipLocationChange: true,
    });
  }

  ver(id) {
    console.log('ID' + id);
    this.router.navigate(['/Ver-Persona', id], {
      skipLocationChange: true,
    });
  }



}
