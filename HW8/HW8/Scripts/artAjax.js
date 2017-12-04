function Ajax(id) {
    var source = "/Artists/Genre/" + id;
    console.log(source);
    $.ajax({
        type: "GET",
        dataType: "json",
        data: { id: id },
        url: source,
        success: displayResults,
        error: errorOnAjax
    });
}

function displayResults(data) {
    console.log("AJAX Success!");
    console.log(data);

    $('#results').empty();

    //var item = document.getElementById("results");
    $("#results").append("<p><ul>");
    $.each(data, function (i, item) {
        $("#results").append(
            "<li>" + item["title"] + " by " + item["artist"] +"</li>"
        );
    });
    $("#results").append("</ul></p>");

}

function errorOnAjax() {
    console.log("Error");
}