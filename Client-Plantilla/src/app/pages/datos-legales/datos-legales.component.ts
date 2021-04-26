import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Persona } from 'src/app/models/persona';
import { PersonaService } from 'src/app/services/persona.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-datos-legales',
  templateUrl: './datos-legales.component.html',
  styleUrls: ['./datos-legales.component.scss']
})
export class DatosLegalesComponent implements OnInit {
  persona: Persona[] = [];
  formData: Persona;
  dlegales: any;
  cols: any[];
  show: boolean;
  productDialog: boolean;
  add: boolean;
  organizaciones: any = [];
  respuesta: any;

  constructor(private personaService: PersonaService,
              private router: Router,
              private toastr: ToastrService,
              private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
    this.add = false;
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
    this.personaService.getPersona().subscribe(data => {
      this.formData = data;
    }, error => {
      this.toastr.error('el servidor no funciona', 'Error');
      console.log(error);
    });
  }

  mostrarpersonas() {
    this.getPersonaList();
    this.show = true;
  }

  abrir_modalBuscar(id) {
    this.getDatosJudiciales(id);

    console.log('modal id :', id);
  }

  getDatosJudiciales(id) {
    this.dlegales = [];
    this.personaService.get('api/DatosJudicialPenal/GetDatosJudicialPenalByIdPersona?IdPersona=' + id).subscribe(data => {
      this.dlegales = data;
      console.log(this.dlegales);
      if (this.dlegales.length === 0) {
        Swal.fire(
          'No tienes datos legales',
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

  eliminarDatoJudicial(id: any) {
    console.log(id);
    this.personaService.deletePersona('/api/DatosJudicialPenal/DeleteDatosJudicialPenal?idJudicialPenal=' + id).subscribe(data => {
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
    this.router.navigate(['/edit-legal', id], {
      skipLocationChange: true,
    });
  }


  getOrganizaciones() {
    this.organizaciones = [];
    this.personaService.get('api/Organizacion/GetOrganizacion').subscribe((data: {}) => {
      this.organizaciones = data;
      console.log('ORGANIZACIONES', this.organizaciones);

    });
  }


  addnew(id) {
    console.log('ID' + id);
    this.router.navigate(['/add-legal', id], {

    });
  }

}
