import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'et-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  public pageTitle = 'Dashboard';
  constructor() { }

  ngOnInit() {
  }

}
