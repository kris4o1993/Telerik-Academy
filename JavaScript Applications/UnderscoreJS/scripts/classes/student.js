(function () {
    define([], function () {

        var Student = (function () {
            function Student(fname, lname, age, marks) {
                this._fname = fname;
                this._lname = lname;
                this._age = age;
                this._marks = marks;
                this._fullName = this._fname + ' ' + this._lname;
            }

            Student.prototype.averageMark = function () {
                var sum = this._marks.reduce(function (a, b) {
                    return a + b
                });
                return sum / this._marks.length;
            };

            Student.prototype.getName = function () {
                return this._fullName;
            };

            return Student;
        }());

        return Student;
    });
}());