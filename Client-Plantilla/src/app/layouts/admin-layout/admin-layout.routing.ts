import { Routes } from '@angular/router';
import { AddLegalComponent } from 'src/app/pages/datos-legales/add-legal/add-legal.component';
import { DatosLegalesComponent } from 'src/app/pages/datos-legales/datos-legales.component';
import { EditLegalComponent } from 'src/app/pages/datos-legales/edit-legal/edit-legal.component';
import { AgregarHistorialCronologicoComponent } from 'src/app/pages/historial-cronologico/agregar-historial-cronologico/agregar-historial-cronologico.component';
import { EditarHistorialCronologicoComponent } from 'src/app/pages/historial-cronologico/editar-historial-cronologico/editar-historial-cronologico.component';
import { HistorialCronologicoComponent } from 'src/app/pages/historial-cronologico/historial-cronologico.component';
import { AgregarPersonaComponent } from 'src/app/pages/persona/agregar-persona/agregar-persona.component';
import { EditarPersonaComponent } from 'src/app/pages/persona/editar-persona/editar-persona.component';
import { PersonaComponent } from 'src/app/pages/persona/persona.component';
import { AddPgfComponent } from 'src/app/pages/pgf/add-pgf/add-pgf.component';
import { EditPgfComponent } from 'src/app/pages/pgf/edit-pgf/edit-pgf.component';
import { PgfComponent } from 'src/app/pages/pgf/pgf.component';
import { AgregarSaludComponent } from 'src/app/pages/salud/agregar-salud/agregar-salud.component';
import { EditarSaludComponent } from 'src/app/pages/salud/editar-salud/editar-salud.component';
import { SaludComponent } from 'src/app/pages/salud/salud.component';
import { DashboardComponent } from '../../pages/dashboard/dashboard.component';
import { VerPersonaComponent } from '../../pages/persona/ver-persona/ver-persona.component';

export const AdminLayoutRoutes: Routes = [
  { path: 'dashboard', component: DashboardComponent },
  { path: 'Listar-Persona', component: PersonaComponent },
  { path: 'Agregar-Persona', component: AgregarPersonaComponent },
  { path: 'Editar-Persona/:id', component: EditarPersonaComponent },
  { path: 'Ver-Persona/:id', component: VerPersonaComponent },
  { path: 'historial', component: HistorialCronologicoComponent },
  { path: 'legal', component: DatosLegalesComponent },
  { path: 'add-legal/:id', component: AddLegalComponent },
  { path: 'edit-legal/:id', component: EditLegalComponent },
  { path: 'salud', component: SaludComponent },
  { path: 'pgf', component: PgfComponent },
  { path: 'add-pgf/:id', component: AddPgfComponent },
  { path: 'edit-pgf/:id', component: EditPgfComponent },
  { path: 'add-historial/:id', component: AgregarHistorialCronologicoComponent },
  { path: 'Editar-Historial/:id', component: EditarHistorialCronologicoComponent },
  { path: 'add-salud/:id', component: AgregarSaludComponent },
  { path: 'edit-salud/:id', component: EditarSaludComponent },
  { path: '**', redirectTo: '/', pathMatch: 'full' },




];
