
$(document).ready(function(){
	var nam="";
	$("#sayHello").click(function(){
		nam = $("#textBox1").val();
		if(nam != ""){
			$("#welcome").html("<p>Hello "+ nam +",</br> How was your day?</p>");
		}
		;});
		
		
});
