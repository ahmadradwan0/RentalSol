
    // Wait for the DOM to be ready
    $(document).ready(function () {
        // Get the input element for the Name field
        var nameInput = $('#Customer_Name');

    // Get the validation message element
    var errorMessage = $('.error-message');

    // Attach an event handler to the input element for keyup (when the user starts typing)
    nameInput.on('keyup', function () {
        // Hide the validation message when the user starts typing
        errorMessage.hide();
        });
    });

