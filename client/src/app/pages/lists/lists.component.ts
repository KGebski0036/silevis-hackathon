import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Pin } from '../../_models/pin';
import { PinService } from '../../_services/pin.service';

@Component({
  selector: 'app-lists',
  templateUrl: './lists.component.html',
  styleUrls: ['./lists.component.css']
})
export class ListsComponent implements OnInit {

  pins$!: Observable<Pin[]>;

  constructor(private pinService: PinService) { }

  ngOnInit(): void {
    this.pins$ = this.pinService.getPins();
  }

}
