(function () {
    require.config({
        paths: {
            "jquery": "../libs/jquery-2.1.1",
            "handlebars": "../libs/handlebars-v1.3.0",
            "templateObjects": "peopleDataObjects"
        }
    })

    require(["jquery", "controls", "peopleDataObjects"], function ($, controls, peopleDataObjects) {
        var peopleData = peopleDataObjects;

        var comboBox= controls.ComboBox(peopleData);
        var template = $('#person-template').html();
        var comboBoxHtml= comboBox.render(template);
        $('#contentHolder').html(comboBoxHtml);
    });
}());

