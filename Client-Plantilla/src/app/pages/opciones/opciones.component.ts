import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Genero } from 'src/app/models/genero';
import { Persona } from 'src/app/models/persona';
import { PersonaService } from 'src/app/services/persona.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-opciones',
  templateUrl: './opciones.component.html',
  styleUrls: ['./opciones.component.scss']
})
export class OpcionesComponent implements OnInit {
  formData;
  formData2;
  formData3;
  formData4;
  submitted = false;
  cols: any[];
  cols2: any[];
  cols3: any[];
  cols4: any[];
  show: boolean;
  add: boolean;
  respuesta: any;
  showbutton: boolean;
  showbuttongeneros: boolean;
  showgeneros: boolean;
  showbuttonnacionalidades: boolean;
  showbuttonmodalidades: boolean;
  shownacionalidades: boolean;
  showmodalidades: boolean;
  userauth;
  edit: boolean;
  editgenero: boolean;
  editnacionaliad: boolean;
  editna: boolean;
  editmodalidad: boolean;
  etnia: any;
  etnian: any;
  genero: any;
  generon: any;
  nacionalidad: any;
  nacionalidadn: any;
  modalidad: any;
  modalidadn: any;
  modalForm: FormGroup;
  addEtnia: boolean;
  addGenero: boolean;
  addNacionalidad: boolean;
  addModalidad: boolean;
  addnewnacionalidad: boolean;
  addnewmodalidad: boolean;
  addnewetnia: boolean;
  addnewgenero: boolean;

  constructor(private personaService: PersonaService,
    private router: Router,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService,
    private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.userauth = atob(localStorage.getItem('currentUser'));
    this.add = false;
    this.showbuttonnacionalidades = true;
    this.showbutton = true;
    this.showbuttongeneros = true;
    this.showbuttonmodalidades = true;
    this.addnewnacionalidad = false;
    this.addnewetnia = false;
    this.addnewmodalidad = false;
    this.shownacionalidades = false;
    this.show = false;
    this.showgeneros = false;
    this.showmodalidades = false;
    this.addnewgenero = false;
    this.addEtnia = false;
    this.addNacionalidad = false;
    this.addGenero = false;
    this.addModalidad = false;
    this.edit = false;
    this.editgenero = false;
    this.editnacionaliad = false;
    this.editmodalidad = false;
    this.modalForm = this.formBuilder.group({
      respuesta: ['', Validators.required],
    });
    this.spinner.show();
    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.cols = [
      { field: 'descripcionetnia', header: 'Descripción' }

    ];

    this.cols2 = [
      { field: 'descripciongenero', header: 'Descripción' }

    ];

    this.cols3 = [
      { field: 'descripcionnacionalidad', header: 'Descripción' }
    ];

    this.cols4 = [
      { field: 'descripcionmodalidad', header: 'Descripción' }
    ];

    this.etnian = {
      descripcionetnia: ''
    },

      this.generon = {
        descripciongenero: ''
      },

      this.nacionalidadn = {
        descripcionnacionalidad: ''
      },

      this.modalidad = {
        descripcionmodalidad : ''
      },

      this.modalidadn = {
        descripcionmodalidad : ''
      }


  }
  get m() { return this.modalForm.controls; }

  getGenerosList() {
    this.personaService.getObservable('api/Genero/GetGenero', this.userauth).subscribe(data => {
      this.formData2 = data;
    }, error => {
      this.router.navigate(['/error']);
      this.toastr.error('El servidor no funciona', 'Error');
      console.log(error);
    });
  }

  getEtniasList() {
    this.personaService.getObservable('api/Etnia/GetEtnia', this.userauth).subscribe(data => {
      this.formData = data;
    }, error => {
      this.router.navigate(['/error']);
      this.toastr.error('El servidor no funciona', 'Error');
      console.log(error);
    });
  }

  getNacionalidadesList() {
    this.personaService.getObservable('api/Nacionalidad/GetNacionalidad', this.userauth).subscribe(data => {
      this.formData3 = data;
    }, error => {
      this.router.navigate(['/error']);
      this.toastr.error('El servidor no funciona', 'Error');
      console.log(error);
    });
  }

  getModalidadesList() {
    this.personaService.getObservable('api/Modalidad/GetModalidad', this.userauth).subscribe(data => {
      this.formData4 = data;
    }, error => {
      this.router.navigate(['/error']);
      this.toastr.error('El servidor no funciona', 'Error');
      console.log(error);
    });
  }

  mostrarEtnias() {
    this.getEtniasList();
    this.showbutton = false;
    this.addnewetnia = true;
    this.show = true;
  }

  mostrarGeneros() {
    this.getGenerosList();
    this.addnewgenero = true;
    this.showbuttongeneros = false;
    this.showgeneros = true;
  }

  mostrarNacionalidades() {
    this.getNacionalidadesList();
    this.showbuttonnacionalidades = false;
    this.addnewnacionalidad = true;
    this.shownacionalidades = true;
  }

  mostrarModalidades() {
    this.getModalidadesList();
    this.showbuttonmodalidades = false;
    this.addnewmodalidad = true;
    this.showmodalidades = true;
  }

  addE() {
    this.addEtnia = true;
  }

  addG() {
    this.addGenero = true;
  }

  addN() {
    this.addNacionalidad = true;
  }

  addM() {
    this.addModalidad = true;
  }


  eliminarEtnia(id: any) {
    console.log(id);
    this.personaService.deletePersona('api/Etnia/DeleteEtnia?idEtnia=' + id, this.userauth).subscribe(data => {
      this.getEtniasList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');

    }, error => {
      this.toastr.error('El servidor no responde', 'Error');
      console.log(error);
    });
  }

  eliminarGenero(id: any) {
    console.log(id);
    this.personaService.deletePersona('api/Genero/DeleteGenero?idGenero=' + id, this.userauth).subscribe(data => {
      this.getGenerosList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');

    }, error => {
      this.toastr.error('El servidor no responde', 'Error');
      console.log(error);
    });
  }

  eliminarNacionalidad(id: any) {
    console.log(id);
    this.personaService.deletePersona('api/Nacionalidad/DeleteNacionalidad?idNacionalidad=' + id, this.userauth).subscribe(data => {
      this.getNacionalidadesList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');

    }, error => {
      this.toastr.error('El servidor no responde', 'Error');
      console.log(error);
    });
  }

  eliminarModalidad(id: any) {
    console.log(id);
    this.personaService.deletePersona('api/Modalidad/DeleteModalidad?idModalidad=' + id, this.userauth).subscribe(data => {
      this.getModalidadesList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');

    }, error => {
      this.toastr.error('El servidor no responde', 'Error');
      console.log(error);
    });
  }

  editar(id) {
    console.log(id);
    this.getEtniaId(id);
    this.edit = true;
  }

  editarGenero(id) {
    console.log(id);
    this.getGeneroId(id);
    this.editgenero = true;
  }

  editarNacionalidad(id) {
    console.log(id);
    this.getNacionalidadId(id);
    this.editnacionaliad = true;
  }

  editarModalidad(id) {
    console.log(id);
    this.getModalidadId(id);
    this.editmodalidad = true;
  }

  getEtniaId(id) {
    this.etnia = [];
    this.personaService.getPersonaById('api/Etnia/GetEtniumById?idEtnia=' + id, this.userauth).subscribe((data: {}) => {
      this.etnia = data;
      console.log('ETNIAS', this.etnia);

    });
  }

  getGeneroId(id) {
    this.genero = [];
    this.personaService.getPersonaById('api/Genero/GetGeneroById?idGenero=' + id, this.userauth).subscribe((data: {}) => {
      this.genero = data;
      console.log('GENERO', this.genero);

    });
  }

  getNacionalidadId(id) {
    this.nacionalidad = [];
    this.personaService.getPersonaById('api/Nacionalidad/GetNacionalidadById?idNacionalidad=' + id, this.userauth).subscribe((data: {}) => {
      this.nacionalidad = data;
      console.log('NACIONALIDADES', this.nacionalidad);

    });
  }


  getModalidadId(id) {
    this.modalidad = [];
    this.personaService.getPersonaById('api/Modalidad/GetModalidadById?idModalidad=' + id, this.userauth).subscribe((data: {}) => {
      this.modalidad = data;
      console.log('MODALIDADES', this.modalidad);

    });
  }

  editarEtnia(id) {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    console.log('ID' + id);
    this.personaService.put('api/Etnia/EditEtnia', this.etnia, this.userauth);
    console.log('EDITADO', this.etnia);
    this.spinner.show();
    this.edit = false;
    this.show = true;
    setTimeout(() => {
      this.getEtniasList();
      this.spinner.hide();
      //this..controls['respuesta'].reset()
      /** spinner ends after 5 seconds */

    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  editarGen(id) {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    console.log('ID' + id);
    this.personaService.put('api/Genero/EditGenero', this.genero, this.userauth);
    console.log('EDITADO', this.genero);
    this.spinner.show();
    this.editgenero = false;
    this.showgeneros = true;
    setTimeout(() => {
      this.getGenerosList();
      this.spinner.hide();
      //this..controls['respuesta'].reset()
      /** spinner ends after 5 seconds */

    }, 3000);
    this.modalForm.controls['respuesta2'].reset()
  }

  editarNaci(id) {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    console.log('ID' + id);
    this.personaService.put('api/Nacionalidad/EditNacionalidad', this.nacionalidad, this.userauth);
    console.log('EDITADO', this.nacionalidad);
    this.spinner.show();
    this.editnacionaliad = false;
    this.shownacionalidades = true;
    setTimeout(() => {
      this.getNacionalidadesList();
      this.spinner.hide();
      //this..controls['respuesta'].reset()
      /** spinner ends after 5 seconds */

    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  editarModal(id) {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    console.log('ID' + id);
    this.personaService.put('api/Modalidad/EditModalidad', this.modalidad, this.userauth);
    console.log('EDITADO', this.modalidad);
    this.spinner.show();
    this.editmodalidad = false;
    this.showmodalidades = true;
    setTimeout(() => {
      this.getModalidadesList();
      this.spinner.hide();
      //this..controls['respuesta'].reset()
      /** spinner ends after 5 seconds */

    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  cancelareditar() {
    this.edit = false;
  }

  cancelareditarNacionalidad() {
    this.editnacionaliad = false;
  }

  cancelareditarGenero() {
    this.editgenero = false;
  }

  cancelareditarModalidad() {
    this.editmodalidad = false;
  }

  guardarEtnia() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    this.personaService.post('api/Etnia/AddEtnia', this.etnian, this.userauth);
    console.log('GUARDADO', this.etnian);
    this.addEtnia = false;
    this.spinner.show();

    setTimeout(() => {
      this.getEtniasList();
      //this.getTiposRespuestas(this.pidm,this.encuesta);

      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.modalForm.controls['respuesta'].reset()

  }

  guardarGenero() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    this.personaService.post('api/Genero/AddGenero', this.generon, this.userauth);
    console.log('GUARDADO', this.generon);
    this.addGenero = false;
    this.spinner.show();

    setTimeout(() => {
      this.getGenerosList();
      //this.getTiposRespuestas(this.pidm,this.encuesta);

      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.modalForm.controls['respuesta'].reset()

  }

  guardarNacionalidad() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    this.personaService.post('api/Nacionalidad/AddNacionalidad', this.nacionalidadn, this.userauth);
    console.log('GUARDADO', this.nacionalidadn);
    this.addNacionalidad = false;
    this.spinner.show();

    setTimeout(() => {
      this.getNacionalidadesList();
      //this.getTiposRespuestas(this.pidm,this.encuesta);

      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.modalForm.controls['respuesta'].reset()

  }

  guardarModalidad() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    this.personaService.post('api/Modalidad/AddModalidad', this.modalidadn, this.userauth);
    console.log('GUARDADO', this.modalidadn);
    this.addModalidad = false;
    this.spinner.show();

    setTimeout(() => {
      this.getModalidadesList();
      //this.getTiposRespuestas(this.pidm,this.encuesta);

      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.modalForm.controls['respuesta'].reset()

  }

  cancelar() {
    this.addEtnia = false;
    this.modalForm.controls['respuesta'].reset()
  }

  cancelarGenero() {
    this.addGenero = false;
    this.modalForm.controls['respuesta'].reset()
  }

  cancelarNacionalidad() {
    this.addNacionalidad = false;
    this.modalForm.controls['respuesta'].reset()
  }

  cancelarModalidad() {
    this.addModalidad = false;
    this.modalForm.controls['respuesta'].reset()
  }



}
