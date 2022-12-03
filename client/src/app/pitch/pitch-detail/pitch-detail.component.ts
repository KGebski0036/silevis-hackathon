import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { GameEvent } from 'src/app/_models/event';
import { Pitch } from 'src/app/_models/pitch';
import { PitchService } from 'src/app/_services/pitch.service';

@Component({
  selector: 'app-pitch-detail',
  templateUrl: './pitch-detail.component.html',
  styleUrls: ['./pitch-detail.component.css']
})
export class PitchDetailComponent {

  @Input()
  pitch?: Pitch;

  @Input()
  events?: GameEvent[];

  constructor() {
  }



}
