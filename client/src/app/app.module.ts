import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './pages/register/register.component';
import { MemberListComponent } from './members/member-list/member-list.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { SharedModule } from './_modules/shared.module';
import { TestErrorComponent } from './errors/test-error/test-error.component';
import { ErrorInterceptor } from './_interceptors/error.interceptor';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { AddEventPageComponent } from './pages/addEvent/add-event-page/add-event-page.component';
import { MapViewComponent } from './map/map-view/map-view.component';
import { PitchDetailComponent } from './pitch/pitch-detail/pitch-detail.component';
import { OffCanvasBackdropComponent } from './utils/off-canvas-backdrop/off-canvas-backdrop.component';
import { PitchMapComponent } from './pitch/pitch-map/pitch-map.component';

import { EventListComponent } from './pages/eventList/event-list/event-list.component';
import { LearnMoreComponent } from './pages/learnMore/learn-more/learn-more.component';

import { MemberCardComponent } from './members/member-card/member-card.component';



@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    HomeComponent,
    RegisterComponent,
    MemberListComponent,
    MemberDetailComponent,
    MapViewComponent,
    TestErrorComponent,
    NotFoundComponent,
    ServerErrorComponent,
    AddEventPageComponent,
    PitchDetailComponent,
    OffCanvasBackdropComponent,
    PitchMapComponent,
    EventListComponent,
    LearnMoreComponent,
    MemberCardComponent

  ],
  imports: [
    BrowserAnimationsModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    SharedModule,
    ReactiveFormsModule
  ],
  providers: [
    {provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
