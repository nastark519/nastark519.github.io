
# Home Work Two

### Learning Javascript.
+ I used a seperate file for my javascript and JQuery. I chose to do 
this because this has been generally the accepted practice. I have my Javascript
and JQuery mixed as that is just the way that makes sence for writing JQuery and Javascript.

		+ Using the basic constructs of Javascript you can see here, with my "if" "else" statements.
		```javascript
		if(nam == ""){
			alert("Please let know what your name is.");
		}
		else if(/  /i.test(nam)){
			alert("Try to make sure that your not adding an extra space. It can be any name make one up if that helps.");
		}
		else{
		```
		+ Using JQuery aswell As you can see.
		```javascript
		$(document).ready(function(){
			var nam="";
			$("#sayHello").click(function(){
				nam = $("#textBox1").val();
		```
### DOM and how to select and modify it
+ In the index page I made several "div"s with "id"s so that I could easely target them.
	```html
		<div id="inputBox">
		Here is my first text box.
		
		<input id="textBox1" type="text" value=""/>
		
		<button id="sayHello">Submit</button>
		</div>
		
		<div id="welcome">
		</div>
		
		<div id="goodHit">
		</div>
		
		<div id="badHit">
		</div>
		
		<div id="okayHit">
	```
	+ these would be used through out the project to change and alter the DOM

### Responding to events
+ I handled all of my events through my jQuery ".click(function(){" and had checks for 
my variable to check if it is valid.
	```javascript
	$("#sayHello").click(function(){
		nam = $("#textBox1").val();
		if(nam == ""){
			alert("Please let know what your name is.");
		}
		else if(/  /i.test(nam)){
			alert("Try to make sure that your not adding an extra space. It can be any name make one up if that helps.");
		}
		else{
			$("#welcome").html("<p id='hi'>Hello "+ nam +",</br> How was your day?</br>" + 
			"<button id='good'>GOOD</button> <button id='okay'>okay</button>" +
			" <button id='bad'>Bad</button></p>").show().css("visibility","visible");
			$("#inputBox").hide();
		}
		});
	```
### Using feature branches in Git: "branch", "checkout", and "merge".
+ So here I was not worned about doing all of my work locally then "push"ing my work
 so I promise that I used "checkout", "branck", and "merge".
	+ Luckally I try and save most of my git consol commands in Notepad
		```shell
		nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (branch1)
		$ git commit -m "finished the set up for the jquery part and just need to use cs                                                                                            s and bootstrap, not doing anything fancy."
		[branch1 7f25f5a] finished the set up for the jquery part and just need to use c                                                                                            ss and bootstrap, not doing anything fancy.
		 1 file changed, 13 insertions(+), 1 deletion(-)

		nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (branch1)
		$ git add .

		nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (branch1)
		$ git commit -m "finished. version 1.0"
		[branch1 64b236f] finished. version 1.0
		 3 files changed, 55 insertions(+), 19 deletions(-)

		nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (branch1)
		$ git merge master
		Already up-to-date.

		nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (branch1)
		$ git checkout master
		Switched to branch 'master'
		M       HW1
		Your branch is up-to-date with 'hw1pages/master'.

		nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (master)
		$ git --no-ff branch1
		Unknown option: --no-ff
		usage: git [--version] [--help] [-C <path>] [-c name=value]
				   [--exec-path[=<path>]] [--html-path] [--man-path] [--info-path]
				   [-p | --paginate | --no-pager] [--no-replace-objects] [--bare]
				   [--git-dir=<path>] [--work-tree=<path>] [--namespace=<name>]
				   <command> [<args>]

		nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (master)
		$ git merge --no-ff branch1
		Merge made by the 'recursive' strategy.
		 HW1            |  2 +-
		 HW2/index.html | 53 ++++++++++++++++++++++++++++++++++++++++++++++++
		 HW2/myJQ.js    | 64 ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		 HW2/style.css  | 46 +++++++++++++++++++++++++++++++++++++++++
		 4 files changed, 164 insertions(+), 1 deletion(-)
		 create mode 100644 HW2/index.html
		 create mode 100644 HW2/myJQ.js
		 create mode 100644 HW2/style.css

		nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (master)
		$ git remote
		hw1pages

		nstar@Stark MINGW64 ~/Desktop/CS/460/homework460 (master)
		$ git push hw1pages master
		Counting objects: 36, done.
		Delta compression using up to 4 threads.
		Compressing objects: 100% (35/35), done.
		Writing objects: 100% (36/36), 5.18 KiB | 0 bytes/s, done.
		Total 36 (delta 16), reused 0 (delta 0)
		remote: Resolving deltas: 100% (16/16), done.
		To https://github.com/nastark519/nastark519.github.io.git
		   b9e6e1b..611a400  master -> master
		```
		+ Hopefully that is proof enought of what I did.
	
	
	
