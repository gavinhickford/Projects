// canvas-arcs.js

(function () {
    var canvas4 = document.getElementById("canvas4");
    canvas4.width = 350;
    canvas4.height = 400;
    var context = null;

    if (Modernizr.canvas) {
        context = canvas4.getContext("2d");
        var g1 = context.createRadialGradient(
            160,        // x coord of grad start
            120,        // y coord of grad start 
            0,          // radius of start circle
            320,        // x coord of grad end 
            220,        // y coord of grad end
            300);       // radius of end circle
        g1.addColorStop(0, "#ffffff");
        g1.addColorStop(1, "#999999");

        // base circle
        context.lineWidth = 0;
        context.strokeStyle = "#000000";
        context.fillStyle = g1;
        context.beginPath();
        context.arc(
            180,          // x coord of arc start
            180,          // y coord of arc start 
            160,          // radius
            0,            // start angle  
            Math.PI * 2,  // end angle
            true);        // anticlockwise 
        context.fill();

        var g2 = context.createRadialGradient(
            360,        // x coord of grad start
            320,        // y coord of grad start 
            0,          // radius of start circle
            260,        // x coord of grad end 
            220,        // y coord of grad end
            200);       // radius of end circle
        g1.addColorStop(0, "#ffffff");
        g1.addColorStop(1, "#999999");

        // inner circle
        context.fillStyle = g2;
        context.beginPath();
        context.arc(
            180,          // x coord of arc start
            180,          // y coord of arc start 
            130,          // radius
            0,            // start angle  
            Math.PI * 2,  // end angle
            true);        // anticlockwise 
        context.fill();

        context.fillStyle = "#ffffff";
        context.font = "280px Arial";
        context.fillText("C", 80, 280);

    }
})();