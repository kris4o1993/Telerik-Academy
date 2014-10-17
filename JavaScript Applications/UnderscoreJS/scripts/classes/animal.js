(function () {
    define([], function () {

        var Animal = (function () {
            function Animal(name, species, legsCount) {
                this._name = name;
                this._species = species;
                this._legsCount = legsCount;
            }

            return Animal;
        }());

        return Animal;
    });
}());