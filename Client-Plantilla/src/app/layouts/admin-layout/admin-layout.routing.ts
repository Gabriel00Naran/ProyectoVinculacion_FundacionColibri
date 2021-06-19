import { Routes } from '@angular/router';
import { AddLegalComponent } from 'src/app/pages/datos-legales/add-legal/add-legal.component';
import { DatosLegalesComponent } from 'src/app/pages/datos-legales/datos-legales.component';
import { EditLegalComponent } from 'src/app/pages/datos-legales/edit-legal/edit-legal.component';
import { ViewLegalComponent } from 'src/app/pages/datos-legales/view-legal/view-legal.component';
import { ErrorComponent } from 'src/app/pages/error/error.component';
import { AgregarHistorialCronologicoComponent } from 'src/app/pages/historial-cronologico/agregar-historial-cronologico/agregar-historial-cronologico.component';
import { EditarHistorialCronologicoComponent } from 'src/app/pages/historial-cronologico/editar-historial-cronologico/editar-historial-cronologico.component';
import { HistorialCronologicoComponent } from 'src/app/pages/historial-cronologico/historial-cronologico.component';
import { VerHistorialCronologicoComponent } from 'src/app/pages/historial-cronologico/ver-historial-cronologico/ver-historial-cronologico.component';
import { LoginComponent } from 'src/app/pages/login/login.component';
import { OpcionesComponent } from 'src/app/pages/opciones/opciones.component';
import { AgregarPersonaComponent } from 'src/app/pages/persona/agregar-persona/agregar-persona.component';
import { EditarPersonaComponent } from 'src/app/pages/persona/editar-persona/editar-persona.component';
import { PersonaComponent } from 'src/app/pages/persona/persona.component';
import { AddPgfComponent } from 'src/app/pages/pgf/add-pgf/add-pgf.component';
import { EditPgfComponent } from 'src/app/pages/pgf/edit-pgf/edit-pgf.component';
import { PgfComponent } from 'src/app/pages/pgf/pgf.component';
import { ViewPgfComponent } from 'src/app/pages/pgf/view-pgf/view-pgf.component';
import { AgregarSaludComponent } from 'src/app/pages/salud/agregar-salud/agregar-salud.component';
import { EditarSaludComponent } from 'src/app/pages/salud/editar-salud/editar-salud.component';
import { SaludComponent } from 'src/app/pages/salud/salud.component';
import { VerSaludComponent } from 'src/app/pages/salud/ver-salud/ver-salud.component';
import { DashboardComponent } from '../../pages/dashboard/dashboard.component';
import { VerPersonaComponent } from '../../pages/persona/ver-persona/ver-persona.component';

export const AdminLayoutRoutes: Routes = [
  { path: 'login', component: LoginComponent },
  { path: 'error', component: ErrorComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'Listar-Persona', component: PersonaComponent },
  { path: 'Agregar-Persona', component: AgregarPersonaComponent },
  { path: 'Editar-Persona/:id', component: EditarPersonaComponent },
  { path: 'Ver-Persona/:id', component: VerPersonaComponent },
  { path: 'historial', component: HistorialCronologicoComponent },
  { path: 'legal', component: DatosLegalesComponent },
  { path: 'view-legal/:id', component: ViewLegalComponent },
  { path: 'add-legal/:id', component: AddLegalComponent },
  { path: 'edit-legal/:id', component: EditLegalComponent },
  { path: 'salud', component: SaludComponent },
  { path: 'pgf', component: PgfComponent },
  { path: 'view-pgf/:id', component: ViewPgfComponent },
  { path: 'add-pgf/:id', component: AddPgfComponent },
  { path: 'edit-pgf/:id', component: EditPgfComponent },
  { path: 'ver-historial/:id', component: VerHistorialCronologicoComponent },
  { path: 'add-historial/:id', component: AgregarHistorialCronologicoComponent },
  { path: 'Editar-Historial/:id', component: EditarHistorialCronologicoComponent },
  { path: 'add-salud/:id', component: AgregarSaludComponent },
  { path: 'edit-salud/:id', component: EditarSaludComponent },
  { path: 'ver-salud/:id', component: VerSaludComponent },
  { path: 'opciones', component: OpcionesComponent },
  { path: '**', redirectTo: '/', pathMatch: 'full' },




];
