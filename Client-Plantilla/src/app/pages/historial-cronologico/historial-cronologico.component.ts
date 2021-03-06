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
  historial: any;
  historial2: any;
  cols: any[];
  show: boolean;
  productDialog: boolean;
  add: boolean;
  organizaciones: any = [];
  respuesta: any;
  showbutton: boolean;
  userauth;
  
  constructor(private personaService: PersonaService,
              private router: Router,
              private toastr: ToastrService,
              private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
    this.userauth = atob(localStorage.getItem('currentUser'));
    this.add = false;
    this.showbutton = true;
    this.show = false;
    this.productDialog = false;
    this.spinner.show();
    setTimeout(() => {
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
    this.personaService.getPersona(this.userauth).subscribe(data => {
      this.formData = data;
    }, error => {
  this.router.navigate(['/error']);                    
this.toastr.error('El servidor no funciona', 'Error');
      console.log(error);
    });
  }

  mostrarpersonas() {
    this.getPersonaList();
    this.showbutton = false;
    this.show = true;
  }

  abrir_modalBuscar(id) {
    this.getHistorial(id);

    console.log('modal id :', id);
  }

  getHistorial(id) {
    this.historial = [];
    this.personaService.get('api/HistorialCronologico/GetHistorialCronologicoByIdPersona?IdPersona=' + id, this.userauth).subscribe(data => {
      this.historial = data;
      console.log(this.historial);
      if (this.historial.length === 0) {
        Swal.fire(
          'No tienes historial',
          'Ingresa si es necesario',
          'question'
        );
      }
      else {
        this.productDialog = true;

      }
    }, error => {
  this.router.navigate(['/error']);                    
this.toastr.error('El servidor no funciona', 'Error');
      console.log(error);
    });

  }

  eliminarHistorial(id: any) {
    console.log(id);
    this.personaService.deletePersona('api/HistorialCronologico/DeleteHistorialCronologico?idHistorial=' + id, this.userauth).subscribe(data => {
      this.getPersonaList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');
      this.productDialog = false;
    }, error => {
      this.toastr.error('El servidor no responde', 'Error');
      console.log(error);
    });
  }

  editar(id) {
    console.log('ID' + id);
    this.router.navigate(['/Editar-Historial', id], {
      skipLocationChange: true,
    });
  }

  ver(id) {
    console.log('ID' + id);
    this.router.navigate(['/ver-historial', id], {
      skipLocationChange: true,
    });
  }



  getOrganizaciones() {
    this.organizaciones = [];
    this.personaService.get('api/Organizacion/GetOrganizacion', this.userauth).subscribe((data: {}) => {
      this.organizaciones = data;
      console.log('ORGANIZACIONES', this.organizaciones);

    });
  }


  addnew(id) {
    console.log('ID' + id);
    this.router.navigate(['/add-historial', id], {

    });
  }

}

