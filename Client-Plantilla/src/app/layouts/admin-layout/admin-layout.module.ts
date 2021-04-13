import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";
import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { AdminLayoutRoutes } from "./admin-layout.routing";
import { DashboardComponent } from "../../pages/dashboard/dashboard.component";
// import { RtlComponent } from "../../pages/rtl/rtl.component";
import { VerPersonaComponent } from '../../pages/persona/ver-persona/ver-persona.component';
import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { PersonaComponent } from "src/app/pages/persona/persona.component";
import { EditarPersonaComponent } from "src/app/pages/persona/editar-persona/editar-persona.component";
import { AgregarPersonaComponent } from "src/app/pages/persona/agregar-persona/agregar-persona.component";
import { NgxSpinnerModule } from "ngx-spinner";
import { HistorialCronologicoComponent } from "src/app/pages/historial-cronologico/historial-cronologico.component";

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(AdminLayoutRoutes),
    FormsModule,
    NgxSpinnerModule,
    HttpClientModule,
    NgbModule,
    ReactiveFormsModule,
  ],
  declarations: [
    DashboardComponent,
        VerPersonaComponent,
        PersonaComponent,
        AgregarPersonaComponent,
        EditarPersonaComponent,
        HistorialCronologicoComponent

  ]
})
export class AdminLayoutModule {}
