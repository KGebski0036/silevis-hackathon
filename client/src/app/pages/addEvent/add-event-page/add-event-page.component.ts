import { HttpBackend } from '@angular/common/http';
import { isNgTemplate } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrModule, ToastrService } from 'ngx-toastr';
import { GameEvent } from 'src/app/_models/event';
import { Pitch } from 'src/app/_models/pitch';
import { EventService } from 'src/app/_services/event.service';
import { PitchService } from 'src/app/_services/pitch.service';



@Component({
  selector: 'app-add-event-page',
  templateUrl: './add-event-page.component.html',
  styleUrls: ['./add-event-page.component.css']
})
export class AddEventPageComponent implements OnInit {

  constructor(private toastr:ToastrService, private router:Router, private route: ActivatedRoute, private service: EventService, private pitchService: PitchService) { }

  pitche?: Pitch;


  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      let param = params.get('id');
      if (param == null) return;
      let id = parseInt(param);
      debugger
      if (isNaN(id)) return;
      this.pitchService.getPitchById(id).subscribe(pitch => {
        this.pitche = pitch
        
      });
    })
  }

  eventForm = new FormGroup({

    description: new FormControl('', [Validators.minLength(10), Validators.maxLength(1000)]),
    playersRequired: new FormControl(0, [Validators.required, Validators.min(1), Validators.max(100)]),
    /*dateOfEvent: new FormControl('', [Validators.required, Validators.min(Date.now())]),
    timeOfEvent: new FormControl('', [Validators.required])
    */
  });

  onSubmit() {
    let ev: GameEvent = {pitchId: this.pitche!.id};


    if (this.eventForm.value.description)
    ev.description = this.eventForm.value.description;

    if (this.eventForm.value.playersRequired)
    ev.maxPlayers = this.eventForm.value.playersRequired;

    this.service.addEvent(ev).subscribe({
      next: () => {
        this.toastr.success("Added successfully!");
        this.router.navigateByUrl('/');
      },
      error: () => {this.toastr.error("Failed to add.")}
    });
    
  }

}
