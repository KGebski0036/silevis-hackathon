import { Component, Input, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { GameEvent } from 'src/app/_models/event';
import { EventService } from 'src/app/_services/event.service';

@Component({
  selector: 'app-event-card',
  templateUrl: './event-card.component.html',
  styleUrls: ['./event-card.component.css']
})
export class EventCardComponent implements OnInit {

  @Input()
  ev?: GameEvent;

  @Input()
  hidePitch: boolean = false;

  constructor(private toastr: ToastrService, private eventService: EventService) { }

  onEventJoinClick() {
    if (this.ev == null) return;

    this.eventService.joinEvent(this.ev)?.subscribe(
      {
        complete: () => {
          this.toastr.success("Joined event!");
        },
        error: () => {
          this.toastr.error("Cannot join event!");
        }
      }
    )
  }

  ngOnInit(): void {
  }

}
