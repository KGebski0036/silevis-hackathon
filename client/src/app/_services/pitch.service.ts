import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/internal/operators/map';
import { Pitch } from '../_models/pitch';


@Injectable({
  providedIn: 'root'
})
export class PitchService
{
  baseUrl = 'https://localhost:5001/api/';

  loadedPitches: Pitch[] = [];

  constructor(private http: HttpClient) { }

  getPitches()
  {
    return this.http.get<Pitch[]>(this.baseUrl + 'pitch').pipe(map(response =>
    {
      this.loadedPitches = response;
    }));
  }
}
