import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
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
  agregarPersona: FormGroup;
  accion = 'Agregar';
  idPersona = 0;
  persona: Persona | undefined;
  /////////////////////////////////////////////////////////////
  constructor(private fb: FormBuilder,
    private _personaService: PersonaService,
    private router: Router,
    private aRoute: ActivatedRoute,
    private toastr: ToastrService) {
    this.agregarPersona = this.fb.group({
      ///////////formulario///////////////////////////
      // para validar datos ['', [Validators.required]],
      // para no validar ['', []],
      ///ejem -->nombrevariable: ['', Validators.required],
      ///////////////////////////////////////////////

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
    this.idPersona = +this.aRoute.snapshot.paramMap.get('idPersona')!;
    
  }

  ngOnInit(): void {
    this.esEditar();
  }

  esEditar() {
   ///// aqui le volvi a dejar como estaba para no dañar lo que hice
    if (this.idPersona != 0) {
      this.accion = 'Editar';
      this._personaService.getPersonaById(this.idPersona).subscribe(data => {
        this.persona = data;
        this.agregarPersona.patchValue({
          /////////////////////data//////////////////////////
          //////////variable: data.variable,////////////////////

          idOrganizacion: data.idOrganizacion,
          idModalidad: data.idModalidad,
          nombres: data.nombres,
          apellidos: data.apellidos,
          telefono: data.telefono,
          documentoIdentidad: data.documentoIdentidad,
          idGenero: data.idGenero,
          idEtnia: data.idEtnia,
          idNacionalidad: data.idNacionalidad,
          fechaNacimiento: data.fechaNacimiento,
          idProvincia: data.idProvincia,
          idCanton: data.idCanton,
          idParroquia: data.idParroquia,
          barrio: data.barrio,
          direccion: data.direccion,
          fechaDeIngresoUnidadAtencion: data.fechaDeIngresoUnidadAtencion,
          edadIngreso: data.edadIngreso,
          tiempoPermanenciaAños: data.tiempoPermanenciaAños,
          idMotivoIngreso: data.idMotivoIngreso
          /////////////////////////////////////////////////
        })
      }, error => {
        console.log(error);
      })
    }
  }

  agregarEditarPersona() {

    if (this.persona == undefined) {

      // Agregamos un nuevo Registro
      const persona: Persona = {
        ///////////////////modelo//////////////////////////  

        idOrganizacion: this.agregarPersona.get('idOrganizacion')?.value,
        idModalidad: this.agregarPersona.get('idModalidad')?.value,
        nombres: this.agregarPersona.get('nombres')?.value,
        apellidos: this.agregarPersona.get('apellidos')?.value,
        telefono: this.agregarPersona.get('telefono')?.value,
        documentoIdentidad: this.agregarPersona.get('documentoIdentidad')?.value,
        idGenero: this.agregarPersona.get('idGenero')?.value,
        idEtnia: this.agregarPersona.get('idEtnia')?.value,
        idNacionalidad: this.agregarPersona.get('idNacionalidad')?.value,
        fechaNaciento: this.agregarPersona.get('idfechaNacimiento')?.value,
        idProvincia: this.agregarPersona.get('idProvincia')?.value,
        idCanton: this.agregarPersona.get('idCanton')?.value,
        idParroquia: this.agregarPersona.get('idParroquia')?.value,
        barrio: this.agregarPersona.get('barrio')?.value,
        direccion: this.agregarPersona.get('direccion')?.value,
        fechaDeIngresoUnidadAtencion: this.agregarPersona.get('fechaDeIngresoUnidadAtencion')?.value,
        edadIngreso: this.agregarPersona.get('edadIngreso')?.value,
        tiempoPermanenciaAños: this.agregarPersona.get('tiempoPermanenciaAños')?.value,
        idMotivoIngreso: this.agregarPersona.get('idMotivoIngreso')?.value,


        //////////////////////////////////////////////////
      }
      this._personaService.addPersona(persona).subscribe(data => {
        this.toastr.success('La Persona fue registrado con exito', 'Persona registrada');
        this.router.navigate(['/']);
      }, error => {
        this.toastr.error('el servidor no esta funcionando!', 'Error');
        console.log(error);
      })
    } else {

      // Editamos Datos de Persona Registrada
      const persona: Persona = {
        //////el modelo del interfaz aqui//////////////////////
        idPersona: this.persona.idPersona,///el id aqui
        //////////////////////////////////////////////////////

        idOrganizacion: this.agregarPersona.get('idOrganizacion')?.value,
        idModalidad: this.agregarPersona.get('idModalidad')?.value,
        nombres: this.agregarPersona.get('nombres')?.value,
        apellidos: this.agregarPersona.get('apellidos')?.value,
        telefono: this.agregarPersona.get('telefono')?.value,
        documentoIdentidad: this.agregarPersona.get('documentoIdentidad')?.value,
        idGenero: this.agregarPersona.get('idGenero')?.value,
        idEtnia: this.agregarPersona.get('idEtnia')?.value,
        idNacionalidad: this.agregarPersona.get('idNacionalidad')?.value,
        fechaNaciento: this.agregarPersona.get('idfechaNacimiento')?.value,
        idProvincia: this.agregarPersona.get('idProvincia')?.value,
        idCanton: this.agregarPersona.get('idCanton')?.value,
        idParroquia: this.agregarPersona.get('idParroquia')?.value,
        barrio: this.agregarPersona.get('barrio')?.value,
        direccion: this.agregarPersona.get('direccion')?.value,
        fechaDeIngresoUnidadAtencion: this.agregarPersona.get('fechaDeIngresoUnidadAtencion')?.value,
        edadIngreso: this.agregarPersona.get('edadIngreso')?.value,
        tiempoPermanenciaAños: this.agregarPersona.get('tiempoPermanenciaAños')?.value,
        idMotivoIngreso: this.agregarPersona.get('idMotivoIngreso')?.value,

        ////////////////////////////////////////////////////
      }

      this._personaService.updatePersona(this.idPersona, persona).subscribe(data => {
        this.toastr.info('los datos fueron actualizados con exito', 'Persona actualizada');
        this.router.navigate(['/']);
      }, error => {
        this.toastr.error('Opss Ocurrio un error!', 'Error');
        console.log(error);
      })
    }
  }
  ///////////////////////////////////////////////////////////////////////////////////////////////////////
}