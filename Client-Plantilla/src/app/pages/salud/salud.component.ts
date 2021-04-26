import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Persona } from 'src/app/models/persona';
import { Salud } from 'src/app/models/salud';
import { PersonaService } from 'src/app/services/persona.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-salud',
  templateUrl: './salud.component.html',
  styleUrls: ['./salud.component.scss']
})
export class SaludComponent implements OnInit {
  persona: Persona[] = [];
  formData: Persona;
  salud: any;
  cols: any[];
  show: boolean;
  productDialog: boolean;
  showbutton: boolean;

  constructor(private personaService: PersonaService,
              private router: Router,
              private toastr: ToastrService,
              private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
    this.show = false;
    this.showbutton = true;
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
    this.personaService.getPersona().subscribe(data => {
      this.formData = data;
    }, error => {
      this.toastr.error('el servidor no funciona', 'Error');
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
    this.personaService.get('api/DatosSalud/GetDatosSaludByIdPersona?IdPersona=' + id).subscribe(data => {
      this.salud = data;
      if (this.salud.length === 0) {
        Swal.fire(
          'No tienes datos de salud',
          'Ingresa si es necesario',
          'question'
        );
      }
      else {
        this.productDialog = true;

      }
    }, error => {
      this.toastr.error('el servidor no funciona', 'Error');
      console.log(error);
    });

  }


  addnew(id) {
    console.log('ID' + id);
    this.router.navigate(['/add-salud', id], {

    });
  }

  eliminarSalud(id: any) {
    console.log(id);
    this.personaService.deletePersona('api/DatosSalud/DeleteDatosSalud?idDatosSalud=' + id).subscribe(data => {
      this.getPersonaList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');
      this.productDialog = false;
    }, error => {
      this.toastr.error('el servidor no responde', 'Error');
      console.log(error);
    });
  }

  editar(id) {
    console.log('ID' + id);
    this.router.navigate(['/edit-salud', id], {
      skipLocationChange: true,
    });
  }

  ver(id) {
    console.log('ID' + id);
    this.router.navigate(['/ver-salud', id], {
      skipLocationChange: true,
    });
  }


}
