import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InitCapsDirective } from './shared/init-caps/init-caps.directive';
import { RatingDirective } from './shared/rating/rating.directive';
import { SessionModule } from './session/session.module';
import { SpeakerModule } from './speaker/speaker.module';

@NgModule({
  declarations: [
    AppComponent,
    InitCapsDirective,
    RatingDirective
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRoutingModule,
    SpeakerModule,
    SessionModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
