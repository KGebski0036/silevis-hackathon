import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';



@Component({
  selector: 'app-add-event-page',
  templateUrl: './add-event-page.component.html',
  styleUrls: ['./add-event-page.component.css']
})
export class AddEventPageComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  addEvent = new FormGroup({
    playersRequired: new FormControl('', [Validators.min(1), Validators.max(100)]),
    dateOfEvent: new FormControl('', [Validators.required, Validators.min(Date.now())]),
    timeOfEvent: new FormControl('', [Validators.required])
  });

}
