# _Best Restaurants_

#### By _Moshe Atia_

#### _A C# / ASP.NET Core MVC application using Entity Framework Core and MySQL._

## Technologies Used

- C#
- .NET 6
- ASP.NET Core MVC
- Entity Framework Core
- ASP.NET Core MVC 6.0
- MySQL
- MySQL Workbench
- HTML
- CSS

## Description

This application provides a platform for Claire (the user) to monitor her employees (stylists) and their respective clients. The user can search for clients by their stylist, or otherwise search through a list of all their clients.

Schema diagram:
<img src="https://github.com/Object-ions/HairSalon.Solution/blob/main/HairSalon/wwwroot/img/Schema.png" />

Available Routes:

```
https://localhost:5001
https://localhost:5001/Stylists
https://localhost:5001/Stylists/Create
https://localhost:5001/Stylists/Details/{id}
https://localhost:5001/Stylists/Edit/{id}
https://localhost:5001/Stylists/Delete/{id}
https://localhost:5001/Clients
https://localhost:5001/Clients/Create
https://localhost:5001/Clients/Details/{id}
https://localhost:5001/Clients/Edit/{id}
https://localhost:5001/Clients/Delete/{id}

```

## Setup/Installation Requirements

#### Install Tools

This project assumes you have MySQL Server and MySQL Workbench installed on your system. If necessary, follow along with the installation steps for the tools introduced in these series of lessons on [LearnHowToProgram](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c).

#### Set Up the Database

To set up a new database to run with this application, follow the instructions in this [LearnHowToProgram Lesson](https://www.learnhowtoprogram.com/c-and-net/database-basics/creating-a-test-database-exporting-and-importing-databases-with-mysql-workbench). You'll need to import the `best_restaurants_dump.sql` file located at the top level of this repository to create a new database in MySQL Workbench with the name `best_restaurants`.

## Setup/Installation Requirements

Installing/Configuring MySQL and MySQL Workbench:

1. Follow the instructions on this <a href="https://old.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql">page</a> for installing and configuring MySQL and MySQL Workbench

Installing dotnet-ef:

1. Run the following command to globally install dotnet-ef tools which will allow you to create migrations and create databases:
   `$ dotnet tool install --global dotnet-ef --version 6.0.0`

Cloning the Repo:

1. Open Terminal.
2. Change your directory to where you would want the cloned directory.
3. Input the following command into your terminal:  
   `$ git clone https://github.com/Object-ions/HairSalon.Solution.git`
4. Using the terminal, navigate to the production directory: "Clinic" and create a new file called appsettings.json
5. Within appsettings.json, put in the following code while also replacing the following values with your own values as shown below the code snippet:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```

- [YOUR-USERNAME-HERE] with your username
- [YOUR-PASSWORD-HERE] with your password
- [YOUR-DB-NAME] with the name of your database

Setup/Import the Database:

1. Within MySQL Workbench's Navigator > Administration window, select Data Import/Restore.
2. In Import Options select "Import from Self-Contained File".
3. Navigate to the `moshe_atia.sql` file within the cloned Clinic.Solution repo.
4. Under the 'Default Schema to be Imported To' section, select the New button.
5. Enter "[YOUR-DB-NAME]" and click OK. Replace "[YOUR-DB-NAME]" with the same name within your appsettings.json file
6. Navigate to the tab called Import Progress and click "Start Import" at the bottom right corner of the window.

Running the program:

1. Navigate to the project's production directory "Clinic" using the terminal.
2. Run the following command to update the database:
   `$ dotnet ef database update`
3. Within the command line, run the command `dotnet watch run` to compile and execute the console application in developer mode.

## Known Bugs

- no bugs known. If any bugs are discovered, please contact the author.

## License

MIT License

Copyright (c) 2023 Moshe Atia

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
