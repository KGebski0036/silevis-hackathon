import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { GameEvent } from '../_models/event';


@Injectable({
  providedIn: 'root'
})
export class EventService {
  baseUrl = 'https://localhost:5001/api/event';

  
  constructor(private http: HttpClient) { }

  getEvents(model: any){

  }

  addEvent(event: GameEvent) {
    this.http.post<GameEvent>(this.baseUrl, event);
  }
}
