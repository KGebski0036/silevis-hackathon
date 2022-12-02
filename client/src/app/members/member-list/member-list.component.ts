import { Component, OnInit } from '@angular/core';
import { Pin } from 'src/app/_models/pin';

@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {

  constructor() { }

  testpinlist: Pin[] = [];

  ngOnInit(): void {
  }
  /*
  createPin(id: number, name: string, lat:number, lon: number){}

  AddPin(pin: Pin)
  {
    this.testpinlist.push(pin)
  }
  */
}
