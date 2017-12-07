$("#button").click(function () {
    var string = "/search?search=" + $("#search").val(); 
    $.ajax(
        {
            type: "GET",
            dataType: "json",
            url: string,
            success: function (data) { display(data); },
            error: function () { alert("Search failed. Try again later."); }
        }
    );
});


function display(data) {
    $("#images").empty();
    $.each(data, function (i, video) {
        $("#images").append(
            "<div class='video'>"
            + "<video loop autoplay>"
            + "<source src='"
            + video["image"]
            + "' type='video/mp4'>"
            + "</video>"
            + "</div>"
        );
    });
}


$("#playpause").click(function () {
    if ($("#playpause").val() == "Pause") {
        for (var i = 0; i < 25; i++) {
            $("video").get(i).pause();
        }
        
        $("#playpause").attr("value", "Play");
    }
    else {
        for (var i = 0; i < 25; i++) {
            $("video").get(i).play();
        }
        $("#playpause").attr("value", "Pause");
    }
});