
# Home Work Seven


### Starting

+ Since I only needed a single-page I opened a Empty Web App with MVC loaded.

+ I also downloaded the Developer version of Fire Fox in order to view the Json and actually understand it.

+ I then went to Gighy and registered as a developer to get the api key. I used this in my project which kepted me from committing to keep it for my repo in github, but I wanted to get my project working first and then hide it.

+ So then I set up a Model to keep track and manage the results from the searchs its alot of code so I'm not going to add in my code but you can always go back to my github repo and check it out.


```javascript

$("#button").click(function () {//This is my part 3 a.
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

//I put in a playpause button for my little exta.
$("#playpause").click(function () {
    if ($("#playpause").val() == "Pause") {
        for (var i = 0; i < 25; i++) { // Knowing that 25 objects will be returned this will loop through and pause the videos.
            $("video").get(i).pause();
        }
        
        $("#playpause").attr("value", "Play");
    }
    else {
        for (var i = 0; i < 25; i++) {// Knowing that 25 objects will be returned this will loop through and play the videos.
            $("video").get(i).play();
        }
        $("#playpause").attr("value", "Pause");
    }
});

```


+ Below is the code from the Controller for the step 3 c and e. As you can also see I have hidden my api key.


```c#

public JsonResult Search()
{
	List<SearchResult> list = new List<SearchResult>();

	string giphyString = "http://api.giphy.com/v1/gifs/search?api_key=" 
		+ System.Web.Configuration.WebConfigurationManager.AppSettings["apikey"]
		+ "&q=" + Request.QueryString["search"];

	WebRequest request = WebRequest.Create(giphyString);
	Stream stream = request.GetResponse().GetResponseStream();

	RootObject gifs = new System.Web.Script.Serialization.JavaScriptSerializer()
						  .Deserialize<RootObject>(new StreamReader(stream)
						  .ReadToEnd());

	stream.Close();

	for (int i =0; i < 25; i++)
	{
		SearchResult searchResult = new SearchResult();
		searchResult.image = gifs.data[i].images.downsized_small.mp4;
		list.Add(searchResult);
	}
	// log user data
	var log = db.logs.Create();
	log.IPAddress = Request.UserHostAddress;
	log.SearchTerm = Request.QueryString["search"];
	log.AgentString = Request.UserAgent;
	db.logs.Add(log);
	db.SaveChanges();

	return Json(list, JsonRequestBehavior.AllowGet);
}

```

+ My CSS "Magic" this actually took longer than it shouls have I did it in between updates that changed my page look.

```css

video{
    display: block;
    width: 100%;
}

.video{
    float: left;
    width: 300px;
}

```

+ Below is the sql to set up the table and a screen shot of the populated table.

```sql

create table log (
	id int identity(0,1) primary key,
	IPAddress nvarchar(128) not null,
	AgentString nvarchar(1024) not null,
	SearchTerm nvarchar(255) not null
);

```

![alt text] (https://github.com/nastark519/nastark519.github.io/blob/master/Capture.PNG)

+ I added a play pause button to my page because I used `downsized_small.mp4` which uses short videos. the code for this is above in the javascript/AJAX section.











