
$(document).ready(function(){
	//I've set my variable to stop undefined type coming across
	var nam="";
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
			" <button id='bad'>Bad</button></p>").show();
			$("#inputBox").hide();
		}
		});
	//here I had some troble working with my buttons that I added in the above function
	//but after some research I came across the .on() which bond the click functional that
	//I needed for the DOM to be properly altered. 
	$("#welcome").on('click',"#good",function() {
		$("#goodHit").html("<h3>I'm so happy for you!</h3>" + 
		"<p>Here is a quote to help you along your way.</p>" + 
		"<blochquote>The good old days are now.</blochquote>" + 
		"<figcaption>Tom Clancy</figcaption>").show();
		$("#hi").hide();
	});
	
	$("#welcome").on('click',"#okay",function() {
		$("#okayHit").html("it worked okay");
		
		$("#welcome").hide();
		
	});
	
	$("#welcome").on('click',"#bad",function() {
		$("#badHit").html("I'm sorry to hear that. Maybe you should try this " + 
		" <a href='https://www.youtube.com/watch?v=ekm0BsI2qfY'>video</a>.");
		
		$("#welcome").hide();
		
	});
		
		
});
