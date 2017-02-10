forEach = Array.prototype.forEach;

(function () {
    var isDnDTypesSupported = true;

    var cancel = function(e) {
        if (e.preventDefault) {
            e.preventDefault();
        }
        if (e.stopPropagation) {
            e.stopPropagation();
        }
    };

    var dragStart = function(e) {
        var index = $(e.target).index();

        index += "";

        var dto = e.dataTransfer;
        try {
            dto.setData("text/plain", index);
        }
        catch (ex) {
            dto.setData("Text", index);
            isDnDTypesSupported = false;
        }
    };

    var dropped = function(e) {
        cancel(e);
        var dto = e.dataTransfer;
        var oldIndex;
        if (isDnDTypesSupported) {
            oldIndex = dto.getData("text/plain");
        }
        else {
            oldIndex = dto.getData("Text");
        }

        var target = $(e.target);
        var newIndex = target.index();
        var droppedItem = $(this).parent().children().eq(oldIndex);

        droppedItem.remove();

        if (newIndex < oldIndex) {
            target.before(droppedItem);
        }
        else {
            target.after(droppedItem);
        }
    };

    var items = document.querySelectorAll("#items-list > li");

    forEach.call(items, function(item) {
        $(item).prop("draggable", true);
        item.addEventListener("dragstart", dragStart, false);
        item.addEventListener("drop", dropped, false);
        item.addEventListener("dragenter", cancel, false);
        item.addEventListener("dragover", cancel, false);

    });
})();