import { Component, OnInit } from '@angular/core';
import { ToastService } from './../shared/toast/toast.service';

@Component({
  selector: 'et-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {
  public pageTitle = 'Dashboard';

  constructor(private toastService: ToastService) {
    this.toastService.activate('Activated dashboard');
  }

  ngOnInit() {
  }

}
