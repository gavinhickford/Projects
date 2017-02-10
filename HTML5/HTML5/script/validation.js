// validation.js

(function() {
    // Create container for validation rule names
    var ruleNames = [];

    // Fills array with rule names.
    // Looks for all elements with 'validation-message' class
    // and adds the first class (rule name) to the array
    $("[data-rule]").each(function(i, element) {
        var ruleName = element.getAttribute('data-rule');
            if ($.inArray(ruleName, ruleNames) < 0) {
                ruleNames.push(ruleName);
            }
        }
    );

    //First clear the UI by hiding all the validation messages.
    // Then run validation rules on the selected form.
    var validate = function() {
        $(".validation-messages span")
            .addClass("hide");

        document.getElementById("change-email-form")
            .checkValidity();
    };

    // Uses the instance of the input element's
    // ValidityState object to run a validation
    // rule. If the validation rule returns true
    // thenthe rule is broken and the appropriate 
    // validation message is displayed
    var checkRule = function (state, ruleName, ele) {
        if (state[ruleName]) {
            $(ele).next()
                .find("[data-rule='" + ruleName + "']")
                .removeClass("hide");
        }
    };
    
    // Check each input element to determine which
    // element is invalid. Once an invalid state
    // is detected, then loop through the 
    // validation rules to find out which is 
    // broken and therefore which message to display
    var validationFail = function(e) {
        var element = e.srcElement,
            validity = element.validity;

        if (!validity.valid) {
            ruleNames.forEach(function(ruleName) {
                checkRule(validity, ruleName, element);
            });

            e.preventDefault();
        }
    };

    // Attaches validation event handlers to all input
    // elements that are NOT buttons
    $(":input:not(:button)").each(function() {
        this.oninvalid = validationFail;
        this.onblur = validate;
    });

    $("#checkValidation").click(validate);
})();
