import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'sw-number-api',
  templateUrl: './number-api.component.html',
  styleUrls: ['./number-api.component.css']
})
export class NumberApiComponent implements OnInit {
public number:string="64";
public quote:any=null
private url:string

constructor(private http:HttpClient) {
this.url='http://numbersapi.com/'   
}

getData(numberFromUser:string) {
  this.number=numberFromUser;
  console.log(this.url+this.number+'?json')
  console.log("link created")
  this.ngOnInit
  return this.http.get(this.url+this.number+'?json');

  
}
  ngOnInit() {
    this.getData(this.number).subscribe((d:any)=>{
          console.log("data arrived");
          console.warn(d)
          this.quote=d['text']     
      })
  }
}
