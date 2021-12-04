var Student = /** @class */ (function () {
    function Student(firstName, lastName) {
        this.firstName = firstName;
        this.lastName = lastName;
    }
    Object.defineProperty(Student.prototype, "FullName", {
        get: function () {
            return "".concat(this.firstName, "-").concat(this.lastName);
        },
        set: function (value) {
            var values = value.split(" ");
            console.log(values);
            this.firstName = values[0];
            this.lastName = values[1];
        },
        enumerable: false,
        configurable: true
    });
    return Student;
}());
var s1 = new Student("kunal", "sarode");
console.log(s1);
s1.firstName = "arvind";
s1.lastName = "arvind";
console.log(s1);
console.log(s1.FullName);
var s2 = new Student("jayeh", "rawal");
console.log("After assigning new values using setter:");
s2.FullName = "akshay rawal";
console.log(s2.FullName);
