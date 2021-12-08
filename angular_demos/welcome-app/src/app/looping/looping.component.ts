import { Component } from "@angular/core";

@Component({
    selector:'sw-looping',
    templateUrl:'looping.component.html'
})
export class LppoingComponent{

    makeList(size:number){
        return new Array(size);
    }

    getColor(isEven:boolean){
        return isEven?'green':'red'
    }
    constructor(){
        console.log("looping component")
    }
}