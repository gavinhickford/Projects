// select.js

function selectById(e) {
    var divById = $("#SpecificDiv");
    toggleClass(e.checked, divById);
}

function selectByTag(e) {
    var divsByTag = $("div");
    toggleClass(e.checked, divsByTag);
}

function selectByClass(e) {
    var divByClass = $(".div-class");
    toggleClass(e.checked, divByClass);
}

function selectByAttribute(e) {
    var divsByArribute = $("div[title='This is the title text']");
    toggleClass(e.checked, divsByArribute);
}

function selectByContains(e) {
    var divContains = $("div:contains('umbrella')");
    toggleClass(e.checked, divContains);
}

function selectByStartsWith(e) {
    var divStartsWith = $("div[title^='Starts']");
    toggleClass(e.checked, divStartsWith);
}

function selectByEndsWith(e) {
    var divEndsWith = $("div[title$='Starts']");
    toggleClass(e.checked, divEndsWith);
}

function selectByTitleContains(e) {
    var divContains = $("div[title*='Starts']");
    toggleClass(e.checked, divContains);
}

function selectInputs(e) {
    var inputs = $(":input");
    toggleClass(e.checked, inputs);
}

function toggleClass(checked, element) {
    if (checked) {
        element.addClass("selected");
    } else {
        element.removeClass("selected");
    }
}
