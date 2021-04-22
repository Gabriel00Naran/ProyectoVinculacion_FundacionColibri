import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { Persona } from 'src/app/models/persona';
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
  parroquias: any =[];
  motivos: any=[];
  /////////////////////////////////////////////////////////////
  constructor(private fb: FormBuilder,
    private personaService: PersonaService,
    private route: ActivatedRoute,
    private router: Router,
    private toastr: ToastrService,
    private spinner: NgxSpinnerService) 
    {
      this.navigationSubscription = this.router.events.subscribe((e: any) => {
        if (e instanceof NavigationEnd) {
          this.initializar();
        }
      });
  }

  ngOnInit(): void {
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
    this.getGPreguntaId(this.idform); 
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
    })
    
  }

  initializar() {
    if (this.route.snapshot.params.id.length) {
      this.idform = this.route.snapshot.params.id;
      console.log('parametro capturado id ', this.idform);
    }
  }

  getGPreguntaId(id: number) {
    this.persona = [];
    this.personaService.getPersonaById(id).subscribe((data: {}) => {
      this.persona = data;
      console.log('PERSONAS', this.persona);

    });
  }

  submit(){
    this.EditarPersona();
  }
  ///////////////////////////////////////////////////////////////////////////////////////////////////////
  EditarPersona(){
    this.personaService.put(this.persona);
    console.log('GUARDADO', this.persona);
    this.router.navigate(['/Listar-Persona'], {
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

  getModalidades(){
    this.modalidades = [];
    this.personaService.get('api/Modalidad/GetModalidad').subscribe((data: {}) => {
      this.modalidades = data;
      console.log('MODALIDADES', this.modalidades);

    });
  }

  getGeneros(){
    this.generos = [];
    this.personaService.get('api/Genero/GetGenero').subscribe((data: {}) => {
      this.generos = data;
      console.log('GENEROS', this.generos);

    });
  }

  getEtnias(){
    this.etnias = [];
    this.personaService.get('api/Etnia/GetEtnia').subscribe((data: {}) => {
      this.etnias = data;
      console.log('ETNIAS', this.etnias);

    });
  }

  getNacionalidades(){
    this.nacionalidades = [];
    this.personaService.get('api/Nacionalidad/GetNacionalidad').subscribe((data: {}) => {
      this.nacionalidades = data;
      console.log('NACIONALIDADES', this.nacionalidades);

    });
  }

  getProvincias(){
    this.provincias = [];
    this.personaService.get('api/Provincia/GetProvincia').subscribe((data: {}) => {
      this.provincias = data;
      console.log('PROVINCIAS', this.provincias);

    });
  }

  getCantones(){
    this.cantones = [];
    this.personaService.get('api/Canton/GetCanton').subscribe((data: {}) => {
      this.cantones = data;
      console.log('CANTONES', this.cantones);

    });
  }

  getParroquias(){
    this.parroquias = [];
    this.personaService.get('api/Parroquia/GetParroquia').subscribe((data: {}) => {
      this.parroquias = data;
      console.log('PARROQUIAS', this.parroquias);

    });
  }

  getMotivos(){
    this.motivos = [];
    this.personaService.get('api/MotivoIngreso/GetMotivoIngreso').subscribe((data: {}) => {
      this.motivos = data;
      console.log('MOTIVOS', this.motivos);

    });
  }

}
