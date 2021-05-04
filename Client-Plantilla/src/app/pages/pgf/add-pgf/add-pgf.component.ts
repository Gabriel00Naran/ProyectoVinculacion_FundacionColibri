import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-add-pgf',
  templateUrl: './add-pgf.component.html',
  styleUrls: ['./add-pgf.component.scss']
})
export class AddPgfComponent implements OnInit {

  agregarpgf: FormGroup;
  agregarDiscapacidad: FormGroup;
  pgf: any;
  familiar: any = [];
  navigationSubscription: any;
  idpersona;
  sistemaedu: boolean;
  fam: boolean;
  nosistema: boolean;
  provincias: any = [];
  cantones: any = [];
  nacademico: any = [];


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
    this.sistemaedu = false;
    this.nosistema = false;
    this.fam = false;
    this.spinner.show();

    setTimeout(() => {
      this.getFamiliarTipo();
      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);

    this.agregarpgf = this.fb.group({
      idpgf: ['', []],
      idperonsa: ['', []],
      idfamiliarreferente: ['', []],
      nombrefamiliar: ['', []],
      idprovincia: ['', []],
      idcanton: ['', []],
      direccion: ['', []],
      telefono: ['', []],
      nnaInsertosistemaeducativo: ['', []],
      idnivelacademico: ['', []],
      nombreunidad: ['', []],
    });

    this.agregarDiscapacidad = this.fb.group({
      nombrefamiliar: ['', []],
      idprovincia: ['', []],
      idcanton: ['', []],
      direccion: ['', []],
      telefono: ['', []],
      nnaInsertosistemaeducativo: ['', []],
      idnivelacademico: ['', []],
      nombreunidad: ['', []],
    });

    this.pgf = {
      idperonsa: this.idpersona,
      idfamiliarreferente: '',
      nombrefamiliar: '',
      idprovincia: '',
      idcanton: '',
      direccion: '',
      telefono: '',
      nnaInsertosistemaeducativo: '',
      idnivelacademico: '',
      nombreunidad: '',

    };
  }


  insertosistema(value) {
    this.pgf.nna_insertosistemaeducativo = value;
    if (value !== ('true')) {
      this.nosistema = true;
      this.sistemaedu = false;
    } else {
      this.getNacademico();
      this.nosistema = false;
      this.sistemaedu = true;
    }
  }

  changefamiliar(value) {
    this.pgf.idfamiliarreferente = value;
    console.log(value);
    if (value !== ('16')) {
      this.getProvincias();
      this.fam = true;
    } else {
      this.fam = false;
    }
  }

  initializar() {
    if (this.route.snapshot.params.id.length) {
      this.idpersona = this.route.snapshot.params.id;
      console.log('parametro capturado id ', this.idpersona);
    }
  }


  submit() {
    this.AgregarPgf();
  }


  AgregarPgf() {
    this.personaService.post('api/Pgf/AddPgf', this.pgf);
    console.log('GUARDADO', this.pgf);
    this.router.navigate(['/pgf'], {
      skipLocationChange: true,
    });
  }


  getFamiliarTipo() {
    this.familiar = [];
    this.personaService.get('api/FamiliarReferente/GetFamiliarReferente').subscribe((data: {}) => {
      this.familiar = data;
      console.log('familiar', this.familiar);

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

  getNacademico() {
    this.nacademico = [];
    this.personaService.get('api/NivelAcademico/GetNivelAcademico').subscribe((data: {}) => {
      this.nacademico = data;
      console.log('Niveles Academicos', this.nacademico);

    });
  }

  canton(value) {
    //console.log(value);
    this.getCantonesbyidProvincia(value);
    this.cantones.provincia = value;
}

getCantonesbyidProvincia(id) {
  this.cantones = [];
  this.personaService.get('api/Canton/GetCantonByIdProvincia?idprovincia=' + id).subscribe((data: {}) => {
    this.cantones = data;
    console.log('CANTONES', this.cantones);

  });
}
}
