import { Routes } from "@angular/router";

import { DashboardComponent } from "../../pages/dashboard/dashboard.component";


import { AgregarEditarPersonaComponent } from '../../pages/Persona/agregar-editar-persona/agregar-editar-persona.component';
import { ListPersonasComponent } from '../../pages/Persona/list-personas/list-personas.component';
import { VerPersonaComponent } from '../../pages/Persona/ver-persona/ver-persona.component';

export const AdminLayoutRoutes: Routes = [
  { path: "dashboard", component: DashboardComponent },


   ///PERSONA
   { path: 'Listar-Persona', component: ListPersonasComponent },
   { path: 'Agregar-Persona', component: AgregarEditarPersonaComponent },
   { path: 'Editar-Persona/:id', component: AgregarEditarPersonaComponent },
   { path: 'Ver-Persona/:idPersona', component: VerPersonaComponent },
   { path: '**', redirectTo: '/', pathMatch: 'full' },


  
];
