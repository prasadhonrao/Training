import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'et-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public pageTitle = 'Home';
  constructor() { }

  ngOnInit() {
  }

}
