
 # Home Work One
 
### Learning Git and its commands.
+ I already had the git bash downloaded onto my lab top and I have used it to make a README file for a "hello world" repository, but I had not really gotten into any of the power of git. I learned several commands such as:

    ```shell
    git init
    ```
    + which I would use once I had made a folder for my a repository and then I would start coding and making changes to my files in my folder.
    ```shell
    git add .
    ```
    + was used to add all my changes to all of my files in the folder of my repository.
    ```shell
    git commit -m "Some comment to know what changes I have been working on, and why."
    ```
    + If I was happy with my changes I would make them permanent with committing to it.
    ```shell
    git config --global user.name "MyName"
    git config --global user.email "MySchoolEmail.@afjfja.edu"
    ```
    + I reset my user name and email to be more coherent.
    ```shell
    git status
    ```
    + To check everything was working how I wanted i.e. my `add`s and `commit`s were working as I thought the were.
    ```shell
    git log
    ```
    + To look through and check my `commit`s and see if I needed to go back to any. I maybe used it three time not to needed for HW1.
    ```shell
    git remote
    git remote add nickNameForURL (theExactURL)
    ```
    + I used the `remote` command to one make a remote to `push` my repo. to and also to check the spelling of the nick name I chose for it.
   + `git fetch` I haven't actaully used this command. Its one I'll have to look up.
   ```shell
   git pull
   ```
   + I used when I was having trouble `push`ing my repo to github because there was a file added to the repo that I was aimed at, so I pulled that file into the repo I had locally and then I was able to procced without further troubles.
   ```shell
   git push remoteName branchName
   ```
   + I would use this to push the changes that I had made on my local repo to my repo on github.

### Learn about remote repositories with Bitbucket, Github or GitLab
   + I used Github becuase I already had a profile and the bash set up. It was a great learning experiance.

### Learn HTML, CSS and Bootstrap
+ I have used HTML before anf I wrote my wedsite with it first before styling to with CSS and Bootstrap.
    + ##### HTML 

    ```html
    <!-- This is my htlm file for HW 1 of 460.-->
	<head>
		<title>Nathan Stark's Home</title>
	</head>

    <body>
	    <div id="explanation">
	    	<h1 class="topper">Hi. My name is Nathan.</br>
	    	Please come and check out my page and get to know me more.</br>
	    	I wrote these pages myself using HTML, CSS, and Bootstrap.
	    	Please tell me what you think at ******@gmail.com</h1>
	    </div>

    </body>
    ```
   This is for my index page for just a genral welcome. I have a Resume, References, and hobbies pages in all seperate files demistrated below.
   ```html
   
       <div id="contaner">
    
    			<div id="header">
    
    				<h1> Nathan Stark</h1>
    				<h4>611 Church St. W.<br/>
    				Monmouth, OR 97361<br/>
    				******@gmail.com</h4>
    				<h2>971.***.****</h2>
    			</div>
    
    
    			<div id="objec">
    				<p><h3><strong>Objective: To gain positions where I am enabled to use and improve my problem solving abilities, working with software.</strong></h3></p><br/>
    			</div>
    			
    			<div id="workHistory">
    				<p><h3><strong>Brief Work History:</strong></h3></p>
    				<p><h3><strong>Direct Support Professional<br/>
    				Cooper Hollow Inc. from January 2015 to present.</strong></h3></p>
    				<ul style="list-style-type:square">
    				  <li>Monitor and maintain a clean/safe environment for clients</li>
    				  <li>Completed documentation as necessary to meet federal, and state requirements</li>
    				  <li>Plan and support clients in various tasks and activities to improve their quality of life</li>
    				</ul>
    				<p><h3><strong>Cashier Lead<br/>
    				Hillsdale 76, from October 2008 to April 2010 & April 2012 to October 2013</strong></h3></p>
    				<ul style="list-style-type:square">
    				  <li>Handled vendor ordering transactions</li>
    				  <li>Worked with staffing operations and scheduling</li>
    				  <li>Trained staff in all areas of station operations and maintenance of workplace</li>
    				</ul>
    				<p><h3><strong>Senior Companion/Elder<br/>
    				The Church of Jesus Christ of Latter-day Saints, from April 2010 to April 2012</strong></h3></p>
    				<ul style="list-style-type:square">
    				  <li>Maintained a productive self managed work schedule</li>
    				  <li>Prepared demonstrations for groups up to 200</li>
    				  <li>Performed service for members of the community</li>
    				  <li>Gained communication experience over the phone and in person</li>
    				</ul>
    			</div>
    			<hr size=4 noshade>
    			<div id="specialize">
    			
    				<div id="education">	
    				
    					<strong>Education:</strong><br/>
    					<strong>Western Oregon University</strong>
    					<ul>
    					  <li>Double Major: Mathematics and Computer Science</li>
    					  <li>Math Club President 2016-2017</li>
    					</ul>
    					<strong>Woodrow Wilson High School – Diploma, 2008</strong>
    					<ul>
    					  <li>Varsity Rugby Team Captain</li>
    					  <li>Varsity Crew Team Captain</li>
    					  <li>Metal/Wood Shop</li>
    					</ul>
    				</div>
    
    				<div id="skills">
    					<strong>Programing Languages</strong>
    					<ul>
    					  <li>Java</li>
    					  <li>MySQL</li>
    					  <li>C/C++</li>
    					  <li>HTML</li>
    					  <li>CSS</li>
    					  <li>Bootstrap</li>
    					  <li>MongoDB</li>
    					</ul>
    					<strong>Certifications</strong>
    					<ul>
    					  <li>Oregon Intervention System(OIS)</li>
    					  <li>CPR/First Aid</li>
    					</ul>
    					
    				</div>
    				
    			</div>
    			
    		</div>
    		
    </body>
   ```
   This is my Resume page seen above. I had a resume templet that I have used for some years now and I took this oppertunity to try and replacate it. I think I did pretty well, and even feel that I improved it's look.
   ```html
       	<div id="references">
    		<h2>References:</h2>
    		<table class="table table-condensed">
    			<thead>
    			<tr>
    				<th>Name</th>
    				<th>Job title</th>
    				<th>Company</th>
    				<th>Phone number</th>
    			</tr>
    			</thead>
    			<tbody>
    			<tr>
    				<td>Jennifer Jones</td>
    				<td>Manager</td>
    				<td>Hillsdale 76</td>
    				<td>(503)555-5555</td>
    			</tr>
    			<tr>
    				<td>Russell Larson</td>
    				<td>District Leader</td>
    				<td>LDS Mission</td>
    				<td>(503)555-5555</td>
    			</tr>
    			<tr>
    				<td>Jennifer O’Reilly</td>
    				<td>Office Manager</td>
    				<td>CloudCar</td>
    				<td>(503)555-5555</td>
    			</tr>
    			<tr>
    				<td>Byron Shinkle</td>
    				<td>CFO</td>
    				<td>Cooper Hollow Inc.</td>
    				<td>(503)555-5555</td>
    			</tr>
    			
    			</tbody>
    		</table>
    	</div>
    
    </body>
   ```
   Here is my references page I thought this would be a good place to have a table. The table kept it neat, clean and easey to read.
   ``` html
       <div id="entertainment">
    		<div id="occupy">
    			<h3><strong>Things to occupy me:</strong></h3>
    			<dl>
    			  <dt>What I do on a rainy day</dt>
    			  <dd>Play xbox</dd>
    			  <dd>netflix binge with wife</dd>
    			  <dd>Board games with wife</dd>
    			  <dd>Swim center with my daughter</dd>
    			  
    			  <dt>What I do on a sunny day</dt>
    			  <dd>Park with wife and daughter</dd>
    			  <dd>Go for a walk</dd>
    			  <dd>Read outside</dd>
    			  <dd>Go to a swimming hole</dd>
    			  <dd>Mountain bike</dd>
    			  <dd>Camping</dd>		  
    			</dl>
    		</div>
    		<div id="ranking">
    			<h3><strong>Five things to save if my house is on fire:</strong></h3>
    			<ol>
    			  <li>My family</li>
    			  <li>My dog</li>
    			  <li>Written letters form family</li>
    			  <li>Important documents</li>
    			  <li>My my computer</li>
    			</ol>
    		</div>
    	</div>
    
    </body>
   ```
   Here I though in a ordered list and a description list of thinks to help people get to know me better.
   
   + ##### CSS