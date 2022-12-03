import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { TestErrorComponent } from './errors/test-error/test-error.component';
import { HomeComponent } from './home/home.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MemberListComponent } from './members/member-list/member-list.component';

import { AuthGuard } from './_guards/auth.guard';
import { PitchDetailComponent } from './pitch/pitch-detail/pitch-detail.component';
import { MapViewComponent } from './map/map-view/map-view.component';
import { PitchMapComponent } from './pitch/pitch-map/pitch-map.component';
import { AddEventPageComponent } from './pages/addEvent/add-event-page/add-event-page.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: '', 
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      {path: 'members', component: MemberListComponent},
      {path: 'members/:id', component: MemberDetailComponent},
      {path: 'pitch/detail/:id', component: PitchDetailComponent},
      {path: 'events/add/:id', component: AddEventPageComponent},
      {path: 'lists', component: PitchMapComponent},
    ]
  },
  {path: 'errors', component: TestErrorComponent},
  {path: 'not-found', component: NotFoundComponent},
  {path: 'server-error', component: ServerErrorComponent},
  {path: '**', component: NotFoundComponent, pathMatch: 'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
