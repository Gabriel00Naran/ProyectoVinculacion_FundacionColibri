import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';// formularios reactivos 
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr'; // el toast que no pude usarlo en ese tiempo con el inge gorki 
// ahora entiendo como funciona
import { AppComponent } from './app.component';
import { NavbarComponent } from './components/navbar/navbar.component';



//persona

import { AgregarEditarPersonaComponent } from './components/Persona/agregar-editar-persona/agregar-editar-persona.component';
import { ListPersonasComponent } from './components/Persona/list-personas/list-personas.component';
import { VerPersonaComponent } from './components/Persona/ver-persona/ver-persona.component';


@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
        
    //persona
    AgregarEditarPersonaComponent,
    ListPersonasComponent,
    VerPersonaComponent
  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
   
    BrowserAnimationsModule, // required animations module
    ToastrModule.forRoot() // ToastrModule added
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
