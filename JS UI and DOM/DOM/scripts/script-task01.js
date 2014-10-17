function usingQuerySelector() {
    var result = document.querySelectorAll('div > div').length;
    document.getElementById('resultQuery').value = result;
}

function usingTagName() {
    var allDivs = document.getElementsByTagName('div'),
        counter = 0;
    
    for (var i = 0, numberOfDivs = allDivs.length; i < numberOfDivs; i += 1) {
        if (allDivs[i].parentNode.tagName === 'DIV') {
            counter++;
        }
    }
    
    document.getElementById('resultTagName').value = counter;
}