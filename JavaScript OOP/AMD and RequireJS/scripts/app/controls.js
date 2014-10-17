define(["jquery", "handlebars"], function($){
    'use strict';
    var ComboBox = function(peopleData) {
        var render = function(template) {
            var $finalElement = $('<div />');
            var compiledTemplate = Handlebars.compile(template);

            for (var i = 0; i < peopleData.length; i++) {
                var person = compiledTemplate(peopleData[i]);
                $(person).appendTo($finalElement);
            }

            $finalElement.children().first().addClass('selected');

            var extendedDown = true;

            $finalElement.on('click', '.person-item', function() {
                var $this = $(this);

                if(extendedDown) {
                    $finalElement.children().addClass('selected');
                    extendedDown = false;
                }
                else {
                    $finalElement.children().removeClass('selected');
                    $this.addClass('selected');
                    extendedDown = true;
                }
            });

            return $finalElement;
        };

        return {
            render: render
        };
    };

    return {
        ComboBox: ComboBox
    };
});