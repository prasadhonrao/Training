import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'et-event-detail',
  templateUrl: './event-detail.component.html',
  styleUrls: ['./event-detail.component.css']
})
export class EventDetailComponent implements OnInit {
  public pageTitle = 'Event Details';
  constructor() { }

  ngOnInit() {
  }

}
