import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Persona } from 'src/app/models/persona';
import { Pgf } from 'src/app/models/pgf';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-pgf',
  templateUrl: './pgf.component.html',
  styleUrls: ['./pgf.component.scss']
})
export class PgfComponent implements OnInit {
  persona: Persona[] = [];
  formData: Persona;
  pgf: Pgf;
  cols: any[];
  show: boolean;
  productDialog: boolean;
  constructor(private personaService: PersonaService,
    private router: Router,
       private toastr: ToastrService,
       private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
    this.show= false;
    this.productDialog= false;
    this.spinner.show();

    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.cols = [
      { field: 'nombreCompleto', header: 'Nombre Completo' },
      { field: 'documentoIdentidad', header: 'Documento de Identidad' },
      { field: 'edad', header: 'Edad' },

    ];
    
  }

  getPersonaList() {
    this.personaService.getPersona().subscribe(data => {
      this.formData = data;
    }, error => {
      this.toastr.error('el servidor no funciona','Error');
      console.log(error);
    })
  }

  mostrarpersonas(){
    this.getPersonaList();
    this.show= true;
  }

  abrir_modalBuscar(id) {
    this.getPGF(id);
    this.productDialog = true;
  
    console.log('modal id :', id);
  }

  getPGF(id){
    this.personaService.get('api/Pgf/GetPgfByIdPersona?IdPersona=' + id).subscribe(data => {
        this.pgf = data;
      }, error => {
        this.toastr.error('el servidor no funciona','Error');
        console.log(error);
      })

  }

  agregar(){

  }

  cancelaragregar(){

  }

}
