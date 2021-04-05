import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";
import { CommonModule } from "@angular/common";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { AdminLayoutRoutes } from "./admin-layout.routing";
import { DashboardComponent } from "../../pages/dashboard/dashboard.component";

// import { RtlComponent } from "../../pages/rtl/rtl.component";


import { AgregarEditarPersonaComponent } from '../../pages/Persona/agregar-editar-persona/agregar-editar-persona.component';
import { ListPersonasComponent } from '../../pages/Persona/list-personas/list-personas.component';
import { VerPersonaComponent } from '../../pages/Persona/ver-persona/ver-persona.component';

import { NgbModule } from "@ng-bootstrap/ng-bootstrap";

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(AdminLayoutRoutes),
    FormsModule,
    HttpClientModule,
    NgbModule,
    ReactiveFormsModule,
  ],
  declarations: [
    DashboardComponent,

    // RtlComponent

        //persona
        AgregarEditarPersonaComponent,
        ListPersonasComponent,
        VerPersonaComponent
  ]
})
export class AdminLayoutModule {}
