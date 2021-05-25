import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { User } from './models/user';
import { AuthenticationService } from './services/authentication.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Fundación Alas de Colibri';
  constructor(private router: Router) {
  }

  ngOnInit() {
    if(atob(localStorage.getItem('currentUser')) !=null){
      localStorage.removeItem('currentUser');
      this.router.navigate(['/login']);
    }
    else{ 
      this.router.navigate(['/dashboard']);
    }

  }
}
