# <h1 align = "center"> Registrar

## <h3 align = "center"> Entity Framework in ASP.NET MVC, 8.4.20

## <h2 align = "center"> About

<p align = "center"> This is an application for a university registrar.

## **✅REQUIREMENTS**
* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)

## **💻SETUP**
* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* in command line use the command 'git clone (GitHub url)'
* open the program in a code editor
* in MySql Workbench select _Data Import/Restore_ from the Administration tab
* in import options select _Import from Self-Contained File_, and navigate to megan_hepner.sql in the root directory of this project
* The following is the code snippet from the megan_hepner.sql file <br>
* click _Start Import_
* in your code editor create a .gitignore file and store the bin and obj folders in .gitignore
* navigate to the HairSalon directory and type dotnet build in the command line to compile the code
* type dotnet run in the command line to run the program
__

## Specs

| Behavior    | Input | Output |
| :---------- | ----- | -----: |
| Program can create a student object
| Student object holds student name and date of enrollment
| Program can create a Course object
| Course object holds course name and number
| Student => Course reflect many to many relationship 
| Whening a student is able to add a course, there should be checkboxes that allow multiple courses to be added at once

## Known Bugs

_No known bugs_

## **❤️Contributors**
* Megan Hepner
* Sean Downs

## Support and contact details

Contact : Megan Hepner

## Technologies Used

* C#
* ASP.NET MVC
* Entity


## **📘 License**
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)