# ASP.NET Core Template
Template for ASP.NET Core sites (with frontend based on Vue framework).

## Frameworks and libraries
#### Frontend
 - **Vue** - progressive framework for building user interfaces, with TypeScript support
 - **axios** - promise based HTTP client

#### Backend
 - **ASP.NET Core** - cross-platform framework for building modern cloud based internet connected applications
 - **Entity Framework Core** - ORM, lightweight and extensible version of the popular Entity Framework data access technology
 - **Autofac** - IoC (Inversion of Control) container
 - **AutoMapper** - easy mapping from one object to the another
 - **NLog** - logger
 - **xUnit** - unit testing framework
 - **Moq** - mocking framework

## Backend structure
Backend is split into several projects which allows to separate logic between them.
 - Backend.**API**
 - Backend.**Infrastructure**
 - Backend.**Services**
 - Backend.**DataAccess**

Additionaly, there are two projects containing unit tests.
 - Backend.**Infrastructure.Tests**
 - Backend.**Services.Tests**

## How to run
#### Frontend
Build and run:
```npm
npm run serve
```
Publish:
```
npm run build
```

#### Backend
Open the solution in Visual Studio, Backend.API should be set as the startup project.
Template uses the SQLite database as the default data storage. Before the first run you have to
create a migration in the Package Manager Console. Select Backend.DataAccess as the Default project
in the combo box and then type:
```
Add-Migration InitialMigration
Update-Database InitialMigration
```
When done, there should be a file in the main project directory called Database.sqlite.
Select this in the Solution Explorer and change "Copy to Output Directory" option to "Copy always" or "Copy if newer".