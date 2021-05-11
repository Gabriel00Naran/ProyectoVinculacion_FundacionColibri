import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-add-legal',
  templateUrl: './add-legal.component.html',
  styleUrls: ['./add-legal.component.scss']
})
export class AddLegalComponent implements OnInit {
  agregarDJudicial: FormGroup;
  medidas: any = [];
  djudicial: any;
  navigationSubscription: any;
  idpersona;
  provincias: any = [];
  cantones: any = [];
  ncriticos: any = [];
  idenunciada: any = [];
  estadoprocesal: any = [];
  proceso: boolean;
  reinser: boolean;
  userauth;

  constructor(private personaService: PersonaService,
              private fb: FormBuilder,
              private route: ActivatedRoute,
              private router: Router,
              private toastr: ToastrService,
              private spinner: NgxSpinnerService) {

    this.navigationSubscription = this.router.events.subscribe((e: any) => {
      if (e instanceof NavigationEnd) {
        this.initializar();
      }
    });
  }

  ngOnInit(): void {
    this.userauth = atob(localStorage.getItem('currentUser'));
    this.spinner.show();
    this.proceso = false;
    this.reinser = false;
    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.getMedidas();
      this.getProvincias();
      this.getNudos();
      this.spinner.hide();
    }, 3000);

    this.agregarDJudicial = this.fb.group({
      idjudicialpenal: ['', []],
      idpersona: ['', []],
      idmedida: ['', []],
      idprovincia: ['', []],
      ncausaacogimiento: ['', []],
      unidadjudicial: ['', []],
      idcanton: ['', []],
      idnudoscriticos: ['', []],
      existecausapenal: ['', []],
      encuentrainsertSpavt: ['', []],
      idinfracciondenunciada: ['', []],
      descripciondelito: ['', []],
      ncasofiscalia: ['', []],
      nprocesopenalesatje: ['', []],
      idestadoprocesal: ['', []],
      egresoporreinsercion: ['', []],
      fechareinsercion: ['', []],
      fechaegreso: ['', []],
      fecharesoluciontraslado: ['', []],
      unidadtraslado: ['', []],
      fechasalidaunidadactual: ['', []],
      observacion: ['', []],

    });

    this.djudicial = {
      idpersona: atob(this.idpersona),
      idmedida: '',
      idprovincia: '',
      ncausaacogimiento: '',
      unidadjudicial: '',
      idcanton: '',
      idnudoscriticos: '',
      existecausapenal: '',
      encuentrainsertSpavt: '',
      idinfracciondenunciada: '',
      descripciondelito: '',
      ncasofiscalia: '',
      nprocesopenalesatje: '',
      idestadoprocesal: '',
      egresoporreinsercion: '',
      fechareinsercion: '',
      fechaegreso: '',
      fecharesoluciontraslado: '',
      unidadtraslado: '',
      fechasalidaunidadactual: '',
      observacion: '',
    };
  }


  getMedidas() {
    this.medidas = [];
    this.personaService.get('api/Medida/GetMedida', this.userauth).subscribe((data: {}) => {
      this.medidas = data;
      console.log('MEDIDAS', this.medidas);

    });
  }

  initializar() {
    if (this.route.snapshot.params.id.length) {
      this.idpersona = btoa(this.route.snapshot.params.id);
      console.log('parametro capturado id ', btoa(this.idpersona));
    }
  }


  submit() {
    this.AgregarHistorial();
  }


  AgregarHistorial() {
    this.personaService.post('api/DatosJudicialPenal/AddDatosJudicialPenal', this.djudicial, this.userauth);
    console.log('GUARDADO', this.djudicial);
    this.router.navigate(['/legal'], {
      skipLocationChange: true,
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

  getNudos() {
    this.ncriticos = [];
    this.personaService.get('api/NudosCritico/GetNudosCritico', this.userauth).subscribe((data: {}) => {
      this.ncriticos = data;
      console.log('NUDOS CRITICOS', this.ncriticos);

    });
  }

  getinfraccionesD() {
    this.idenunciada = [];
    this.personaService.get('api/InfraccionDenunciada/GetInfraccionDenunciada', this.userauth).subscribe((data: {}) => {
      this.idenunciada = data;
      console.log('INFRACCIONES DENUNCIADAS', this.idenunciada);

    });
  }

  getEstadoProcesal() {
    this.estadoprocesal = [];
    this.personaService.get('api/EstadoProcesal/GetEstadoProcesal', this.userauth).subscribe((data: {}) => {
      this.estadoprocesal = data;
      console.log('ESTADO PROCESAL', this.estadoprocesal);

    });
  }

  existe(value) {
    this.djudicial.existecausapenal = value;
    console.log(value);
    if (value !== ('true')) {
      this.proceso = false;
    } else {
      this.getinfraccionesD();
      this.getEstadoProcesal();
      this.proceso = true;

    }
  }

  reinsercion(value) {
    this.djudicial.egresoporreinsercion = value;
    console.log(value);
    if (value !== ('true')) {
      this.reinser = false;
    } else {
      this.getinfraccionesD();
      this.getEstadoProcesal();
      this.reinser = true;

    }
  }

  canton(value) {
    //console.log(value);
    this.getCantonesbyidProvincia(value);
    this.cantones.provincia = value;
}

getCantonesbyidProvincia(id) {
  this.cantones = [];
  this.personaService.get('api/Canton/GetCantonByIdProvincia?idprovincia=' + id, this.userauth).subscribe((data: {}) => {
    this.cantones = data;
    console.log('CANTONES', this.cantones);

  });
}

}
