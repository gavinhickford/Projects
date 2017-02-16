// interact.js

function divIterate() {
    $(".div-select").each(function(index, element) {
        alert(index + " = " + $(element).text());
    });
}

function toggleClass() {
    $(".div-select").toggleClass("div-toggle");
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

function appendText() {
    $(".add-text").append('<span class="appended-text">Appended Text</span>');
}

function prependText() {
    $(".add-text").prepend('<span class="prepended-text">Prepended text</span>');
}

function removeText() {
    $(".add-text .appended-text").remove();
    $(".add-text .prepended-text").remove();
}
