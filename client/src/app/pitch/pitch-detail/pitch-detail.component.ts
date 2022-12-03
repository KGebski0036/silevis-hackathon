import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { GameEvent } from 'src/app/_models/event';
import { Pitch } from 'src/app/_models/pitch';

@Component({
  selector: 'app-pitch-detail',
  templateUrl: './pitch-detail.component.html',
  styleUrls: ['./pitch-detail.component.css']
})
export class PitchDetailComponent implements OnInit{

  @Input()
  pitch?: Pitch;

  @Input()
  events: GameEvent[] = [];


  addEventClicked(pitchId: number) {
    this.router.navigateByUrl('/events/add/' + pitchId);
  }

  constructor(private router: Router) {
  }
  ngOnInit(): void {
  }



}
