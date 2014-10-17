(function () {
    'use strict';

    require(['classes/student', 'classes/book', 'classes/animal', 'tasks'], function (Student, Book, Animal, tasks) {

        var students = [
                new Student('George', 'Peshov', 19, [5, 6, 4, 3]),
                new Student('Doncho', 'Mitkov', 18, [6, 6, 6, 2, 3]),
                new Student('Ivaylo', 'Kendov', 21, [6, 2, 3, 4, 4]),
                new Student('Bonboncho', 'Minkov', 22, [5, 6, 4, 2]),
                new Student('Pavel', 'Kenov', 26, [6, 6, 5, 6]),
                new Student('Pavel', 'Kolev', 19, [2, 3, 2, 4]),
                new Student('Pavel', 'Kostov', 16, [5, 6, 4, 4, 5]),
                new Student('Pesho', 'Peshov', 17, [4, 3, 5, 6])
            ];

            var animals = [
                new Animal("Kitten of Doom", "mammal", 4),
                new Animal("Centipede George", "insect", 100),
                new Animal("Centipede WW2 survivor", "insect", 100),
                new Animal("Human", "mammal", 2),
                new Animal("Tirozaur", "mammal", 8),
                new Animal("Orc", "mammal", 2),
                new Animal("Prairie dog", "mammal", 4),
                new Animal("Angry Chernobyl Bird", "bird", 6),
                new Animal("Pipiruda", "insect", 6),
                new Animal("Spinderman", "insect", 8),
                new Animal("Ko?Ne!", "mammal", 4),
                new Animal("Teenage Mutant Ninja Bird", "bird", 4)
            ];

            var books = [
                new Book("Parry Hotter", "J. K. Rowling"),
                new Book("RITOPLS", "J. R. R. Tolkien"),
                new Book("Two Girls, One Cup", "S. Nakov"),
                new Book("Game of Trolls", "G. Martin"),
                new Book("Habbit", "J. R. R. Tolkien"),
                new Book("DOTA2ISFORNOOBTSL2P", "J. R. R. Tolkien"),
                new Book("Me, Myself and I", "Az"),
                new Book("All Quiet on the Western Front", "S. Nakov")
            ];

            //01. Write a method that from a given array of students finds all students
            //whose first name is before its last name alphabetically. Print the students
            //in descending order by full name. Use Underscore.js

            var studentsWithFirstNameBeforeLastName = tasks.getStudentsWithFirstNameBeforeLastName(students);
            console.log('--Students whose first name is before their last name sorted in descending order--');
            console.log(studentsWithFirstNameBeforeLastName);


            //02. Write function that finds the first name and last name of all students
            //with age between 18 and 24. Use Underscore.js

            var studentsBetween18And24YearsOld = tasks.getStudentsBetween18And24YearsOld(students);
            console.log('--First and last name of students with age between 18 and 24--');
            console.log(studentsBetween18And24YearsOld);


            //03. Write a function that by a given array of students finds the student with highest marks

            var studentWithHighestMarks = tasks.getStudentWithHighestMarks(students);
            console.log('--Student with highest mark--');
            console.log(studentWithHighestMarks);


            //04. Write a function that by a given array of animals, groups them by species and sorts them by number of legs

            var animalsGroupedBySpeciesAndSortedByLegs = tasks.getGroupedAndSortedAnimals(animals);
            console.log('--Animals grouped by species and sorted by number of legs--');
            console.log(animalsGroupedBySpeciesAndSortedByLegs);


            //05. By a given array of animals, find the total number of legs

            var totalNumberOfLegs = tasks.getTotalNumberOfLegs(animals);
            console.log('--Total number of animals legs--');
            console.log(totalNumberOfLegs);


            //06. By a given collection of books, find the most popular author (the author with the highest number of books)

            var mostPopularAuthor = tasks.getMostPopularAuthor(books);
            console.log('--Most popular author (the author with the highest number of books)--');
            console.log(mostPopularAuthor);


            //07. By an array of people find the most common first and last name. Use underscore.

            var mostCommonNames = tasks.getmostCommonFirstAndLastName(students);
            console.log('--Most common first name of all the students--');
            console.log(mostCommonNames.mostCommonFirstName);
            console.log('--Most common last name of all the students--');
            console.log(mostCommonNames.mostCommonLastName);
        });
}());