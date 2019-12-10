$("form").submit(function (e) {
    $.post("/Post/Create", { Content: $("#contentInput").val(), ImagePath: $("#fileInput").val(), UserId: $("#userId").val() });

    e.preventDefault();
    return false;
});