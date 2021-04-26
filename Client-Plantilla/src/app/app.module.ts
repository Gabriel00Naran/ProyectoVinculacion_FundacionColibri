import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from './app.component';
import { AdminLayoutComponent } from './layouts/admin-layout/admin-layout.component';


import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { AppRoutingModule } from './app-routing.module';
import { ComponentsModule } from './components/components.module';
import { PersonaService } from './services/persona.service';
import { NgxSpinnerModule } from 'ngx-spinner';
import { DynamicDialogModule } from 'primeng/dynamicdialog';
import { TableModule } from 'primeng/table';
import { AgregarSaludComponent } from './pages/salud/agregar-salud/agregar-salud.component';
import { EditarSaludComponent } from './pages/salud/editar-salud/editar-salud.component';
import { AddPgfComponent } from './pages/pgf/add-pgf/add-pgf.component';
import { EditPgfComponent } from './pages/pgf/edit-pgf/edit-pgf.component';
import { DatosLegalesComponent } from './pages/datos-legales/datos-legales.component';
import { AddLegalComponent } from './pages/datos-legales/add-legal/add-legal.component';
import { EditLegalComponent } from './pages/datos-legales/edit-legal/edit-legal.component';

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
    DynamicDialogModule,
    TableModule,
    ToastrModule.forRoot()
  ],
  declarations: [AppComponent, AdminLayoutComponent],
  providers: [PersonaService],
  bootstrap: [AppComponent]
})
export class AppModule { }
