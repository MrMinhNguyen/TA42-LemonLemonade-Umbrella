![teamlogo](https://user-images.githubusercontent.com/57879304/136358998-9c1817ea-a8a7-4974-897f-bba80e2ff928.png)
### Team: TA42-Lemon Lemonade<br/><br/>

# Table of Content
  - [Introduction](#introduction)
  - [System Architecture](#system-architecture)
  - [Back-End System](#back-end-system)
  - [Front-End System](#front-end-system)




# Introduction
This a website that provides information on Sunlight Proection like displaying UV level and predicting UV level etc. It intends to help parents keep their children away from intense sunlight<br/><br/>  

# System Architecture

The Front-End of our website is built using ASP.NET with CSHTML, Javascript and C#.

The Back-End of our website is built using Python 3.

Both the Front-End and Back-End parts are hosted using Microsoft Azure.<br/><br/> 

## Back-End System

The main Back-End system is run by the app.py file, which initiates a Flask web application.

The uvr.py and data_wrangle.py files do the job of data pre-processing and database initialization.

Folders, such as hospitals, protectors, or Quiz contains CSV files that store the raw data.

The testing folder stores unit testing scripts.

The following Python packages need to be installed for the operation of the Back-End system:
```
Flask==2.0.1
mysql-connector-python==8.0.26
requests==2.26.0
simplejson==3.17.4
pandas==1.1.5
Flask-Cors==3.0.10
```

## Front-End system
The assets folder stores all images. Add your personal images to folder and drag to use it.
![image](https://user-images.githubusercontent.com/57879304/136363838-a52f1c84-2427-4caa-ab64-a85ab3c94965.png)

You can add Macro CSS style on styles.css under Content folder.![image](https://user-images.githubusercontent.com/57879304/136364356-d3db3b66-9e2b-4b6a-9a50-d9f1e5f1081a.png)

If you want to make some changes between front-end and back-end, you can modify by these controllers.
![image](https://user-images.githubusercontent.com/57879304/136364723-b699e78d-d304-44f2-9e13-33b4ee7d9be7.png)

Using these cshtml files to change the layout of your website. Besides, if you want to make some overall changes, feel free to want to work on _Layout.cshtml file. 


The following packages need to be installed for the operation of the Front-End system:
```
Antlr==3.5.0.2
bootstra==5.1.0
jQuery==Version 3.6.0
jQuery.Validation==1.19.3
Microsoft.AspNet.Mvc==5.2.7
Microsoft.AspNet.Razor==3.2.7
Microsoft.AspNet.Web.Optimizatio==1.1.3
Microsoft.AspNet.WebPages==3.2.7
Microsoft.CodeDom.Providers.DotNetComplierPlatform==3.6.0
Microsoft.jQuery.Unobstrusive.Ajax==3.2.6
Microsoft.jQuery.Unobstrusive.Validation==3.2.12
Microsoft.Web.Infrastructure==1.0.0
Modernizr==2.8.3 
Newtonsoft.Json==13.0.1
WebGrease==1.6.0
```
