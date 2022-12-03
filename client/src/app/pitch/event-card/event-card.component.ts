import { ThisReceiver } from '@angular/compiler';
import { Component, Input, OnInit } from '@angular/core';
import { enableDebugTools } from '@angular/platform-browser';
import { ToastrService } from 'ngx-toastr';
import { GameEvent } from 'src/app/_models/event';
import { User } from 'src/app/_models/user';
import { AccountService } from 'src/app/_services/account.service';
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
  currentUser?: User;

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
