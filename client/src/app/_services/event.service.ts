import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, map } from 'rxjs';
import { Pin } from '../_models/pin';
import { User } from '../_models/user';

@Injectable({
  providedIn: 'root'
})
export class EventService {
  baseUrl = 'https://localhost:5001/api/';

  
  constructor(private http: HttpClient) { }

  getEvents(model: any){

  }
}
