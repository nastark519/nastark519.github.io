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
    $.each(data, function (i, video) {// create a space for my videos.
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
    if ($("#playpause").val() == "Pause") {// Knowing that 25 objects will be returned this will loop through and pauses the videos.
        for (var i = 0; i < 25; i++) {
            $("video").get(i).pause();
        }
        
        $("#playpause").attr("value", "Play");
    }
    else {
        for (var i = 0; i < 25; i++) {// Knowing that 25 objects will be returned this will loop through and plays the videos.
            $("video").get(i).play();
        }
        $("#playpause").attr("value", "Pause");
    }
});