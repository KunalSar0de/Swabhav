import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-welcome',
  templateUrl: './welcome.component.html'
})
export class WelcomeComponent implements OnInit{
  //var decleration
  message:string
  today:string
  randomVal:number
  //constructor delcleration
  constructor(){
    console.log("constructor created..")
    this.message="Welcome to swabhav tech"
    this.today=new Date().toString()
    this.randomVal=Math.random()
  }

  ngOnInit(){
    console.log("component and view loaded successfully")
    setTimeout(()=>{
      this.message="welcome to DataBinding after 3 sec"
      this.today=new Date().toString()
    },3000)
  }
}
