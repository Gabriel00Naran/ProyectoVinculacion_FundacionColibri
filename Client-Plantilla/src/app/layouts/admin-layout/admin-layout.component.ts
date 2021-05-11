import { AfterViewInit, Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admin-layout',
  templateUrl: './admin-layout.component.html',
  styleUrls: ['./admin-layout.component.scss']
})
export class AdminLayoutComponent {
  public sidebarColor = 'red';
  permisos;
  constructor() { }
  changeDashboardColor(color) {
    const body = document.getElementsByTagName('body')[0];
    if (body && color === 'white-content') {
      body.classList.add(color);
    }
    else if (body.classList.contains('white-content')) {

    }
  }
  ngDoCheck() {
    if(localStorage.getItem('currentUser')){
      console.log('TIENE PERMISOS');
      this.permisos = true;
    }else{
      console.log('NO TIENE PERMISOS');
      this.permisos= false;
    }
    this.changeDashboardColor('white-content');
  }

}
