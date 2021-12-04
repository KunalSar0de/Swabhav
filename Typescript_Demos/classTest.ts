class Student{
    constructor(public firstName:string,public lastName:string){

    }

    get FullName(){
        return `${this.firstName}-${this.lastName}`
    }
    set FullName(value:string){
        let values:string[]= value.split(" ")
        console.log(values)
        this.firstName=values[0]
        this.lastName=values[1]
    }
}

let s1=new Student("kunal","sarode");
console.log(s1)
s1.firstName="arvind"
s1.lastName="arvind"
console.log(s1)
console.log(s1.FullName)

let s2=new Student("jayeh","rawal");
console.log("After assigning new values using setter:")
s2.FullName="akshay rawal";
console.log(s2.FullName)
