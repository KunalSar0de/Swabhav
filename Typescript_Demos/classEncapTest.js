var Account = /** @class */ (function () {
    function Account(_accno, _name, _balance) {
        this._accno = _accno;
        this._name = _name;
        this._balance = _balance;
    }
    Account.prototype.deposit = function (amount) {
        this._balance += amount;
    };
    Object.defineProperty(Account.prototype, "balance", {
        get: function () {
            return this._balance;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Account.prototype, "name", {
        get: function () {
            return this._name;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Account.prototype, "accNum", {
        get: function () {
            return this._accno;
        },
        enumerable: false,
        configurable: true
    });
    return Account;
}());
var acc = new Account(101, "kunal", 2000);
acc.deposit(1500);
console.log(acc.balance);
console.log(acc);
