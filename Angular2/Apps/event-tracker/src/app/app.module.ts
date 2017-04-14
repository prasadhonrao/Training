import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RatingDirective } from './shared/directives/rating/rating.directive';
import { ExceptionService } from './shared/services/exception/exception.service';
import { InitCapsPipe } from './shared/pipes/init-caps/init-caps.pipe';
import { DashboardModule } from './dashboard/dashboard.module';
import { AdminModule } from './admin/admin.module';
import { NavbarComponent } from './shared/navbar/navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    RatingDirective,
    InitCapsPipe,
    NavbarComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRoutingModule,
    DashboardModule,
    AdminModule
  ],
  providers: [ExceptionService],
  bootstrap: [AppComponent]
})
export class AppModule { }
