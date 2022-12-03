import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { GameEvent } from '../_models/event';


@Injectable({
  providedIn: 'root'
})
export class EventService {

  baseUrl = 'https://localhost:5001/api/event';


  
  constructor(private http: HttpClient) { }

  getEvents(){
    return this.http.get<Event[]>(this.baseUrl);
  }

  addEvent(event: GameEvent) {
    this.http.post<GameEvent>(this.baseUrl, event);
  }
}
