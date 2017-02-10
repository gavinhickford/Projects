// bootstrap-validation.js
"use strict";

(function() {
    var ValidationUtility = function() {
        var elements = $("[data-role='validate']");
        var elementCount = 0;


        elements.popover({
            placement: "top"
        });

        elements.on("invalid",
            function() {
                if (elementCount === 0) {
                    $("#" + this.id).popover("show");
                    elementCount++;
                }
            });

        elements.on("blur",
            function() {
                $(this).popover("hide");
            });

        var validate = function(formSelector) {
            elementCount = 0;
            if (formSelector.indexOf("#") === -1) {
                formSelector = "#" + formSelector;
            }

            return $(formSelector)[0].checkValidity();
        };

        return {
            validate: validate
        };
    };

    var validator = new ValidationUtility();
    var selector = "[data-role='trigger-validation']";

    $(selector).click(function() {
        if (validator.validate("email-form")) {
            $("#msg").text("Valid");
        } else {
            $("#msg").text("Invalid");
        }
    });
})();
