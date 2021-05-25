import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule , HTTP_INTERCEPTORS  } from '@angular/common/http';
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
import { LoginComponent } from './pages/login/login.component';
import { AuthenticationService } from './services/authentication.service';
import { ErrorInterceptor } from './helpers/error.interceptor';
import { JwtInterceptor } from './helpers/jwt.interceptor';
import { ErrorComponent } from './pages/error/error.component';
import { NgSelectModule } from '@ng-select/ng-select';

@NgModule({
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    NgSelectModule,
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
  providers: [   { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    PersonaService, AuthenticationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
