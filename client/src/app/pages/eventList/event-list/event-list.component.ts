import { Component, OnInit } from '@angular/core';
import { GameEvent } from 'src/app/_models/event';
import { User } from 'src/app/_models/user';
import { AccountService } from 'src/app/_services/account.service';
import { EventService } from 'src/app/_services/event.service';

@Component({
  selector: 'app-event-list',
  templateUrl: './event-list.component.html',
  styleUrls: ['./event-list.component.css']
})
export class EventListComponent implements OnInit {

  constructor(private service:EventService){ }



  ngOnInit(): void {
    this.service.getEvents().subscribe(o => this.events = o);
  }

  events?:GameEvent[]

}
