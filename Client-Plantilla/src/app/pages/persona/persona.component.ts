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
  persona: Persona[] = [];;
  cols: any[];
  pregunta: any;
  constructor(private personaService: PersonaService,
    private router: Router,
       private toastr: ToastrService,
       private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
    this.spinner.show();

    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.getPersonaList();
  }


  getPersonaList() {
    this.personaService.getPersona().subscribe(data => {
      this.persona = data;
    }, error => {
      this.toastr.error('el servidor no funciona','Error');
      console.log(error);
    })
  }

  eliminarPersona(idPersona: any) {
    console.log(idPersona);
    this.personaService.deletePersona(idPersona).subscribe(data => {
      this.getPersonaList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!','Registro eliminado');
    }, error => {
      this.toastr.error('el servidor no responde','Error');
      console.log(error);
    })
  }

  edit(id){
    console.log('ID'+ id)
    this.router.navigate(['/Editar-Persona', id], {
      skipLocationChange: true,
    });
  }

 

}
