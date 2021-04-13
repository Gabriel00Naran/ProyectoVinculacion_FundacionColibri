import { Component, OnInit } from "@angular/core";

declare interface RouteInfo {
  path: string;
  title: string;

  icon: string;
  class: string;
}
export const ROUTES: RouteInfo[] = [

  {
    path: "/dashboard",
    title: "INICIO",
    icon: "icon-pin",
    class: "" },

  {
    path: "/Listar-Persona",
    title: "persona",
    icon: "icon-single-02",
    class: ""
  },

  {
    path: "/dashboard",
    title: "Datos Salud",
    icon: "icon-badge",
    class: ""
  },

  {
    path: "historial",
    title: "Historial",
    icon: "icon-bag-16",
    class: ""
  },
];

@Component({
  selector: "app-sidebar",
  templateUrl: "./sidebar.component.html",
  styleUrls: ["./sidebar.component.css"]
})
export class SidebarComponent implements OnInit {
  menuItems: any[];

  constructor() {}

  ngOnInit() {
    this.menuItems = ROUTES.filter(menuItem => menuItem);
  }
  isMobileMenu() {
    if (window.innerWidth > 991) {
      return false;
    }
    return true;
  }
}
