import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/internal/operators/map';
import { environment } from 'src/environments/environment';
import { Pitch } from '../_models/pitch';


@Injectable({
  providedIn: 'root'
})
export class PitchService
{
  baseUrl = environment.apiUrl;


  constructor(private http: HttpClient) { }

  getPitches()
  {
    return this.http.get<Pitch[]>(this.baseUrl + 'pitch');
  }

  getPitchById(id: number) {
    return this.http.get<Pitch>(this.baseUrl + 'pitch/' + id)
  }
}
