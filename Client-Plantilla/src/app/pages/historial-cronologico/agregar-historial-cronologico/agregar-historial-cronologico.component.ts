import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { PersonaService } from 'src/app/services/persona.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-agregar-historial-cronologico',
  templateUrl: './agregar-historial-cronologico.component.html',
  styleUrls: ['./agregar-historial-cronologico.component.scss']
})
export class AgregarHistorialCronologicoComponent implements OnInit {

agregarHistorial: FormGroup;
organizaciones: any = [];
historial: any;
navigationSubscription: any;
idpersona;
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

    setTimeout(() => {
      /** spinner ends after 5 seconds */
      this.getOrganizaciones();
      this.spinner.hide();
    }, 3000);

    this.agregarHistorial = this.fb.group({
      idhistorial: ['', []],
      idpersona: ['', []],
      estuboacogimiento: ['', []],
      idnombrecasaanterior: ['', []],
      fechaegreso: ['', []],
      fechaingreso: ['', []],

    });

    this.historial = {
      idpersona: this.idpersona,
      estuboacogimiento: true,
      idnombrecasaanterior: '',
      fechaegreso: '',
      fechaingreso: '',
    };
  }



  getOrganizaciones() {
    this.organizaciones = [];
    this.personaService.get('api/Organizacion/GetOrganizacion', this.userauth).subscribe((data: {}) => {
      this.organizaciones = data;
      console.log('ORGANIZACIONES', this.organizaciones);

    });
  }

  initializar() {
    if (this.route.snapshot.params.id.length) {
      this.idpersona = this.route.snapshot.params.id;
      console.log('parametro capturado id ', this.idpersona);
    }
  }


  submit() {
    this.AgregarHistorial();
  }


  AgregarHistorial() {
    this.personaService.post('api/HistorialCronologico/AddHistorialCronologico', this.historial, this.userauth);
    console.log('GUARDADO', this.historial);
    this.router.navigate(['/historial'], {
      skipLocationChange: true,
    });
  }
}
