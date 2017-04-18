import { Component } from '@angular/core';
import { ToastService } from './../shared/toast/toast.service';

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

  constructor(private toastService: ToastService) {
    this.toastService.activate('Activated events');
  }

}
