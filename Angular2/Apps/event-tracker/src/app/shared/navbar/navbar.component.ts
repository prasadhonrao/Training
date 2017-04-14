import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'et-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {

  title = 'Event Tracker';
  constructor() { }

  ngOnInit() {
  }

}
