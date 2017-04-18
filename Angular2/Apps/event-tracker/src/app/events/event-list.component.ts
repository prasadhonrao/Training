import { Component } from '@angular/core';

@Component({
  selector: 'et-event-list',
  templateUrl: './event-list.component.html',
  styleUrls: ['./event-list.component.css']
})
export class EventListComponent {
  public pageTitle = 'Events';

  public events: any[] = [
    {
      'eventId': 1,
      'eventName': 'Hackathon'
    },
    {
      'eventId': 2,
      'eventName': 'Azure Bootcamp'
    }
  ];

  constructor() { }

}
