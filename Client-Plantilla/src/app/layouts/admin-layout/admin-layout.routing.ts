import { Routes } from "@angular/router";
import { AgregarPersonaComponent } from "src/app/pages/persona/agregar-persona/agregar-persona.component";
import { EditarPersonaComponent } from "src/app/pages/persona/editar-persona/editar-persona.component";
import { PersonaComponent } from "src/app/pages/persona/persona.component";
import { DashboardComponent } from "../../pages/dashboard/dashboard.component";
import { VerPersonaComponent } from '../../pages/persona/ver-persona/ver-persona.component';

export const AdminLayoutRoutes: Routes = [
  { path: "dashboard", component: DashboardComponent },
   { path: 'Listar-Persona', component: PersonaComponent },
   { path: 'Agregar-Persona', component: AgregarPersonaComponent },
   { path: 'Editar-Persona/:id', component: EditarPersonaComponent },
   { path: 'Ver-Persona/:idPersona', component: VerPersonaComponent },
   { path: '**', redirectTo: '/', pathMatch: 'full' },


  
];
