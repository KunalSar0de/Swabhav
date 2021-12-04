class Account{
    constructor(private _accno:number,private _name:string,private _balance:number){

    }

     deposit(amount){
         this._balance+=amount;
     }

    get balance(){
        return this._balance
    }
    get name(){
        return this._name
    }
    get accNum(){
        return this._accno
    }
}
let acc=new Account(101,"kunal",2000)
acc.deposit(1500)
console.log(acc.balance);
console.log(acc);
