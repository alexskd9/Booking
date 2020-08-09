$(document).ready(function () {
    $(".removeTicket").click(function () {
        var element = $(this);
        var CartDetailsId = element.data("cartdetailsid");
        var PlaceId = element.data("placeid");
        $.ajax({
            url: "/Cart/RemoveFromCart",
            method: "post",
            data: { "cartDetailsId": CartDetailsId, "placeId": PlaceId },
            success: function (response) {
                element.parent().parent().hide;
                window.location.reload();
            }
        })
    })
})