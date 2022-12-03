import { Component, OnInit } from '@angular/core';
import { GameEvent } from 'src/app/_models/event';
import { Pitch } from 'src/app/_models/pitch';
import { PitchService } from 'src/app/_services/pitch.service';

@Component({
  selector: 'app-pitch-map',
  templateUrl: './pitch-map.component.html',
  styleUrls: ['./pitch-map.component.css']
})
export class PitchMapComponent implements OnInit {

  selectedPitch?: Pitch;
  selectedPitchEvents?: GameEvent[];

  constructor(private pitchService: PitchService) { }

  ngOnInit(): void {
  }

  closeDetails() {
    this.selectedPitch = undefined;
  }

  openDetails(pitch: Pitch) {
    this.selectedPitch = pitch;
    this.pitchService.getEventsForPitch(pitch.id).subscribe(events => this.selectedPitchEvents = events);
  }

 
}
