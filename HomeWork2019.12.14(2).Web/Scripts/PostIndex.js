$("i").on("click", function (e) {
    var id = $(this).attr("id");
    var userId = $("#" + id + " #userId").data("userId");
    var ownerId = $("#" + id + " #ownerId").data("ownerId");
    if(userId != ownerId)
    {
        var count = parseInt($(this).data("count")) + 1;
        $.post("/Post/Index",
            {
                postId: id,
                likeCount: count
            });

        $("#" + id + " span").html(count);
    }
});