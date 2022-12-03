import { Component, OnInit } from '@angular/core';
import { Pitch } from 'src/app/_models/pitch';

@Component({
  selector: 'app-pitch-map',
  templateUrl: './pitch-map.component.html',
  styleUrls: ['./pitch-map.component.css']
})
export class PitchMapComponent implements OnInit {

  selectedPitch?: Pitch;

  constructor() { }

  ngOnInit(): void {
  }

  closeDetails() {
    this.selectedPitch = undefined;
  }

  openDetails(pitch: Pitch) {
    this.selectedPitch = pitch;
  }

 
}
