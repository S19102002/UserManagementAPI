# UserManagementAPI


## Project Overview

UserManagementAPI is an ASP.NET Core Web API developed for TechHive Solutions to manage user records efficiently. The API provides full CRUD (Create, Read, Update, Delete) functionality and demonstrates the use of Microsoft Copilot for code generation, debugging, validation, and middleware implementation.

This project was developed as part of a Generative AI and Back-End Development learning activity focused on using Microsoft Copilot to enhance productivity and code quality.

---

## Features

### CRUD Operations

The API supports the following endpoints:

| Method | Endpoint        | Description              |
| ------ | --------------- | ------------------------ |
| GET    | /api/users      | Retrieve all users       |
| GET    | /api/users/{id} | Retrieve a specific user |
| POST   | /api/users      | Create a new user        |
| PUT    | /api/users/{id} | Update an existing user  |
| DELETE | /api/users/{id} | Delete a user            |

---

## Validation Features

The API validates user input using Data Annotations:

* User name is required.
* User name must contain at least 3 characters.
* Email address is required.
* Email must be in a valid format.

## Middleware Components

### Error Handling Middleware

* Captures unhandled exceptions.
* Returns consistent JSON error responses.
* Prevents application crashes.

### Authentication Middleware

* Validates Authorization header.
* Allows access only with a valid token.
* Returns HTTP 401 Unauthorized for invalid requests.

### Logging Middleware

Logs:

* HTTP request method
* Request path
* Response status code


## Technologies Used

* ASP.NET Core Web API
* C#
* .NET 8
* Swagger / OpenAPI
* Microsoft Copilot
* Postman
* Git
* GitHub

---

## Project Structure

```text
UserManagementAPI
│
├── Controllers
│   └── UsersController.cs
│
├── Models
│   └── User.cs
│
├── Middleware
│   ├── AuthenticationMiddleware.cs
│   ├── ErrorHandlingMiddleware.cs
│   └── LoggingMiddleware.cs
│
├── Program.cs
│
└── README.md
```
## Microsoft Copilot Usage

### Activity 1: Writing and Enhancing API Code

Microsoft Copilot assisted with:

* Generating ASP.NET Core Web API boilerplate code.
* Creating CRUD endpoints.
* Generating User model classes.
* Configuring Swagger/OpenAPI documentation.

### Activity 2: Debugging API Code

Microsoft Copilot helped:

* Identify missing validation rules.
* Detect issues with invalid email input.
* Handle non-existent user lookups.
* Improve error handling.
* Suggest performance improvements.

### Activity 3: Middleware Implementation

Microsoft Copilot assisted with:

* Creating request logging middleware.
* Creating centralized exception handling middleware.
* Creating token authentication middleware.
* Configuring middleware execution order.
* Testing middleware functionality.

## Author

Sourav Samanta

B.Tech Student

Project: User Management API using ASP.NET Core and Microsoft Copilot
