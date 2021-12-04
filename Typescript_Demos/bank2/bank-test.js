"use strict";
//import Bank,{Account,Customer} from './bank-module'
//let obj=new Bank("hdfc","kurla")
Object.defineProperty(exports, "__esModule", { value: true });
var b = require("./bank-module");
var a = new b.Account(100);
var c = new b.Customer(1, "kunal");
console.log(a, c);
