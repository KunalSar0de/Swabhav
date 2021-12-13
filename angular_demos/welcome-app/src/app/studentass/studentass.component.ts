import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-studentass',
  templateUrl: './studentass.component.html',
  styleUrls: ['./studentass.component.css']
})
export class StudentassComponent implements OnInit {
  students:Array<Student>=new Array<Student>()
  
  InitiateEntries(){
    console.log("Display button clicked..")
    this.students[0]=new Student("kunal saorode",7.24,new Date())
    this.students[1]=new Student("sagar avhad",8.76,new Date())
    this.students[2]=new Student("ravi shastri",6.22,new Date())
    this.students[3]=new Student("nikhil patel",5.36,new Date())
    this.students[4]=new Student("nasti jawal",9.88,new Date())
  }

  fullname:string="FullName"
  cgpa:string="CGPA"
  doj:string="DOJ"

  constructor() { 
    
  }

  ngOnInit(): void {
  }

}

export class Student{
  constructor(public fullname:string,public cgpa:number,public doj:Date){

  }
}
