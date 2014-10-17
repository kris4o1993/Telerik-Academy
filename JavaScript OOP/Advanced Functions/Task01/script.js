/*globals document*/

var domModule = (function () {
    var buffer = [];

    function appendChild(element, parentElement) {
        var parent = document.querySelector(parentElement);
        parent.appendChild(element);
    }

    function removeChild(parentElement, elementForRemoval) {
        var parent = document.querySelector(parentElement),
            child = document.querySelector(elementForRemoval);

        parent.removeChild(child);
    }

    function addHandler(element, type, action) {
        var elements = document.querySelectorAll(element);
        for (var i = 0; i < elements.length; i += 1) {
            elements[i].addEventListener(type, action);
        }
    }

    function appendToBuffer(parentElement, elementToAppend) {


    }

    return {
        appendChild: appendChild,
        removeChild: removeChild,
        addHandler: addHandler,
        appendToBuffer: appendToBuffer
    };
}());