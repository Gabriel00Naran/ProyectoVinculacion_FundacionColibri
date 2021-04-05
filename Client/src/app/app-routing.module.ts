import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AgregarEditarPersonaComponent } from './components/Persona/agregar-editar-persona/agregar-editar-persona.component';
import { ListPersonasComponent } from './components/Persona/list-personas/list-personas.component';
import { VerPersonaComponent } from './components/Persona/ver-persona/ver-persona.component';

const routes: Routes = 

[
  ///PERSONA
  { path: '', component: ListPersonasComponent },
  { path: 'Agregar-Persona', component: AgregarEditarPersonaComponent },
  { path: 'Editar-Persona/:idPersona', component: AgregarEditarPersonaComponent },
  { path: 'Ver-Persona/:idPersona', component: VerPersonaComponent },
  { path: '**', redirectTo: '/', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
