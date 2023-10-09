# _Best Restaurants_

#### By _Moshe Atia_

#### _A C# / ASP.NET Core MVC application using Entity Framework Core and MySQL._

## Technologies Used

- C#
- .NET 6
- ASP.NET Core MVC
- Entity Framework Core
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

#### Install and Run the Project

1. Copy the **[URL](https://github.com/Object-ions/HairSalon.Solution.git)** provided for this repository.
2. Open Terminal.
3. Change your working directory to where you want the cloned directory.
4. In your terminal, type `git clone` and use the copied URL from Step 1. Or, copy the following git command:

```bash
$ git clone https://github.com/Object-ions/HairSalon.Solution.git
```

5. Open your terminal and navigate to this project's production directory called `HairSalon.Solution`.
6. Within the production directory of the project, create a file called `appsettings.json` and add the following code to it:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Port=3306;database=moshe_atia;uid=[USERNAME];pwd=[PASSWORD];"
     }
   }
   ```
7. Next, make sure to update the connection string with your own system's values for `[USERNAME]` and `[PASSWORD]`! Don't forget to replace the brackets `[]` as well.
8. In the command line, run the following command to compile and run web application in development mode with a watcher:

```bash
$ dotnet watch run
```

> Optionally, you can run `dotnet build` to compile this web app without running it.

9. Open the browser to https://localhost:5001 to use the web application.
   > If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS.

## Known Bugs

- no bugs known. If any bugs are discovered, please contact the author.

## License

MIT License

Copyright (c) 2023 Moshe Atia\_

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
