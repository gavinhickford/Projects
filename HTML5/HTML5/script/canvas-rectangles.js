// canvas-rectangles.js

(function () {
    var canvas3 = document.getElementById("canvas3");
    canvas3.width = 300;
    canvas3.height = 400;
    var context = null;

    if (Modernizr.canvas) {
        context = canvas3.getContext("2d");

        //red box
        context.fillStyle = "rgb(500,0,0)";
        context.fillRect(
            50,   // x coord
            50,   // y coord
            100,  // width
            100); // height

        // blue box with transparency
        context.fillStyle = "rgba(0,0,500, 0.5)";
        context.fillRect(
            80,   // x coord
            80,   // y coord
            100,  // width
            100); // height

        context.clearRect(
            115,   // x coord
            115,   // y coord
            20,  // width
            20); // height

        // green outline
        context.strokeStyle = "rgb(51, 153, 0)";
        context.lineWidth = 6;
        context.strokeRect(115, 115, 20, 20);


    }
})();