function createDivs() {
    //clear content
    var container = document.getElementById('container'),
        containerWidth = container.offsetWidth,
        containerHeight = container.offsetHeight;

    container.innerHTML = "";

    var divFragment = document.createDocumentFragment(),
        numberOfDivs = document.getElementById('numberOfDivs').value | 0;

    //creating the elements
    for (var i = 0; i < numberOfDivs; i++) {

        //creating and filling divs with text
        var item = document.createElement('div');
        item.innerHTML = '<strong>' +
            'Div #' + (i + 1) +
            '</strong>';

        //shapes, colors and positions
        //note top and left offets have -30 , otherwise they go outside the container
        var width = getRandomInt(20, 100),
            height = getRandomInt(20, 100),
            className = 'inner-div',
            position = 'absolute',
            backgroundColor = getRandomColor(),
            fontColor = getRandomColor(),
            topOffset = getRandomInt(0, containerHeight - height - 30),
            leftOffset = getRandomInt(0, containerWidth - width - 30),
            borderRadius = getRandomInt(0, 100),
            borderColor = getRandomColor(),
            borderWidth = getRandomInt(1, 20);


        item.className = className;
        item.style.position = position;
        item.style.width = width.toString() + 'px';
        item.style.height = height.toString() + 'px';
        item.style.backgroundColor = backgroundColor;
        item.style.color = fontColor;
        item.style.top = topOffset.toString() + 'px';
        item.style.left = leftOffset.toString() + 'px';
        item.style.borderRadius = borderRadius.toString() + '%';
        item.style.border = borderWidth.toString() + 'px solid ' + borderColor;

        divFragment.appendChild(item);
    }

    //add all in the DOM
    container.appendChild(divFragment);
}

//get random int for width/height
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