import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'et-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.css']
})
export class AboutComponent implements OnInit {
  private _modalElement: any;

  constructor() { }

  hideInfo() {
    console.log('bye');
    this._modalElement = document.getElementById('aboutApp');
    this._modalElement.style.display = 'none';
  }

  ngOnInit() {
  }

}
