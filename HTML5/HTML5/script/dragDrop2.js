// dragDrop2.js
forEach = Array.prototype.forEach;

(function () {
    var sourceContainerId = "";

    var cancel = function (e) {
        if (e.preventDefault) {
            e.preventDefault();
        }

        if (e.stopPropagation) {
            e.stopPropagation();
        }

        return false;
    };

    var dragStart = function (e) {
        $(this).addClass("drag");
        var dto = e.dataTransfer;

        try {
            dto.setData("text/plain", e.target.id);
        }
        catch (ex) {
            dto.setData("Text", e.target.id);
        }

        sourceContainerId = this.parentElement.id;
    };

    var dragOver = function (e) {
        cancel(e);
        $(this).addClass("over");
    };

    var dragLeave = function (e) {
        $(this).removeClass("over");
    };

    var dragEnd = function (e) {
        $(".drag").removeClass("drag");
        $(".over").removeClass("over");
    };
    
    var dropped = function (e) {
            cancel(e);

            var id = null;
            var dto = e.dataTransfer;
            var dropped = null;

            if (dto.types.length > 0) {
                if (dto.types[0] === "Text") {
                    id = dto.getData("Text");
                } 
                else {
                    id = dto.getData("text/plain");
                }
            }

            if (id !== null) {
                dropped = document.querySelector("#" + id);
            }

            if (this.id !== sourceContainerId) {
                e.target.appendChild(dropped);
                $(dropped).removeClass("drag");
            }

        $(this).removeClass("over");
    };

    var selector = "[data-role='drag-drop-container']";
    var dc = document.querySelectorAll(selector);

    forEach.call(dc,
        function(c) {
            c.addEventListener("drop", dropped, false);
            c.addEventListener("dragenter", cancel, false);
            c.addEventListener("dragover", dragOver, false);
            c.addEventListener("dragleave", dragLeave, false);
        });

    selector = "[draggable='true']";
    var ds = document.querySelectorAll(selector);

    forEach.call(ds,
        function(source) {
            source.addEventListener("dragstart", dragStart, false);
            source.addEventListener("dragend", dragEnd, false);
        });
})();