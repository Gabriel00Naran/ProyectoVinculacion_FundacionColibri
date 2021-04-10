import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, NavigationEnd,Router } from '@angular/router';
import { Guid } from 'guid-typescript';
import { ToastrService } from 'ngx-toastr';
import { Persona } from 'src/app/models/persona';
import { PersonaService } from 'src/app/services/persona.service';

@Component({
  selector: 'app-agregar-editar-persona',
  templateUrl: './agregar-editar-persona.component.html',
  styleUrls: ['./agregar-editar-persona.component.css']
})
export class AgregarEditarPersonaComponent implements OnInit {
  //////////////////////////////////////////////////////////////////////////////////////////////////////////
  navigationSubscription;
  agregarPersona: FormGroup;
  accion = 'Agregar';
  idPersona = 0;
  idform;
  persona: any;
  /////////////////////////////////////////////////////////////
  constructor(private fb: FormBuilder,
    private _personaService: PersonaService,
    private route: ActivatedRoute,
    private router: Router,
    private toastr: ToastrService) 
    {
      this.navigationSubscription = this.router.events.subscribe((e: any) => {
        if (e instanceof NavigationEnd) {
          this.initializar();
        }
      });
  }

  ngOnInit(): void {
    this.getGPreguntaId(this.idform); 
    this.agregarPersona = this.fb.group({
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
      tiempoPermanenciaAños: ['', []],
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
    this._personaService.getPersonaById(id).subscribe((data: {}) => {
      this.persona = data;
      console.log('PERSONAS', this.persona);

    });
  }

  submit(){
    this.agregarEditarPersona();
  }
  ///////////////////////////////////////////////////////////////////////////////////////////////////////
  agregarEditarPersona(){
    this._personaService.put(this.persona);
    console.log('GUARDADO', this.persona);
  }

 
}