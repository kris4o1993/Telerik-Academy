/*globals document*/

var movingShapes = (function () {
    function add(shape) {
        var div = document.createElement('div'),
            parent = document.querySelector('#wrapper');

        applyDivStyles(div);


        if (shape === 'rect') {

        } else {
            div.style.borderRadius = getRandomInt(25, 100) + 'px';
        }

        parent.appendChild(div);
    }

    function applyDivStyles(div) {
        div.innerHTML = '<strong>DIV</strong>';
        div.style.fontSize = getRandomInt(8, 28) + 'px';
        div.style.backgroundColor = getRandomColor();
        div.style.borderWidth = getRandomInt(1, 20) + 'px';
        div.style.borderColor = getRandomColor();
        div.style.borderStyle = 'solid';
        div.style.width = '100px';
        div.style.height = '100px';
        div.style.display = 'inline-block';
        div.style.position = 'absolute';
        div.style.top = getRandomInt(70, 550) + 'px';
        div.style.left = getRandomInt(5, 1100) + 'px';
    }

    // get random int for sizes
    function getRandomInt(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    //get random color in format 'rgb(red,green,blue)'
    function getRandomColor() {
        var red = Math.floor(Math.random() * 256),
            green = Math.floor(Math.random() * 256),
            blue = Math.floor(Math.random() * 256);
        return 'rgb(' + [red, green, blue].join(',') + ')';
    }

    return {
        add: add
    };
}());

//add element with rectangular movement
movingShapes.add("rect");
//add element with ellipse movement
movingShapes.add("ellipse");