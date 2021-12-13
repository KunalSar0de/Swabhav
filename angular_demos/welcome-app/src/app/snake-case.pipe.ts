import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'snake'
})
export class SnakeCasePipe implements PipeTransform {

  transform(value: string,casing:string=""): string {
    if(casing=="U"){
      value=value.toUpperCase()
    }else if(casing=="L"){
      value=value.toLowerCase()
    }
    let values=value.split(' ')
    return values.join('_')
  }

}
