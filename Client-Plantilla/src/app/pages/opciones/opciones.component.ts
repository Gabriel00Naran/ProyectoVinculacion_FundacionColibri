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
  formData5;
  formData6;
  formData7;
  formData8;
  formData9;
  submitted = false;
  cols: any[];
  cols2: any[];
  cols3: any[];
  cols4: any[];
  cols5: any[];
  cols6: any[];
  cols7: any[];
  cols8: any[];
  cols9: any[];
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
  showbuttonmotivos: boolean;
  showmotivos: boolean;
  userauth;
  edit: boolean;
  editgenero: boolean;
  editnacionaliad: boolean;
  editna: boolean;
  editmotivo: boolean;
  editmodalidad: boolean;
  etnia: any;
  motivo: any;
  motivon: any;
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
  addMotivo: boolean;
  addnewnacionalidad: boolean;
  addnewmotivo: boolean;
  addnewmodalidad: boolean;
  addnewetnia: boolean;
  addnewgenero: boolean;
  showbuttonorganizaciones: boolean;
  showorganizaciones: boolean;
  editorganizacion: boolean;
  organizacion: any;
  organizacionn: any;
  addOrganizacion: boolean;
  addneworganizacion: boolean;
  showbuttonfamiliares: boolean;
  showfamiliares: boolean;
  editfamiliar: boolean;
  familiar: any;
  familiarn: any;
  addFamiliar: boolean;
  addnewfamiliar: boolean;
  showbuttonmedidas: boolean;
  showmedidas: boolean;
  editmedida: boolean;
  medida: any;
  medidan: any;
  addMedida: boolean;
  addnewmedida: boolean;
  //
  showbuttonnudos: boolean;
  shownudos: boolean;
  editnudo: boolean;
  nudo: any;
  nudon: any;
  addNudo: boolean;
  addnewnudo: boolean;
  //
  constructor(private personaService: PersonaService,
    private router: Router,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService,
    private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.userauth = atob(localStorage.getItem('currentUser'));
    this.add = false;
    this.showbuttonorganizaciones = true;
    this.showorganizaciones = false;
    this.editorganizacion = false;
    this.addOrganizacion = false;
    this.addneworganizacion = false;
    this.showbuttonnudos = true;
    this.shownudos = false;
    this.editnudo = false;
    this.addNudo = false;
    this.addnewnudo = false;
    this.showbuttonmedidas = true;
    this.showmedidas = false;
    this.editmedida = false;
    this.addMedida = false;
    this.addnewmedida = false;
    this.showbuttonfamiliares = true;
    this.showfamiliares = false;
    this.editfamiliar = false;
    this.addFamiliar = false;
    this.addnewfamiliar = false;
    this.showbuttonnacionalidades = true;
    this.showbuttonmotivos = true;
    this.showbutton = true;
    this.showbuttongeneros = true;
    this.showbuttonmodalidades = true;
    this.addnewnacionalidad = false;
    this.addnewetnia = false;
    this.addnewmodalidad = false;
    this.shownacionalidades = false;
    this.showmotivos = false;
    this.show = false;
    this.showgeneros = false;
    this.showmodalidades = false;
    this.addnewgenero = false;
    this.addEtnia = false;
    this.addMotivo = false;
    this.addNacionalidad = false;
    this.addGenero = false;
    this.addModalidad = false;
    this.addnewmotivo = false;
    this.edit = false;
    this.editgenero = false;
    this.editnacionaliad = false;
    this.editmodalidad = false;
    this.editmotivo = false;
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

    this.cols5 = [
      { field: 'descripcionmotivoingreso', header: 'Descripción' }
    ];


    this.cols6 = [
      { field: 'descripcionorganizacion', header: 'Descripción' }
    ];

    this.cols7 = [
      { field: 'descripcionfamiliarreferente', header: 'Descripción' }
    ];

    this.cols8 = [
      { field: 'descripcionmedida', header: 'Descripción' }
    ];

    this.cols9 = [
      { field: 'descripcionorganizacion', header: 'Descripción' }
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
        descripcionmodalidad: ''
      },

      this.modalidadn = {
        descripcionmodalidad: ''
      },

      this.motivo = {
        descripcionmotivoingreso: ''
      },

      this.motivon = {
        descripcionmotivoingreso: ''
      },

      this.organizacion = {
        descripcionorganizacion: ''
      },

      this.organizacionn = {
        descripcionorganizacion: ''
      },

      this.familiar = {
        descripcionfamiliarreferente: ''
      },

      this.familiarn = {
        descripcionfamiliarreferente: ''
      },
      this.medida = {
        descripcionmedida: ''
      },

      this.medidan = {
        descripcionmedida: ''
      },
      this.nudo = {
        descripcionorganizacion: ''
      },

      this.nudon = {
        descripcionorganizacion: ''
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

  getNudosList() {
    this.personaService.getObservable('api/NudosCritico/GetNudosCritico', this.userauth).subscribe(data => {
      this.formData9 = data;
    }, error => {
      this.router.navigate(['/error']);
      this.toastr.error('El servidor no funciona', 'Error');
      console.log(error);
    });
  }


  getMedidasList() {
    this.personaService.getObservable('api/Medida/GetMedida', this.userauth).subscribe(data => {
      this.formData8 = data;
    }, error => {
      this.router.navigate(['/error']);
      this.toastr.error('El servidor no funciona', 'Error');
      console.log(error);
    });
  }

  getOrganizacionesList() {
    this.personaService.getObservable('api/Organizacion/GetOrganizacion', this.userauth).subscribe(data => {
      this.formData6 = data;
    }, error => {
      this.router.navigate(['/error']);
      this.toastr.error('El servidor no funciona', 'Error');
      console.log(error);
    });
  }

  getFamiliaresList() {
    this.personaService.getObservable('api/FamiliarReferente/GetFamiliarReferente', this.userauth).subscribe(data => {
      this.formData7 = data;
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


  getMotivosList() {
    this.personaService.getObservable('api/MotivoIngreso/GetMotivoIngreso', this.userauth).subscribe(data => {
      this.formData5 = data;
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

  mostrarMotivos() {
    this.getMotivosList();
    this.showbuttonmotivos = false;
    this.addnewmotivo = true;
    this.showmotivos = true;
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

  addMo() {
    this.addMotivo = true;
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

  eliminarMotivo(id: any) {
    console.log(id);
    this.personaService.deletePersona('api/MotivoIngreso/DeleteMotivoIngreso?idMotivoIngreso=' + id, this.userauth).subscribe(data => {
      this.getMotivosList();
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

  editarMotivo(id) {
    console.log(id);
    this.getMotivoId(id);
    this.editmotivo = true;
  }

  getEtniaId(id) {
    this.etnia = [];
    this.personaService.getPersonaById('api/Etnia/GetEtniumById?idEtnia=' + id, this.userauth).subscribe((data: {}) => {
      this.etnia = data;
      console.log('ETNIAS', this.etnia);

    });
  }

  getMotivoId(id) {
    this.motivo = [];
    this.personaService.getPersonaById('api/MotivoIngreso/GetMotivoIngresoById?idMotivoIngreso=' + id, this.userauth).subscribe((data: {}) => {
      this.motivo = data;
      console.log('MOTIVOS', this.motivo);

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


  editarMoti(id) {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    console.log('ID' + id);
    this.personaService.put('api/MotivoIngreso/EditMotivoIngreso', this.motivo, this.userauth);
    console.log('EDITADO', this.motivo);
    this.spinner.show();
    this.editmotivo = false;
    this.showmotivos = true;
    setTimeout(() => {
      this.getMotivosList();
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

  cancelareditarMotivo() {
    this.editmotivo = false;
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

  guardarMotivo() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    this.personaService.post('api/MotivoIngreso/AddMotivoIngreso', this.motivon, this.userauth);
    console.log('GUARDADO', this.motivon);
    this.addMotivo = false;
    this.spinner.show();

    setTimeout(() => {
      this.getMotivosList();
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

  cancelarMotivo() {
    this.addMotivo = false;
    this.modalForm.controls['respuesta'].reset()
  }


  mostrarOrganizaciones() {
    this.getOrganizacionesList();
    this.showbuttonorganizaciones = false;
    this.addneworganizacion = true;
    this.showorganizaciones = true;
  }

  editarOrganizacion(id) {
    console.log(id);
    this.getOrganizacionId(id);
    this.editorganizacion = true;
  }


  getOrganizacionId(id) {
    this.organizacion = [];
    this.personaService.getPersonaById('api/Organizacion/GetOrganizacionById?idOrganizacion=' + id, this.userauth).subscribe((data: {}) => {
      this.organizacion = data;
      console.log('ORGANIZACIONES', this.organizacion);

    });
  }

  eliminarOrganizacion(id) {
    console.log(id);
    this.personaService.deletePersona('api/Organizacion/DeleteOrganizacion?idOrganizacion=' + id, this.userauth).subscribe(data => {
      this.getOrganizacionesList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');

    }, error => {
      this.toastr.error('El servidor no responde', 'Error');
      console.log(error);
    });
  }

  cancelareditarOrganizacion() {
    this.editorganizacion = false;
  }

  editarOrgan(id) {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    console.log('ID' + id);
    this.personaService.put('api/Organizacion/EditOrganizacion', this.organizacion, this.userauth);
    console.log('EDITADO', this.organizacion);
    this.spinner.show();
    this.editorganizacion = false;
    this.showorganizaciones = true;
    setTimeout(() => {
      this.getOrganizacionesList();
      this.spinner.hide();
      //this..controls['respuesta'].reset()
      /** spinner ends after 5 seconds */

    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  cancelarOrganizacion() {
    this.addOrganizacion = false;
    this.modalForm.controls['respuesta'].reset()
  }

  guardarOrganizacion() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    this.personaService.post('api/Organizacion/AddOrganizacion', this.organizacionn, this.userauth);
    console.log('GUARDADO', this.organizacionn);
    this.addOrganizacion = false;
    this.spinner.show();

    setTimeout(() => {
      this.getOrganizacionesList();
      //this.getTiposRespuestas(this.pidm,this.encuesta);

      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  addO() {
    this.addOrganizacion = true;
  }


  mostrarFamiliares() {
    this.getFamiliaresList();
    this.showbuttonfamiliares = false;
    this.addnewfamiliar = true;
    this.showfamiliares = true;
  }

  editarFamiliar(id) {
    console.log(id);
    this.getFamiliarId(id);
    this.editfamiliar = true;
  }


  getFamiliarId(id) {
    this.familiar = [];
    this.personaService.getPersonaById('api/FamiliarReferente/GetFamiliarReferenteById?idFamiliarReferente=' + id, this.userauth).subscribe((data: {}) => {
      this.familiar = data;
      console.log('FAMILIARES', this.familiar);

    });
  }

  eliminarFamiliar(id) {
    console.log(id);
    this.personaService.deletePersona('api/FamiliarReferente/DeleteFamiliarReferente?idFamiliarReferente=' + id, this.userauth).subscribe(data => {
      this.getFamiliaresList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');

    }, error => {
      this.toastr.error('El servidor no responde', 'Error');
      console.log(error);
    });
  }

  cancelareditarFamiliar() {
    this.editfamiliar = false;
  }

  editarFamil(id) {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    console.log('ID' + id);
    this.personaService.put('api/FamiliarReferente/AddFamiliarReferente', this.familiar, this.userauth);
    console.log('EDITADO', this.familiar);
    this.spinner.show();
    this.editfamiliar = false;
    this.showfamiliares = true;
    setTimeout(() => {
      this.getFamiliaresList();
      this.spinner.hide();
      //this..controls['respuesta'].reset()
      /** spinner ends after 5 seconds */

    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  cancelarFamiliar() {
    this.addFamiliar = false;
    this.modalForm.controls['respuesta'].reset()
  }

  guardarFamiliar() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    this.personaService.post('api/FamiliarReferente/AddFamiliarReferente', this.familiarn, this.userauth);
    console.log('GUARDADO', this.familiarn);
    this.addFamiliar = false;
    this.spinner.show();

    setTimeout(() => {
      this.getFamiliaresList();
      //this.getTiposRespuestas(this.pidm,this.encuesta);

      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  addF() {
    this.addFamiliar = true;
  }

  //


  mostrarMedidas() {
    this.getMedidasList();
    this.showbuttonmedidas = false;
    this.addnewmedida = true;
    this.showmedidas = true;
  }

  editarMedida(id) {
    console.log(id);
    this.getMedidaId(id);
    this.editmedida = true;
  }


  getMedidaId(id) {
    this.medida = [];
    this.personaService.getPersonaById('api/Medida/GetMedidaById?idMedida=' + id, this.userauth).subscribe((data: {}) => {
      this.medida = data;
      console.log('MEDIDAS', this.medida);

    });
  }

  eliminarMedida(id) {
    console.log(id);
    this.personaService.deletePersona('api/Medida/DeleteMedida?idMedida=' + id, this.userauth).subscribe(data => {
      this.getMedidasList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');

    }, error => {
      this.toastr.error('El servidor no responde', 'Error');
      console.log(error);
    });
  }

  cancelareditarMedida() {
    this.editmedida = false;
  }

  editarMed(id) {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    console.log('ID' + id);
    this.personaService.put('api/Medida/EditMedida', this.medida, this.userauth);
    console.log('EDITADO', this.medida);
    this.spinner.show();
    this.editmedida = false;
    this.showmedidas = true;
    setTimeout(() => {
      this.getMedidasList();
      this.spinner.hide();
      //this..controls['respuesta'].reset()
      /** spinner ends after 5 seconds */

    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  cancelarMedida() {
    this.addMedida = false;
    this.modalForm.controls['respuesta'].reset()
  }

  guardarMedida() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    this.personaService.post('api/Medida/AddMedida', this.medidan, this.userauth);
    console.log('GUARDADO', this.medidan);
    this.addMedida = false;
    this.spinner.show();

    setTimeout(() => {
      this.getMedidasList();
      //this.getTiposRespuestas(this.pidm,this.encuesta);

      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  addMe() {
    this.addMedida = true;
  }
  //
  mostrarNudos() {
    this.getNudosList();
    this.showbuttonnudos = false;
    this.addnewnudo = true;
    this.shownudos = true;
  }

  editarNudo(id) {
    console.log(id);
    this.getNudoId(id);
    this.editnudo = true;
  }


  getNudoId(id) {
    this.nudo = [];
    this.personaService.getPersonaById('api/NudosCritico/GetNudosCriticoById?idNudosCritico=' + id, this.userauth).subscribe((data: {}) => {
      this.nudo = data;
      console.log('NUDOS', this.nudo);

    });
  }

  eliminarNudo(id) {
    console.log(id);
    this.personaService.deletePersona('api/NudosCritico/DeleteNudosCritico?idNudosCritico=' + id, this.userauth).subscribe(data => {
      this.getNudosList();
      this.toastr.error('El Registro Fue eliminado Permanentemente!', 'Registro eliminado');

    }, error => {
      this.toastr.error('El servidor no responde', 'Error');
      console.log(error);
    });
  }

  cancelareditarNudo() {
    this.editnudo = false;
  }

  editarNud(id) {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    console.log('ID' + id);
    this.personaService.put('api/NudosCritico/EditNudosCritico', this.nudo, this.userauth);
    console.log('EDITADO', this.nudo);
    this.spinner.show();
    this.editnudo = false;
    this.shownudos = true;
    setTimeout(() => {
      this.getNudosList();
      this.spinner.hide();
      //this..controls['respuesta'].reset()
      /** spinner ends after 5 seconds */

    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  cancelarNudo() {
    this.addNudo = false;
    this.modalForm.controls['respuesta'].reset()
  }

  guardarNudo() {
    this.submitted = true;

    // stop here if form is invalid
    if (this.modalForm.invalid) {
      return;
    }
    this.personaService.post('api/NudosCritico/AddNudosCritico', this.nudon, this.userauth);
    console.log('GUARDADO', this.nudon);
    this.addNudo = false;
    this.spinner.show();

    setTimeout(() => {
      this.getNudosList();
      //this.getTiposRespuestas(this.pidm,this.encuesta);

      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.modalForm.controls['respuesta'].reset()
  }

  addNud() {
    this.addNudo = true;
  }



}
