/* global document, window, setInterval */

var canvas = document.getElementById('canvas'),
    ctx = canvas.getContext('2d'),
    width = window.innerWidth - 30,
    height = window.innerHeight - 30,
    updateX = 1,
    updateY = 1;

canvas.width = width;
canvas.height = height;



var ball = {
    x: 20,
    y: height / 2 - height / 4,
    radius: 20,
    color: 'red',
    backgroundColor: 'skyblue',
    draw: function () {
        ctx.beginPath();
        ctx.arc(this.x, this.y, this.radius, 0, 2 * Math.PI);
        ctx.fillStyle = this.color;
        ctx.fill();
        ctx.stroke();
    }
};

function clearCanvas() {
    ctx.clearRect(0, 0, width, height);
}

function update() {
    clearCanvas();
    ball.draw();

    if (ball.x < ball.radius || ball.x > width - ball.radius) {
        updateX = -updateX;
    }
    if (ball.y < ball.radius || ball.y > height - ball.radius) {
        updateY = -updateY;
    }

    ball.x += updateX;
    ball.y += updateY;
}


setInterval(update, 60 / 1000);