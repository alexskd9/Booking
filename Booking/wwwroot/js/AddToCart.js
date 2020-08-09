$(document).ready(function () {
    $(".AddToCart").click(function () {
        var doc = $(this);
        var eventId = doc.attr("data-eventId");
        var placeId = doc.attr("data-placeId");

        $.ajax({
            url: "/Cart/AddToCart",
            method: "POST",
            data: { "eventId": eventId, "placeId": placeId },
            success: function () {
                alert("დამატებულია კალათაში");
                window.location.reload();
            },
        })
    })
})