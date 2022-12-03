import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/internal/operators/map';
import { GameEvent } from '../_models/event';
import { Pitch } from '../_models/pitch';


@Injectable({
  providedIn: 'root'
})
export class PitchService
{
  baseUrl = 'https://localhost:5001/api/pitch';

  constructor(private http: HttpClient) { }

  getPitches()
  {
    return this.http.get<Pitch[]>(this.baseUrl);
  }

  getPitchById(id: number) {
    return this.http.get<Pitch>(this.baseUrl + '/' + id)
  }

  getEventsForPitch(pitchId: number) {
    return this.http.get<GameEvent[]>(this.baseUrl + '/events/' + pitchId)
  }
}
