import { AfterViewInit, Component, ElementRef, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { Router } from '@angular/router';

import  * as L from 'leaflet';
import { reduce } from 'rxjs';
import { Pitch } from 'src/app/_models/pitch';
import { PitchService } from 'src/app/_services/pitch.service';


@Component({
  selector: 'app-map-view',
  templateUrl: './map-view.component.html',
  styleUrls: ['./map-view.component.css']
})
export class MapViewComponent implements OnInit, AfterViewInit {

  constructor(private router: Router, private pitchService: PitchService) {}

  @Output()
  pitchSelected = new EventEmitter<Pitch>();
 
  
  @ViewChild('mapcontain')
  private mapContainer!: ElementRef<HTMLElement>;

  private map!: L.Map;


  ngAfterViewInit(): void {
    this.map = new L.Map(this.mapContainer.nativeElement, {zoomControl:false});
    L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(this.map);
    this.map.setView([50.8702, 20.6302], 14.0);

    this.pitchService.getPitches().subscribe((pitches) => {
      this.addPitches(pitches);
    })
  }
/*
  onPinClicked(pitch: Pitch) {
    this.router.navigate(['pitch', 'detail', pitch.id])    
  }
*/

  onPitchClicked(pitch: Pitch) {
    this.pitchSelected.emit(pitch);
  }


  ngOnInit(): void {
   
  }


  addPitches(pitches: Pitch[]) {
    const icon = L.icon(
      {
        iconUrl: 'assets/location-pin-red.png',
        iconSize: [64,64],
        iconAnchor:   [32, 64], // point of the icon which will correspond to marker's location
        
      });

    let markers: L.Marker[] = pitches.map(pitch => {
      let marker = L.marker([pitch.coordLat, pitch.coordLon], {icon: icon,})
      marker.addEventListener("click", () => { this.onPitchClicked(pitch); });
      return marker;
    })
    markers.forEach(marker => marker.addTo(this.map));
  }

}
