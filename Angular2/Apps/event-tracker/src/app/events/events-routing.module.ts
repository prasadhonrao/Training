import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { EventListComponent } from './event-list.component';
import { EventDetailComponent } from './event-detail.component';

const routes: Routes = [
  {
    path: 'events',
    component:  EventListComponent
  },
  {
    path: 'events/:',
    component:  EventDetailComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EventsRoutingModule { }
