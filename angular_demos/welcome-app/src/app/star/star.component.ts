import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';


@Component({
  selector: 'sw-star',
  templateUrl: './star.component.html',
  styleUrls: ['./star.component.css']
})
export class StarComponent implements OnInit {

@Input()
rating:number=1;

@Output()
ratingClick:EventEmitter<string> =new EventEmitter<string>();

  constructor() {
    console.log(this.rating,"in constructor")
   }

  ngOnInit(): void {
    console.log(this.rating,"in oninit")
  }

  clickHandler(){
    this.ratingClick.emit(`somebody clicked on rating ${this.rating}`)
  }

}
