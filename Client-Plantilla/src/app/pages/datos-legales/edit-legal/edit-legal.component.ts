import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router, NavigationEnd } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-edit-legal',
  templateUrl: './edit-legal.component.html',
  styleUrls: ['./edit-legal.component.scss']
})
export class EditLegalComponent implements OnInit {
  editarDJudicial: FormGroup;
  medidas: any = [];
  djudicial: any;
  navigationSubscription: any;
  idjudicialpenal;
  provincias: any = [];
  cantones: any = [];
  ncriticos: any = [];
  idenunciada: any = [];
  estadoprocesal: any = [];
  proceso: boolean;
  reinser: boolean;

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
    this.spinner.show();
    this.proceso = false;
    this.reinser = false;
    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.getDatoJudicialbyid(this.idjudicialpenal);
      this.getMedidas();
      this.getProvincias();
      this.getCantones();
      this.getNudos();
      this.spinner.hide();
    }, 3000);

    this.editarDJudicial = this.fb.group({
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
      idjudicialpenal: this.idjudicialpenal,
      idpersona: '',
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
    this.personaService.get('api/Medida/GetMedida').subscribe((data: {}) => {
      this.medidas = data;
      console.log('MEDIDAS', this.medidas);

    });
  }

  initializar() {
    if (this.route.snapshot.params.id.length) {
      this.idjudicialpenal = this.route.snapshot.params.id;
      console.log('parametro capturado id ', this.idjudicialpenal);
    }
  }


  submit() {
    this.EditarDatoJudicial();
  }


  EditarDatoJudicial() {
    this.personaService.put('api/DatosJudicialPenal/EditDatosJudicialPenal', this.djudicial);
    console.log('GUARDADO', this.djudicial);
    this.router.navigate(['/legal'], {
      skipLocationChange: true,
    });
  }

  getProvincias() {
    this.provincias = [];
    this.personaService.get('api/Provincia/GetProvincia').subscribe((data: {}) => {
      this.provincias = data;
      console.log('PROVINCIAS', this.provincias);

    });
  }

  getCantones() {
    this.cantones = [];
    this.personaService.get('api/Canton/GetCanton').subscribe((data: {}) => {
      this.cantones = data;
      console.log('CANTONES', this.cantones);

    });
  }

  getNudos() {
    this.ncriticos = [];
    this.personaService.get('api/NudosCritico/GetNudosCritico').subscribe((data: {}) => {
      this.ncriticos = data;
      console.log('NUDOS CRITICOS', this.ncriticos);

    });
  }

  getinfraccionesD() {
    this.idenunciada = [];
    this.personaService.get('api/InfraccionDenunciada/GetInfraccionDenunciada').subscribe((data: {}) => {
      this.idenunciada = data;
      console.log('INFRACCIONES DENUNCIADAS', this.idenunciada);

    });
  }

  getEstadoProcesal() {
    this.estadoprocesal = [];
    this.personaService.get('api/EstadoProcesal/GetEstadoProcesal').subscribe((data: {}) => {
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


  getDatoJudicialbyid(id: number) {
    this.djudicial = [];
    this.personaService.getPersonaById('api/DatosJudicialPenal/GetDatosJudicialPenalById?idJudicialPenal=' + id).subscribe((data: {}) => {
      this.djudicial = data;
      if (this.djudicial.egresoporreinsercion === true){
        this.getinfraccionesD();
        this.getEstadoProcesal();
        this.reinser = true;
      }
      if (this.djudicial.existecausapenal === true){
        this.getinfraccionesD();
        this.getEstadoProcesal();
        this.proceso = true;
      }
      console.log('Dato Judicial', this.djudicial);

    });
  }
}
