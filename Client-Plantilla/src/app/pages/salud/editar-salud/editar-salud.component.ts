import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-editar-salud',
  templateUrl: './editar-salud.component.html',
  styleUrls: ['./editar-salud.component.scss']
})
export class EditarSaludComponent implements OnInit {

  editarSalud: FormGroup;
  agregarDiscapacidad: FormGroup;
  salud: any;
  navigationSubscription: any;
  essalud: boolean;
  disc: boolean;
  iddatossalud;

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
    this.essalud = false;
    this.disc = false;
    this.spinner.show();
    this.getSaludbyid(this.iddatossalud);
    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.spinner.hide();
    }, 3000);

    this.editarSalud = this.fb.group({
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
      iddatossalud: this.iddatossalud,
      idpersona: '',
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
      this.iddatossalud = this.route.snapshot.params.id;
      console.log('parametro capturado id ', this.iddatossalud);
    }
  }


  submit() {
    this.EditarSalud();
  }


  EditarSalud() {
    this.personaService.put('api/DatosSalud/EditDatosSalud', this.salud);
    console.log('GUARDADO', this.salud);
    this.router.navigate(['/salud'], {
      skipLocationChange: true,
    });
  }

  getSaludbyid(id: number) {
    this.salud = [];
    this.personaService.getPersonaById('api/DatosSalud/GetDatosSaludById?idDatosSalud=' + id).subscribe((data: {}) => {
      this.salud = data;
      if (this.salud.estadosalud === 'Enferm@'){
        this.essalud = true;
      }
      if (this.salud.algunadiscapacidad === true){
        this.disc = true;
      }
      console.log('Salud', this.salud);

    });
  }

}
