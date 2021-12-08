import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-discount',
  templateUrl: './discount.component.html'
})
export class DiscountComponent implements OnInit {
  ans:number
  discountOutput:string
  constructor() { 
    this.discountOutput=""
    this.ans=0
  }
  
  calculateHandler(amtval:string,rateval:string){
    let amountVal=parseInt(amtval) 
    let rateVal=parseInt(rateval)
    this.ans= amountVal* (rateVal/100)
    console.log("Delay of 5 sec...")
    setTimeout(()=>{
      this.discountOutput=`Discount is: ${this.ans} Rs`
      console.log("Discount value printed after 5 sec...")
    },5000)
  }

  ngOnInit(): void {
  
  }
}
