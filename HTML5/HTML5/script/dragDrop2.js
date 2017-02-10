// dragDrop2.js
forEach = Array.prototype.forEach;

(function () {
    var sourceContainerId = "";
    var dragStart = function (e) {
        try {
            e.dataTransfer
                .setData("text/plain",
                    e.target.id);
        }
        catch (ex) {
            e.dataTransfer
                .setData("Text", e.target.id);
        }

        sourceContainerId = this.parentElement.id;
    };

    var cancel = function (e) {
        if (e.preventDefault) {
            e.preventDefault();
        }

        if (e.stopPropagation) {
            e.stopPropagation();
        }

        return false;
    };

    var dropped = function (e) {
        if (this.id !== sourceContainerId) {
            cancel(e);

            var id;

            try {
                id = e.dataTransfer.getData("text/plain");
            } catch (ex) {
                id = e.dataTransfer("Text");
            }

            e.target.appendChild(
                document.querySelector("#" + id));
        }
    };

    var selector = "[data-role='drag-drop-container']";
    var dc = document.querySelectorAll(selector);

    forEach.call(dc,
        function(c) {
            c.addEventListener("drop", dropped, false);
            c.addEventListener("dragenter", cancel, false);
            c.addEventListener("dragover", cancel, false);
        });

    selector = "[draggable='true']";
    var ds = document.querySelectorAll(selector);

    forEach.call(ds,
        function(source) {
            source.addEventListener("dragstart", dragStart, false);
        });
})();