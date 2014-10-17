var textarea = document.getElementById('textarea'),
    textColor = document.getElementById('font-color'),
    backgroundColor = document.getElementById('background-color');

textColor.onchange = changeTextColor;
backgroundColor.onchange = changeBackgroundColor;

function changeTextColor() {
    return textarea.style.color = textColor.value;
}

function changeBackgroundColor() {
    return textarea.style.backgroundColor = backgroundColor.value;
}
