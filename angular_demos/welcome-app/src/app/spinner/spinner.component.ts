import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-spinner',
  templateUrl: './spinner.component.html',
})
export class SpinnerComponent implements OnInit {
  imageUrl="assets/loading.gif"
  hideImage=true
  btnTxt="show"
  check="show-image"
 
  handleButtonToggle(e:any){
    console.log(e.target)
    this.hideImage=!this.hideImage
    if(this.btnTxt=="show"){
      this.btnTxt="hide"
      return
    }      
    this.btnTxt="show"   
  }

  handleCheckToggle(e:any){
    this.hideImage=!this.hideImage
    console.log(e.target)
    if(this.check=="show-image"){
      this.check="hide-image"
      return
    }      
    this.check="show-image"  
  }

  constructor() { }

  ngOnInit(): void {
  }

}
