import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AdminLayoutRoutes } from './admin-layout.routing';
import { DashboardComponent } from '../../pages/dashboard/dashboard.component';
// import { RtlComponent } from "../../pages/rtl/rtl.component";
import { VerPersonaComponent } from '../../pages/persona/ver-persona/ver-persona.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PersonaComponent } from 'src/app/pages/persona/persona.component';
import { EditarPersonaComponent } from 'src/app/pages/persona/editar-persona/editar-persona.component';
import { AgregarPersonaComponent } from 'src/app/pages/persona/agregar-persona/agregar-persona.component';
import { NgxSpinnerModule } from 'ngx-spinner';
import { HistorialCronologicoComponent } from 'src/app/pages/historial-cronologico/historial-cronologico.component';
import { ButtonModule } from 'primeng/button';
import { DynamicDialogModule } from 'primeng/dynamicdialog';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';
import { DropdownModule } from 'primeng/dropdown';
import { RadioButtonModule } from 'primeng/radiobutton';
import {AutoCompleteModule} from 'primeng/autocomplete';
import { SaludComponent } from 'src/app/pages/salud/salud.component';
import { PgfComponent } from 'src/app/pages/pgf/pgf.component';
import { AgregarHistorialCronologicoComponent } from 'src/app/pages/historial-cronologico/agregar-historial-cronologico/agregar-historial-cronologico.component';
import { EditarHistorialCronologicoComponent } from 'src/app/pages/historial-cronologico/editar-historial-cronologico/editar-historial-cronologico.component';
import { AgregarSaludComponent } from 'src/app/pages/salud/agregar-salud/agregar-salud.component';
import { EditarSaludComponent } from 'src/app/pages/salud/editar-salud/editar-salud.component';
import { AddPgfComponent } from 'src/app/pages/pgf/add-pgf/add-pgf.component';
import { EditPgfComponent } from 'src/app/pages/pgf/edit-pgf/edit-pgf.component';
import { DatosLegalesComponent } from 'src/app/pages/datos-legales/datos-legales.component';
import { EditLegalComponent } from 'src/app/pages/datos-legales/edit-legal/edit-legal.component';
import { AddLegalComponent } from 'src/app/pages/datos-legales/add-legal/add-legal.component';

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(AdminLayoutRoutes),
    FormsModule,
    NgxSpinnerModule,
    HttpClientModule,
    NgbModule,
    ReactiveFormsModule,
    ButtonModule,
    DynamicDialogModule,
    TableModule,
    DialogModule,
    DropdownModule,
    RadioButtonModule,
    AutoCompleteModule,
  ],
  declarations: [
    DashboardComponent,
        VerPersonaComponent,
        PersonaComponent,
        AgregarPersonaComponent,
        EditarPersonaComponent,
        HistorialCronologicoComponent,
        SaludComponent,
        PgfComponent,
        AgregarHistorialCronologicoComponent,
        EditarHistorialCronologicoComponent,
        AgregarSaludComponent,
        EditarSaludComponent,
        AddPgfComponent,
        EditPgfComponent,
        DatosLegalesComponent,
        EditLegalComponent,
        AddLegalComponent
  ]
})
export class AdminLayoutModule {}
