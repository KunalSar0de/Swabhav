"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Account = exports.Customer = exports.Bank = void 0;
var Bank = /** @class */ (function () {
    function Bank(name, location) {
        this.name = name;
        this.location = location;
    }
    return Bank;
}());
exports.Bank = Bank;
var Customer = /** @class */ (function () {
    function Customer(cid, firstName) {
        this.cid = cid;
        this.firstName = firstName;
    }
    return Customer;
}());
exports.Customer = Customer;
var Account = /** @class */ (function () {
    function Account(balance) {
        this.balance = balance;
    }
    return Account;
}());
exports.Account = Account;
