import { Component, OnInit } from '@angular/core';


@Component({
  selector: 'bg-firstpage',
  templateUrl: './firstpage.component.html',
  styleUrls: ['./firstpage.component.css']
})
export class FirstpageComponent {

  turnCount:number
  numberOfBalls:number
  randomNum:number
  balls:Array<Balls>=new Array<Balls>()
  isShown: boolean = false
  isShown2: boolean = false
  gameStatus:boolean=true
  result:string
  
  constructor() { 
    this.randomNum=0   
    this.numberOfBalls=30
    this.turnCount=4
    this.result=""
  }

  NumberOfBalls(e:any) {  
    this.numberOfBalls=e.target.value
    this.RandomNumGenerator(this.numberOfBalls)
  }

  BtnCreater(){ 
    for(var i=1;i<=this.numberOfBalls;i++){
      this.balls.push(new Balls(i,"#ffcb00","ball"+i))
    }
  }

  btnHandler() {
  let element: HTMLElement;
  let element2: HTMLElement;
  element= document.getElementById('container') as HTMLElement
  element2= document.getElementById('container2') as HTMLElement
  this.isShown = ! this.isShown;
  this.BtnCreater()
  }
 
  GameLogic(id:number,$event:MouseEvent)
  {  
      let btn=this.balls.find(x=>x.id==id)
      if(btn&&this.gameStatus==true&&this.turnCount!=0){
        if(btn.id==this.randomNum){
          btn.color="#4BB5EA"
          this.gameStatus=false
          this.LastPage(btn.id,"win")   
        }else if(btn.id<this.randomNum){
          btn.color="#F14747"
        }else if(btn.id>this.randomNum){
          btn.color="#47F16E"
        }
        console.log(this.randomNum)
        this.turnCount--
      }else if(btn&&this.turnCount>=0 && this.gameStatus==false){
        this.LastPage(btn.id,"win")  
      }else if(btn && this.turnCount<=0 && this.gameStatus==true){
        this.LastPage(btn.id,"lost")
      }
      ($event.target as HTMLButtonElement).disabled = true;
  }

  LastPage(id:number,msg:string){
    this.result=`You ${msg}`
  }

  RandomNumGenerator(max:number){
    var min=10
    this.randomNum=Math.floor(Math.random() * (max - min + 2)) + min;
  }
}

export class Balls{
  constructor(public id:number,public color:string,public description:string){

  }
}