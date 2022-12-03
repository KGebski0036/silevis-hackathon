import { isNgTemplate } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { GameEvent } from 'src/app/_models/event';
import { EventService } from 'src/app/_services/event.service';



@Component({
  selector: 'app-add-event-page',
  templateUrl: './add-event-page.component.html',
  styleUrls: ['./add-event-page.component.css']
})
export class AddEventPageComponent implements OnInit {

  constructor(private route: ActivatedRoute, private service: EventService) { }

  pitchId?: number;


  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      let param = params.get('id');
      if (param == null) return;
      let id = parseInt(param);
      if (isNaN(id)) return;
      this.pitchId = id;
    })
  }

  addEvent = new FormGroup({
    maxPlayers: new FormControl('', [Validators.min(1), Validators.max(100)]),
    dateOfEvent: new FormControl('', [Validators.required, Validators.min(Date.now())]),
    timeOfEvent: new FormControl('', [Validators.required])
  });

  onSubmit() {
    let ev: GameEvent = { pitchId: this.pitchId }

    let max = this.addEvent.value.maxPlayers;
    if (max != null && parseInt(max)) {
     ev.maxPlayers = parseInt(max);
    }

    let date = this.addEvent.value.dateOfEvent;
    let hour = this.addEvent.value.timeOfEvent;
    if(date != null && hour != null) {
      ev.dateFrom = new Date(date);
    }
    this.service.addEvent(ev);

  }

}
