import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Persona } from 'src/app/models/persona';
import { Pgf } from 'src/app/models/pgf';
import { PersonaService } from 'src/app/services/persona.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-pgf',
  templateUrl: './pgf.component.html',
  styleUrls: ['./pgf.component.scss']
})
export class PgfComponent implements OnInit {
  persona: Persona[] = [];
  formData: Persona;
  pgf: any;
  cols: any[];
  show: boolean;
  productDialog: boolean;
  showbutton: boolean;
  userauth;

  constructor(private personaService: PersonaService,
              private router: Router,
              private toastr: ToastrService,
              private spinner: NgxSpinnerService) { }

  ngOnInit(): void {
    this.userauth = atob(localStorage.getItem('currentUser'));
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
    this.getPGF(id);
    console.log('modal id :', id);
  }

  getPGF(id) {
    this.personaService.get('api/Pgf/GetPgfByIdPersona?idpersona=' + id, this.userauth).subscribe(data => {
      this.pgf = data;
      if (this.pgf.length === 0) {
        Swal.fire(
          'No tienes ningun registro',
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
  addnew(id) {
    console.log('ID' + id);
    this.router.navigate(['/add-pgf', id], {

    });
  }

  eliminarPgf(id: any) {
    console.log(id);
    this.personaService.deletePersona('api/Pgf/DeletePgf?idPgf=' + id, this.userauth).subscribe(data => {
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
    this.router.navigate(['/edit-pgf', id], {
      skipLocationChange: true,
    });
  }

  ver(id) {
    console.log('ID' + id);
    this.router.navigate(['/view-pgf', id], {
      skipLocationChange: true,
    });
  }
}
