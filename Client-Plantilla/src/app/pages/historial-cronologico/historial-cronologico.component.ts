import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Historial } from 'src/app/models/historial';
import { Persona } from 'src/app/models/persona';
import { PersonaService } from 'src/app/services/persona.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-historial-cronologico',
  templateUrl: './historial-cronologico.component.html',
  styleUrls: ['./historial-cronologico.component.scss']
})
export class HistorialCronologicoComponent implements OnInit {
  persona: Persona[] = [];
  formData: Persona;
  historial: Historial;
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
    this.personaService.get('api/HistorialCronologico/GetHistorialCronologicoByIdPersona?IdPersona=' + id).subscribe(data => {
        this.historial = data;
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
