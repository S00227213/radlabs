$(document).ready(function () {
   
    $("#createNewButton").on("click", function (e) {
        e.preventDefault(); 

        // Load the content for the modal
        $("#studentCreateModalContent").load("/Students/_Create", function () {
            // Show the modal after content is loaded
            $("#studentCreateModal").modal('show');
        });
    });
});
