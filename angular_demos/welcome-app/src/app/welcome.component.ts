import { Component, OnInit } from '@angular/core';
import { asyncScheduler, interval, map, observable, Observable, observeOn } from 'rxjs';

@Component({
  selector: 'sw-welcome',
  templateUrl: './welcome.component.html'
})
export class WelcomeComponent  {

//   goalDetails:Observable<Goal>

//   constructor(){
//     this.goalDetails=interval(3000)
//     .pipe(map(n=>{
//       const t=new Date()
//       return new Goal(n+1,new Date().toString())
//     }))
//   }

//   getDataAsync1():Observable<number>{
//     const observable=new Observable<number>((observer)=>{
//       observer.next(10)
//       observer.next(20)
//       observer.next(30)
//       observer.complete()
//     })
//     .pipe(observeOn(asyncScheduler))

//     return observable
//   }

//   getDataAsync2():Observable<number>{
//     const publisher=interval(3000)
//     return publisher
//   }

//   getDataAsync3():Observable<any>{
//       return interval(3000)
//       .pipe(map(n=>{
//         const t=new Date()
//         return {"time":t,"counter":n}
//       }))

//   }
//   ngOnInit(){
//   //  this.getDataAsync1()
//   //  .subscribe(d=>{
//   //    console.log("data arrived");
//   //    console.log(d)
//   //  })
//   //  console.log("end of onInit")

//   // this.getDataAsync2()
//   // .subscribe((d)=>{
//   //   console.log("data arrives")
//   //   console.log(d)
//   // })
//   // console.log("end of onInit")
    
//   // this.getDataAsync3()
//   //    .subscribe(d=>{
//   //      console.log("data arrived")
//   //      console.log(d.counter)
//   //      console.log(d.time)
//   //     })

//   this.goalDetails.subscribe(d=>{
//     console.log("data arrives")
//     console.log(d.goalCount)
//     console.log(d.time)
//   })
//      console.log("end of onInit")
//   }
 }


// export class Goal{
//   constructor(public goalCount:number,public time:string) {     
//   }
// }