import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Pitch } from '../_models/pitch';


@Injectable({
  providedIn: 'root'
})
export class PitchService {
  baseUrl = 'https://localhost:5001/api/';
  
  constructor(private http: HttpClient) { }

  getPitches(model: any){
    return this.http.get<Pitch>(this.baseUrl + 'pins', model).subscribe();
  }
}
