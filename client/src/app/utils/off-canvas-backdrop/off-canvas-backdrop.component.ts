import { Component, ElementRef, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-off-canvas-backdrop',
  template: '',
  styleUrls: ['./off-canvas-backdrop.component.css']
})
export class OffCanvasBackdropComponent implements OnInit{

  constructor(private backdrop: ElementRef<HTMLDivElement>) {

  }
  ngOnInit(): void {
    this.backdrop.nativeElement.onclick = () => { this.dismiss.emit(); };
  }

  @Output()
  dismiss = new EventEmitter();


}
