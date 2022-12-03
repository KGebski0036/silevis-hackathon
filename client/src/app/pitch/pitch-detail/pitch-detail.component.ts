import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, ParamMap } from '@angular/router';
import { Pitch } from 'src/app/_models/pitch';
import { PitchService } from 'src/app/_services/pitch.service';

@Component({
  selector: 'app-pitch-detail',
  templateUrl: './pitch-detail.component.html',
  styleUrls: ['./pitch-detail.component.css']
})
export class PitchDetailComponent implements OnInit {

  @Input()
  pitch?: Pitch;


  constructor(private route: ActivatedRoute, private pitchService: PitchService) {}

  ngOnInit(): void {
    /* this.route.paramMap.subscribe((params: ParamMap) => {
      let id = params.get('id');

      if (id == null) return;

      this.pitchService.getPitchById(parseInt(id)).subscribe((pitch) => {
        this.pitch = pitch;
      });
    
    })*/
  } 

}
