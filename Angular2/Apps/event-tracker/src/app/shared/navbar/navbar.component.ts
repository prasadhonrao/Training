import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'et-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  title = 'Event Tracker';
  private _modalElement: any;

  constructor() { }

  ngOnInit(): void {
    this._modalElement = document.getElementById('aboutApp');
  }

  showInfo() {
    console.log('hi');
    this._modalElement.style.display = 'block';
  }
}
