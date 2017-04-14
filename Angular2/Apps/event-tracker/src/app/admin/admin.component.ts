import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'et-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit {
  public pageTitle = 'Admin';
  constructor() { }

  ngOnInit() {
  }

}
