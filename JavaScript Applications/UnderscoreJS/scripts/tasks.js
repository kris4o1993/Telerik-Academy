(function () {
    define(['libs/underscore-min'], function () {

        var tasks = (function () {
            var getStudentsWithFirstNameBeforeLastName = function (students) {
                var result =
                    _.chain(students)
                        .filter(function (student) {
                            return student._lname > student._fname;
                        })
                        .sortBy('_fullName')
                        .reverse()
                        .value();

                return result;
            };

            var getStudentsBetween18And24YearsOld = function (students) {
                var filtered = _.filter(students, function (student) {
                        return student._age >= 18 && student._age <= 24;
                    });

                var result = [];
                filtered.forEach(function(student) {
                    result.push(student._fullName + ': ' + student._age);
                });

                return result;
            };

            var getStudentWithHighestMarks = function (students) {
                var result =
                    _.max(students, function (student) {
                        return student.averageMark();
                    });

                return result;
            };

            var getGroupedAndSortedAnimals = function (animals) {
                var result =
                    _.chain(animals)
                        .sortBy('_legsCount')
                        .groupBy('_species')
                        .value();

                return result;
            };

            var getTotalNumberOfLegs = function (animals) {
                var result = 0;
                _.each(animals, function (animal) {
                    result += animal._legsCount;
                });

                return result;
            };

            var getMostPopularAuthor = function (books) {
                var result =
                    _.chain(books)
                        .groupBy('_author')
                        .max(function (booksCount) {
                            return booksCount.length;
                        })
                        .value()[0]._author;

                return result;
            };

            var getmostCommonFirstAndLastName = function (students) {
                var fname =
                    _.chain(students)
                        .groupBy('_fname')
                        .max(function (student) {
                            return student.length;
                        })
                        .value()[0]._fname;

                var lname =
                    _.chain(students)
                        .groupBy('_lname')
                        .max(function (student) {
                            return student.length;
                        })
                        .value()[0]._lname;

                return {
                    mostCommonFirstName: fname,
                    mostCommonLastName: lname
                }
            };

            return {
                getStudentsWithFirstNameBeforeLastName: getStudentsWithFirstNameBeforeLastName,
                getStudentsBetween18And24YearsOld: getStudentsBetween18And24YearsOld,
                getStudentWithHighestMarks: getStudentWithHighestMarks,
                getGroupedAndSortedAnimals: getGroupedAndSortedAnimals,
                getTotalNumberOfLegs: getTotalNumberOfLegs,
                getMostPopularAuthor: getMostPopularAuthor,
                getmostCommonFirstAndLastName: getmostCommonFirstAndLastName
            };
        }());

        return tasks;
    });
}());