$(document).ready(function () {
    $("#contactForm").on("submit", function (e) {
        let isValid = true; 
        const requiredFields = ["#firstName", "#lastName", "#email", "#message"]; 

        requiredFields.forEach(function (field) {
            const input = $(field);
            if (!input.val().trim()) {
                isValid = false;
                input.addClass("is-invalid"); 
            } else {
                input.removeClass("is-invalid"); 
            }
        });

        if (!$("#save-info").is(":checked")) {
            e.preventDefault(); 
            alert("Please tick the information box below.");
            return false;
        }

        if (!isValid) {
            e.preventDefault();
            return false;
        }

        e.preventDefault();
        $(this).hide(); 
        $("#message-form").show(); 
    });
});
