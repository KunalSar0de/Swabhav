import { NgStyle } from '@angular/common';
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'cgpaToBandColor'
})
export class RowcolorPipe implements PipeTransform {

  //[ngStyle]="{'background-color': (student.cgpa>8) ? '#53F177' 
            //:  (student.cgpa>7&&student.cgpa<7.9)?'#61A6F4':'#F46161'}"
  transform(value: number):number{
    console.log("inside pipe: ");
    if(value>8){     
      console.log("color=green")
    }else if(value>=6.5&&value<=7.9){
      console.log("color=blue")
    }else {
      console.log("color=red")
    }
    return value
  }

}
