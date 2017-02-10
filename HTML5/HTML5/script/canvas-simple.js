// canvas-simple.js

(function() {
    var canvas1 = document.getElementById("canvas1");
    canvas1.width = 300;
    canvas1.height = 400;
    var context = null;

    if (canvas1 && canvas1.getContext) {
        context = canvas1.getContext("2d");
        context.beginPath();
        context.moveTo(75, 50);
        context.lineTo(75, 100);
        context.lineTo(25, 100);
        context.fill();
    }
})();