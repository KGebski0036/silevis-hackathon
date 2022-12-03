import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { Pitch } from 'src/app/_models/pitch';


@Component({
  selector: 'app-member-list',
  templateUrl: './member-list.component.html',
  styleUrls: ['./member-list.component.css']
})
export class MemberListComponent implements OnInit {


  selectedPitch?: Pitch;

  constructor() { }

  ngOnInit(): void {
  }

  closeDetails() {
    this.selectedPitch = undefined;
  }

  openDetails(pitch: Pitch) {
    this.selectedPitch = pitch;
  }

  
 
}
