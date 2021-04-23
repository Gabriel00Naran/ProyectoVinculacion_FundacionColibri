import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-editar-historial-cronologico',
  templateUrl: './editar-historial-cronologico.component.html',
  styleUrls: ['./editar-historial-cronologico.component.scss']
})
export class EditarHistorialCronologicoComponent implements OnInit {

  editarHistorial: FormGroup;
  organizaciones: any = [];
  historial: any;
  navigationSubscription: any;
  idhistorial;

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

    setTimeout(() => {
      this.getHistorialbyid(this.idhistorial);
      /** spinner ends after 5 seconds */
      this.getOrganizaciones();
      this.spinner.hide();
    }, 3000);

    this.editarHistorial = this.fb.group({
      idhistorial: ['', []],
      idpersona: ['', []],
      estuboacogimiento: ['', []],
      idnombrecasaanterior: ['', []],
      fechaegreso: ['', []],
      fechaingreso: ['', []],

    });

    this.historial = {
      idhistorial: this.idhistorial,
      idpersona: '',
      estuboacogimiento: true,
      idnombrecasaanterior: '',
      fechaegreso: '',
      fechaingreso: '',
    };
  }



  getOrganizaciones() {
    this.organizaciones = [];
    this.personaService.get('api/Organizacion/GetOrganizacion').subscribe((data: {}) => {
      this.organizaciones = data;
      console.log('ORGANIZACIONES', this.organizaciones);

    });
  }

  initializar() {
    if (this.route.snapshot.params.id.length) {
      this.idhistorial = this.route.snapshot.params.id;
      console.log('parametro capturado id ', this.idhistorial);
    }
  }


  submit() {
    this.EditarHistorial();
  }


  EditarHistorial() {
    this.personaService.put('api/HistorialCronologico/EditHistorialCronologico', this.historial);
    console.log('GUARDADO', this.historial);
    this.router.navigate(['/historial'], {
      skipLocationChange: true,
    });
  }

  getHistorialbyid(id: number) {
    this.historial = [];
    this.personaService.getPersonaById('api/HistorialCronologico/GetHistorialCronologicoById?idHistorial=' + id).subscribe((data: {}) => {
      this.historial = data;
      console.log('Historial', this.historial);

    });
  }

}
