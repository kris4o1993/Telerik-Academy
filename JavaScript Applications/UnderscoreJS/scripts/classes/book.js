(function () {
    define([], function () {

        var Book = (function () {
            function Book(title, author) {
                this._title = title;
                this._author = author;
            }

            return Book;
        }());

        return Book;
    });
}());