import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, map } from 'rxjs';
import { Pin } from '../_models/pin';
import { User } from '../_models/user';

@Injectable({
  providedIn: 'root'
})
export class PinService
{
  baseUrl = 'https://localhost:5001/api/';
  loadedPins: Pin[] = [];

  constructor(private http: HttpClient) { }

  getPins()
  {
    return this.http.get<Pin[]>(this.baseUrl + 'pins').pipe(
      map(response => { this.loadedPins = response; return response; })
    );
  }
}
