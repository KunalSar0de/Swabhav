import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'sw-student',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent implements OnInit {

  student=new Student("Kunal Sarode",7.24,new Date())
  constructor() { }

  ngOnInit(): void {
  }

}

export class Student{
  constructor(public fullname:string,public cgpa:number,public doj:Date){

  }
}
