

# Home Work Nine


### Deploying in the cloud.

+ So starting out I went on to the Microsoft Azure site and tried to register an account. After waiting for 4 hours for the card verification to load and it not finnishing I thought I would try to us the Microsoft Imagine and that took 5 min. to do.

+ I then went to the portal page of Azure and loged in.

+ Then clicked on "SQL Databases" from ther I clicked on the "+ Add" at the top of the inner split screen.

+ [Image of the above step.](https://github.com/nastark519/nastark519.github.io/blob/master/hw9first.PNG?raw=true)

+ I am the directed to to fill out some information:

    + Name the Database and the create a new Resource group.
    
    + [Image of the above step.](https://github.com/nastark519/nastark519.github.io/blob/master/hw9six.PNG?raw=true)

    + I the created a server. At this point it is importand to use a admin name and password that you will need to remember.

    + [Image of the above step.](https://github.com/nastark519/nastark519.github.io/blob/master/hw9seven.PNG?raw=true)

+ Then I went back to the Visual Studio project to connect and run the sql up file to setup and seed the database on Azure.

    + [Image of the above step.](https://github.com/nastark519/nastark519.github.io/blob/master/hw9two.PNG?raw=true)

    + For this the admin name and password were needed. Aswell as the Database name that we set up in Azure.

+ At this point I went back to Azure and clicked on the "App Services" then clicked "Add" went to the "Web App" and went to create a new one.

+ [Image of the above step.](https://github.com/nastark519/nastark519.github.io/blob/master/hw9eight.PNG?raw=true)

+ I then whent back to Visual Studio right clicked the project's name which is HW8 for the web app we are creating and went to "Publish" I then selected web app that I set up for the project.

    + [Image of the above step.](https://github.com/nastark519/nastark519.github.io/blob/master/hw9nine.PNG?raw=true)

    + The website will not work yet.

+ I then went back to Azure and the Database set up there. I then went to copie the connection string.

    + Going next to "App Services" and scrolled down to "Application Settings" and scroll down and enter the co string that you copied into the value field and the name of the context class into the name field.

        + Don't for get to add the admin name you created and the password you created into the connection string for the User ID and Password field. Delete the brackets{}{}.

Awsome website [here](http://hw9art.azurewebsites.net/Artists/Welcome)



























