import{Account,Bank,Customer} from './bank-module'

let a=new Account(1001)
let b=new Bank("icici","mumbai")
let c=new Customer(1,"Kunal")

console.log(a,b,c)
console.log({a,b,c})