
# Home Work Four
 
### Objectives 1 and 2.
+ 1 and 2 are mashed together as I learned ASP.NET MVC 5 by building this web app.

	+ I started with making folders Home and Shared in Views
	+ Then I made a HomeController and initialized an index page for my home landing.
	
	```c#
	// GET: Home
        public ActionResult Index()
        {
            return View();
        }
	```
	
	+ I then copy this construct and changed the method name for pages 1-3 such as,
	
	```c#
	// GET: Home
        public ActionResult Index()
        {
            return View();
        }
		
		// GET: Page1
        public ActionResult Page1()
        {
            return View();
        }
		
		// GET: Page2
        public ActionResult Page2()
        {
            return View();
        }
		
		// GET: Page4
        public ActionResult Page3()
        {
            return View();
        }
	```
	
	+ I then added the Views for those pages using the pregenerated pages. I lefted those alone for now and when back to change them as needed for later in the home work. I will also be making changes in my controller.
	+ I next went on to my Index page and set up the unordered list to navigate the different pages.
	
	```html
		<ul>
			<li>@Html.ActionLink("Page 1", "Page1")</li>
			<li>@Html.ActionLink("Page 2", "Page2")</li>
			<li>@Html.ActionLink("Page 3", "Page3")</li>
		</ul>
	```
	
	+ I then added in a form for a tempeture calculater. The basics of the form were taken from w3school and then changed for my needs.
	
	```html
	<form action="Page1" method="get">
		<lablel for="tempet">Tempeture:</lablel><br>
		<input type="text" name="tempet" value="">
		<br>
		<lablel for="sysM">Original System Messurment:</lablel><br>
		<input type="text" name="sysM" value="">
		<br><br>
		<input type="submit" value="Submit"> 
		<br/>
	</form> 
	```
	+ I then changed my controller class `Page1()` method. You can also see that the `Request` is used.
	
	```c#
	//GET: Page1
        [HttpGet]
        public ActionResult Page1()
        {
            string answer = "Please enter a measurement and a temperature to start";
            string temp = Request.QueryString["tempet"];
            /*tests to see if temp is valid. If it is it initializes 
             * it an sets in in tempD => temperature as a double. If not valid
             * return an message to the user.*/
            if (!double.TryParse(temp, out double tempD))
            {
                ViewBag.AnswerMessage = answer;
                return View();
            }
            //mSyst is what messurement system they have to work with.
            string mSyst = Request.QueryString["sysM"];
            double a, b;

            if (mSyst == null || mSyst == "")
            {
                ViewBag.AnswerMessage = answer;
                return View();
            }

            if (mSyst.ToLower() == "fahrenheit" || mSyst.ToLower() == "f")
            {
                a = (tempD - 32) * 5 / 9;
                b = (tempD + 459.67) * 5 / 9;
                answer = "To Celsius: " + a + " To Kelvin: " + b;
            }
            else if (mSyst.ToLower() == "celsius" || mSyst.ToLower() == "c")
            {
                a = (tempD * 9 / 5) + 32;
                b = (tempD + 273.15);
                answer = "To Fahrenheit: " + a + " To Kelvin: " + b;
            }
            else if (mSyst.ToLower() == "kelvin" || mSyst.ToLower() == "k")
            {
                a = (tempD - 273.15) * 1.8 + 32;
                b = (tempD - 273.15);
                answer = "To Fahrenheit: " + a + " To Celsius: " + b;
            }

            ViewBag.AnswerMessage = answer;
            return View();
        }
	```
	
	+ As you can see the `ViewBag` is then sent to the view 
	
	```html
	<p><br />
    @ViewBag.AnswerMessage
    </p>
	```
	
### Lastly `Page2()` and `Page3()`

```c#
/*GET: Page2 nothing will be added here just my basic
 * get for page2 View.*/
[HttpGet]
public ActionResult Page2()
{
	return View();
}

/*The post for page2. this is where I am getting 
 * all of my work done for step 5.*/
[HttpPost]
public ActionResult Page2(FormCollection form)
{
string answer = "Please enter a measurement and a temperature to start";
string mSyst = form["sysM"];
//get the tempeture and check if its valid. 
string temp = form["tempet"];
if (!double.TryParse(temp, out double tempD))
{
	ViewBag.AnswerMessage2 = answer;
	return View();
}
//dummy vars to do my calc. converting.
double a, b;

if (mSyst == null || mSyst == "")
{
	ViewBag.AnswerMessage2 = answer;
	return View();
}

if (mSyst.ToLower() == "fahrenheit" || mSyst.ToLower() == "f")
{
	a = (tempD - 32) * 5 / 9;
	b = (tempD + 459.67) * 5 / 9;
	answer = "To Celsius: " + a + " To Kelvin: " + b;
}
else if (mSyst.ToLower() == "celsius" || mSyst.ToLower() == "c")
{
	a = (tempD * 9 / 5) + 32;
	b = (tempD + 273.15);
	answer = "To Fahrenheit: " + a + " To Kelvin: " + b;
}
else if (mSyst.ToLower() == "kelvin" || mSyst.ToLower() == "k")
{
	a = (tempD - 273.15) * 1.8 + 32;
	b = (tempD - 273.15);
	answer = "To Fahrenheit: " + a + " To Celsius: " + b;
}


ViewBag.AnswerMessage2 = answer;
return View();
}

//GET: Page3
[HttpGet]
public ActionResult Page3()
{
	return View();
}

//POST: Page3
[HttpPost]
public ActionResult Page3(string amount, string interest, string term)
{
//dummy vars for storing calcuations.
double e, b, c, d;
if (!double.TryParse(interest, out double i))
{
	ViewBag.Answer3 = "This shouldn't happen....";
	return View();
}
e = i / 12;

if (!double.TryParse(term, out double t))
{
	ViewBag.Answer3 = "This shouldn't happen....";
	return View();
}
b = t* 12;
c = (((Math.Pow((1 + e), b)) - 1) / (e * Math.Pow((1 + e), b)));

if (!double.TryParse(amount, out double a))
{
	ViewBag.Answer3 = "This shouldn't happen....";
	return View();
}
d = a / c;

string explain = "The amount that you will have to pay back at the loans term end is: ";

ViewBag.Answer3 = explain + (d * e) + "";
return View();
}
```
	
+ The changes to the to the respective views can be viewed maybe seen in the [repository](https://github.com/nastark519/nastark519.github.io/tree/master/HW4/HW4/Views/Home)
	
	

	
	
	
	
	
