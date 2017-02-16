// interact.js

function divIterate() {
    $(".div-select").each(function(index, element) {
        alert(index + " = " + $(element).text());
    });
}

function divUpdateDirectly() {
    $(".div-select").each(function (index) {
        this.title = "Updated directly. Index = " + index;
    });
}

function divUpdateWithAttributes() {
    $(".div-select").each(function (index) {
        $(this).attr("title", "Updated with attr. Index = " + index);
    });
}

function divUpdateMultipleAttributes() {
    $(".div-select").each(function (index) {
        var text = "Updated multiple attributes. Index = " + index;
        $(this).attr(
            {
                title: text,
                style: "border: 2px solid black;"
            }
        );
    });
}