import { HttpClient, HttpResponse } from '@angular/common/http';
import { EventEmitter, Injectable } from '@angular/core';

import { GameEvent } from '../_models/event';

import { environment } from 'src/environments/environment';
import { JoinEventArgs } from '../_models/joinEvent';
import { AccountService } from './account.service';
import { User } from '../_models/user';



@Injectable({
  providedIn: 'root'
})
export class EventService {

  baseUrl = 'https://localhost:5001/api/event';


  
  currentUser?: User;

  constructor(private http: HttpClient, private accService: AccountService) { 
    accService.currentUser$.subscribe((user) => {
      if(user != null) 
      this.currentUser = user;
    })
  }

  getEvents(){
    return this.http.get<GameEvent[]>(this.baseUrl);
  }

  addEvent(event: GameEvent) {
    return this.http.post(this.baseUrl, event);
  }


  joinEvent(event: GameEvent) {
    if (this.currentUser == null || event.id == null)  return;

    let joinEventData: JoinEventArgs = {
      currentUsername: this.currentUser.username,
      eventId: event.id,
    };


    return this.http.post(this.baseUrl + '/join', joinEventData);
  }
}
