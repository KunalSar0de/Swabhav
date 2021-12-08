import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-greet',
  templateUrl: './greet.component.html'
})
export class GreetComponent implements OnInit {

  greetingMsg:string
  constructor() { 
    this.greetingMsg=""
  }
  handleGreet(userName:string){
    let hrs=new Date().getHours()
    var greet=(hrs<12)?"Morning":(hrs<18)?"Afternoon":"Evening"
    this.greetingMsg= `Hello ${userName} , Good ${greet}`
  }
  ngOnInit(): void {
  }

}
