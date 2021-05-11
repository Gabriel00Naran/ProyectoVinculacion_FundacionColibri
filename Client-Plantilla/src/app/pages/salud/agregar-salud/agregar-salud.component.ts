import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-agregar-salud',
  templateUrl: './agregar-salud.component.html',
  styleUrls: ['./agregar-salud.component.scss']
})
export class AgregarSaludComponent implements OnInit {

  agregarSalud: FormGroup;
  agregarDiscapacidad: FormGroup;
  salud: any;
  navigationSubscription: any;
  idpersona;
  essalud: boolean;
  disc: boolean;
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
    this.essalud = false;
    this.disc = false;
    this.spinner.show();

    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);

    this.agregarSalud = this.fb.group({
      iddatossalud: ['', []],
      idpersona: ['', []],
      estadosalud: ['', []],
      detalleenfermedad: ['', []],
      medicacion: ['', []],
      adolescenteperdiodogestacion: ['', []],
      algunadiscapacidad: ['', []],
      tipodiscapacidad: ['', []],
      porcentajediscapacidad: ['', []],
      numerocarnet: ['', []],
    });

    this.agregarDiscapacidad = this.fb.group({
      detalleenfermedad: ['', []],
      medicacion: ['', []],
      adolescenteperdiodogestacion: ['', []],
      algunadiscapacidad: ['', []],
      tipodiscapacidad: ['', []],
      porcentajediscapacidad: ['', []],
      numerocarnet: ['', []],
    });

    this.salud = {
      idpersona: this.idpersona,
      estadosalud: '',
      detalleenfermedad: '',
      medicacion: '',
      adolescenteperdiodogestacion: '',
      algunadiscapacidad: '',
      tipodiscapacidad: '',
      porcentajediscapacidad: '',
      numerocarnet: '',

    };
  }


  estadodesalud(value) {
    this.salud.estadosalud = value;
    if (value !== ('Enferm@')) {
      this.essalud = false;
    } else {
      this.essalud = true;
    }
  }

  discapacidad(value) {
    this.salud.algunadiscapacidad = value;
    console.log(value);
    if (value !== ('true')) {
      this.disc = false;
    } else {
      this.disc = true;
    }
  }

  initializar() {
    if (this.route.snapshot.params.id.length) {
      this.idpersona = this.route.snapshot.params.id;
      console.log('parametro capturado id ', this.idpersona);
    }
  }


  submit() {
    this.AgregarSalud();
  }


  AgregarSalud() {
    this.personaService.post('api/DatosSalud/AddDatosSalud', this.salud, this.userauth);
    console.log('GUARDADO', this.salud);
    this.router.navigate(['/salud'], {
      skipLocationChange: true,
    });
  }

}
