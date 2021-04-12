import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from "./app.component";
import { AdminLayoutComponent } from "./layouts/admin-layout/admin-layout.component";


import { NgbModule } from "@ng-bootstrap/ng-bootstrap";

import { AppRoutingModule } from "./app-routing.module";
import { ComponentsModule } from "./components/components.module";
import { PersonaService } from "./services/persona.service";
import { PersonaComponent } from './pages/persona/persona.component';
import { AgregarPersonaComponent } from './pages/persona/agregar-persona/agregar-persona.component';
import { EditarPersonaComponent } from './pages/persona/editar-persona/editar-persona.component';
import { NgxSpinnerModule } from "ngx-spinner";

@NgModule({
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    ComponentsModule,
    NgxSpinnerModule,
    NgbModule,
    RouterModule,
    AppRoutingModule,
    ToastrModule.forRoot()
  ],
  declarations: [AppComponent, AdminLayoutComponent],
  providers: [PersonaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
