![teamlogo](https://user-images.githubusercontent.com/57879304/136358998-9c1817ea-a8a7-4974-897f-bba80e2ff928.png)
### Team: TA42-Lemon Lemonade<br/><br/>

# Table of Content
  - [Introduction](#introduction)
  - [System Architecture](#system-architecture)
  - [Back-End System](#back-end-system)
  - [Front-End System](#front-end-system)
  - [Contributors](#contributors)




# Introduction
This a website that provides information on Sunlight Protection like displaying UV level and predicting UV level etc. It intends to help parents keep their children away from intense sunlight<br/><br/>  

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
<img width="531" alt="a4f100f4f23b66f207385cf57b9c0b6" src="https://user-images.githubusercontent.com/57879304/136365763-745ab45e-75cd-4de7-bb78-f6cdea6f1dd4.png">


You can add Macro CSS style on styles.css under Content folder.![image](https://user-images.githubusercontent.com/57879304/136364356-d3db3b66-9e2b-4b6a-9a50-d9f1e5f1081a.png)

If you want to make some changes between front-end and back-end, you can modify by these controllers.
<img width="623" alt="e9848dd8d09ff3a0a326033017a0837" src="https://user-images.githubusercontent.com/57879304/136365842-3c477927-c54d-46b7-a985-d21eb603aa2e.png">

Using these cshtml files to change the layout of your website. Besides, if you want to make some overall changes, feel free to want to work on _Layout.cshtml file. <br/>
<img width="474" alt="739adbf9eecc58b8b618dd7bc6b57ad" src="https://user-images.githubusercontent.com/57879304/136365878-606632d5-e092-44b0-9e3e-3f5e9b8d1463.png">
<br/><br/>

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
<br/><br/><br/>
## Contributors
![GitHub Contributors Image](https://contrib.rocks/image?repo=MrMinhNguyen/TA42-LemonLemonade-Umbrella)
