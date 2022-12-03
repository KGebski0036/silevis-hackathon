import { AfterViewInit, Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';

import  * as L from 'leaflet';
import { Pitch } from 'src/app/_models/pitch';
import { PitchService } from 'src/app/_services/pitch.service';


@Component({
  selector: 'app-map-view',
  templateUrl: './map-view.component.html',
  styleUrls: ['./map-view.component.css']
})
export class MapViewComponent implements OnInit, AfterViewInit {

  constructor(private pitchService: PitchService) {}

  pitches: Pitch[] = this.pitchService.loadedPitches;

  
  @ViewChild('mapcontain')
  private mapContainer!: ElementRef<HTMLElement>;




  private map!: L.Map;


  ngAfterViewInit(): void {
    
    this.map = new L.Map(this.mapContainer.nativeElement);

    L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(this.map);

    this.map.setView([50.8702, 20.6302], 14.0)

    const icon = L.icon(
      {
        iconUrl: 'assets/location-pin-red.png',
        iconSize: [64,64],
        iconAnchor:   [32, 64], // point of the icon which will correspond to marker's location
        
      });

    let markers: L.Marker[] = this.pitches.map(pin => {
      
      let marker = L.marker([pin.coordLat, pin.coordLon], {icon: icon, })
      marker.addEventListener("click", () => { this.onPinClicked(pin); });
      return marker;
    })
      
    
    markers.forEach(marker => marker.addTo(this.map));


  }

  onPinClicked(pitch: Pitch) {

  }


  ngOnInit(): void {
    this.pitchService.getPitches().subscribe()
  }

}
