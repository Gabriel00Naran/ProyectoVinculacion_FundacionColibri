import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Persona } from 'src/app/models/persona';
import { Salud } from 'src/app/models/salud';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-salud',
  templateUrl: './salud.component.html',
  styleUrls: ['./salud.component.scss']
})
export class SaludComponent implements OnInit {
  persona: Persona[] = [];
  formData: Persona;
  salud: Salud;
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
    this.getHistorial(id);
    this.productDialog = true;
  
    console.log('modal id :', id);
  }

  getHistorial(id){
    this.personaService.get('api/DatosSalud/GetDatosSaludByIdPersona?IdPersona=' + id).subscribe(data => {
        this.salud = data;
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
