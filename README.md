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