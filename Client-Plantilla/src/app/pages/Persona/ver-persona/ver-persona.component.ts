import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-ver-persona',
  templateUrl: './ver-persona.component.html',
  styleUrls: ['./ver-persona.component.css']
})
export class VerPersonaComponent implements OnInit {
  navigationSubscription;
  verPersona: FormGroup;
  idPersona = 0;
  idform;
  persona: any;
  organizaciones: any = [];
  modalidades: any = [];
  generos: any = [];
  etnias: any = [];
  nacionalidades: any = [];
  provincias: any = [];
  cantones: any = [];
  parroquias: any = [];
  motivos: any = [];
  userauth;

  constructor(private fb: FormBuilder,
              private personaService: PersonaService,
              private route: ActivatedRoute,
              private router: Router,
              private toastr: ToastrService,
              private spinner: NgxSpinnerService) {
    this.navigationSubscription = this.router.events.subscribe((e: any) => {
      if (e instanceof NavigationEnd) {
      }
    });
  }

  ngOnInit(): void {
    this.userauth = atob(localStorage.getItem('currentUser'));
    this.initializar();
    this.spinner.show();

    setTimeout(() => {
      this.getOrganizaciones();
      this.getModalidades();
      this.getGeneros();
      this.getEtnias();
      this.getNacionalidades();
      this.getProvincias();
      this.getCantones();
      this.getParroquias();
      this.getMotivos();
      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);
    this.getGPreguntaId(atob(this.idform));
    this.verPersona = this.fb.group({
      idOrganizacion: ['', []],
      idModalidad: ['', []],
      nombres: ['', []],
      apellidos: ['', []],
      telefono: ['', []],
      documentoIdentidad: ['', []],
      idGenero: ['', []],
      idEtnia: ['', []],
      idNacionalidad: ['', []],
      fechaNacimiento: ['', []],
      idProvincia: ['', []],
      idCanton: ['', []],
      idParroquia: ['', []],
      barrio: ['', []],
      direccion: ['', []],
      fechaDeIngresoUnidadAtencion: ['', []],
      edadIngreso: ['', []],
      tiempoPermanenciaAnnios: ['', []],
      idMotivoIngreso: ['', []]

      //////////////////////////////////////////////
    });

  }

  initializar() {
    if (this.route.snapshot.params.id.length) {
      this.idform = btoa(this.route.snapshot.params.id);
      console.log('parametro capturado id ', btoa(this.idform));
    }
  }

  getGPreguntaId(id) {
    this.persona = [];
    this.personaService.getPersonaById('api/Persona/GetPersonaById?idPersona=' + id, this.userauth).subscribe((data: {}) => {
      this.persona = data;
      console.log('PERSONAS', this.persona);

    });
  }

  submit() {
    this.EditarPersona();
  }
  ///////////////////////////////////////////////////////////////////////////////////////////////////////
  EditarPersona() {
    this.personaService.put('api/Persona/EditPersona', this.persona, this.userauth);
    console.log('GUARDADO', this.persona);
    this.router.navigate(['/Listar-Persona'], {
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

  getModalidades() {
    this.modalidades = [];
    this.personaService.get('api/Modalidad/GetModalidad', this.userauth).subscribe((data: {}) => {
      this.modalidades = data;
      console.log('MODALIDADES', this.modalidades);

    });
  }

  getGeneros() {
    this.generos = [];
    this.personaService.get('api/Genero/GetGenero', this.userauth).subscribe((data: {}) => {
      this.generos = data;
      console.log('GENEROS', this.generos);

    });
  }

  getEtnias() {
    this.etnias = [];
    this.personaService.get('api/Etnia/GetEtnia', this.userauth).subscribe((data: {}) => {
      this.etnias = data;
      console.log('ETNIAS', this.etnias);

    });
  }

  getNacionalidades() {
    this.nacionalidades = [];
    this.personaService.get('api/Nacionalidad/GetNacionalidad', this.userauth).subscribe((data: {}) => {
      this.nacionalidades = data;
      console.log('NACIONALIDADES', this.nacionalidades);

    });
  }

  getProvincias() {
    this.provincias = [];
    this.personaService.get('api/Provincia/GetProvincia', this.userauth).subscribe((data: {}) => {
      this.provincias = data;
      console.log('PROVINCIAS', this.provincias);

    });
  }

  getCantones() {
    this.cantones = [];
    this.personaService.get('api/Canton/GetCanton', this.userauth).subscribe((data: {}) => {
      this.cantones = data;
      console.log('CANTONES', this.cantones);

    });
  }

  getParroquias() {
    this.parroquias = [];
    this.personaService.get('api/Parroquia/GetParroquia', this.userauth).subscribe((data: {}) => {
      this.parroquias = data;
      console.log('PARROQUIAS', this.parroquias);

    });
  }

  getMotivos() {
    this.motivos = [];
    this.personaService.get('api/MotivoIngreso/GetMotivoIngreso', this.userauth).subscribe((data: {}) => {
      this.motivos = data;
      console.log('MOTIVOS', this.motivos);

    });
  }

}
