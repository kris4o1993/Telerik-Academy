var specialConsole = (function () {
    function write(input) {
        var fancyConsole = document.querySelector('#fancyConsole');

        var command = input.value.substring(input.value.indexOf('.') + 1, input.value.length - 2),
            commandAction = command.substring(0, command.indexOf('(')),
            stringContent = command.substring(command.indexOf('(') + 1),
            arrayOfStrings = stringContent.substring(stringContent.search('", "') + 3).split(', '),
            unformattedString = stringContent.substring(1, stringContent.search('", "'));

        //uncomment to see what is logged
        //console.log(command);
        //console.log(commandAction);
        //console.log(stringContent);
        //console.log(unformattedString);
        //console.log(arrayOfStrings);


        for (var i = 0; i < arrayOfStrings.length; i++) {
            arrayOfStrings[i] = arrayOfStrings[i].substring(1, arrayOfStrings[i].length - 1); //removing double quotes
        }

        //console.log(arrayOfStrings);
        var stringFragment = '';
        for (i = 0; i < unformattedString.length; i += 1) {
            if (unformattedString[i] === '{' && unformattedString[i + 2] === '}') {
                stringFragment += arrayOfStrings[unformattedString[i + 1]];
                i += 2;
            } else {
                stringFragment += unformattedString[i];
            }
        }

        //console.log(stringFragment);

        var newLine = document.createElement('p');

        if (commandAction === 'writeLine') {
            newLine.innerHTML = stringFragment;
        } else if (commandAction === 'writeError') {
            newLine.innerHTML = 'ERROR: ' + stringFragment;
            newLine.style.color = 'red';
        } else if (commandAction === 'writeWarning') {
            newLine.innerHTML = 'WARNING: ' + stringFragment;
            newLine.style.color = 'orange';
        } else {
            newLine.innerHTML = 'EXCEPTION!!! INCORRECT SYNTAX!';
            newLine.style.color = 'green';
        }

        fancyConsole.appendChild(newLine);

    }

    return {
        write: write
    };
}());


//example commands
//specialConsole.writeLine("Message: hello");
//specialConsole.writeLine("Message: {0}", "hello");
//specialConsole.writeError("Error: {0}", "Something happened");
//specialConsole.writeWarning("Warning: {0}", "A warning");
//specialConsole.writeLine("Message: {0} My name is {1} {2}. {0}", "Hello!", "Joro", "Peshov");
//specialConsole.writeNothing("Message: {0} My name is {1} {2}. {0}", "Hello!", "Joro", "Peshov");