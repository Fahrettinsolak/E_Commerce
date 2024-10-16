# E-Commerce Microservices Project

## Contents
- [Overview](#overview)
- [Technologies Used](#technologies-used)
- [Architecture](#architecture)
- [Installation](#installation)
- [Features](#features)
- [API Documentation](#api-documentation)
- [License](#license)

---

## Overview

This **E-Commerce Microservices Project** is a comprehensive system that provides a robust architecture for scalable and sustainable applications built using modern technologies. The project implements best practices such as **CQRS**, **Onion Architecture** and **Repository Design Pattern**, while utilizing powerful tools such as **Docker**, **Redis**, **MongoDB** and **PostgreSQL**.

The project provides **Google Drive integrated photo upload**, **JWT based authentication and authorization** and provides real-time communication with **SignalR**.

## Technologies Used

### Backend
- **Asp.Net Core**: Forms the basis of API services.
- **Dapper**: Lightweight ORM for database interactions.
- **Redis**: Cache mechanism to increase performance.
- **MongoDB**: NoSQL database to manage unstructured data.
- **PostgreSQL**, **MSSQL**, **SQLite**: Relational databases for structured data.
- **Identity Server**: Authentication and authorization management.
- **Ocelot Gateway**: API Gateway for routing and management between microservices.
- **CQRS**: Separates read and write operations.
- **Mediator Design Pattern**: To provide clean communication between services.
- **Repository Design Pattern**: To abstract business logic and database operations.

- **JWT**: To secure API endpoints with JWT-based authentication.

- **SignalR**: For real-time data streaming.

### DevOps
- **Docker**: Containerization for easy deployment and environment consistency.

- **Swagger**: API documentation and testing interface.

- **Postman**: API testing and development tool.

### Other
- **Google Drive API**: Used for photo uploads.

- **Ajax**: For asynchronous requests from frontend.

- **Rapid API**: External API consumption.

## Architecture

The system follows the **Onion Architecture** architecture to ensure independence between layers.

- **API Gateway**: Manages communication between clients and services with Ocelot.
- **Microservices**: Services that handle specific parts of the system, such as user management, order processing, product management.

- **Database Layer**: **SQL** and **NoSQL** databases are used depending on the service needs.

- **Cache**: Response times are improved by using **Redis** for frequently requested data.

- **Security**: Security is provided by using **Identity Server** and **JWT Bearer Token**.

### CQRS Implementation

The project uses the **CQRS (Command Query Responsibility Segregation)** pattern to separate read and write operations. This approach increases scalability and makes complex business logic easier to manage.

### Mediator Pattern

With the **Mediator** pattern, the system separates requests from business logic, making the system more modular and maintainable.

## Installation

### Requirements
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/get-started)
- [PostgreSQL](https://www.postgresql.org/download/)
- [MongoDB](https://www.mongodb.com/try/download/community)

### Installation

1. Clone the project:
```bash
git clone https://github.com/Fahrettinsolak/E_Commerce.git
```

2. Go to the project directory:
```bash
cd E_Commerce
```

3. Create and run the Docker containers:
```bash
docker-compose up --build
```

4. Perform database migrations:
```bash
dotnet ef database update
```

5. Implementation It will be up and running at http://localhost:5000.

### Environment Variables

Before running the project, make sure the following **environment variables** are configured:

- **DB_CONNECTION_STRING**: Connection string for PostgreSQL or MSSQL.
- **MONGO_CONNECTION_STRING**: MongoDB connection string.
- **REDIS_CONNECTION_STRING**: Redis connection string.
- **GOOGLE_DRIVE_API_KEY**: API key for Google Drive integration.

## Features

- **Authentication and Authorization**: Secure authentication using JWT and Identity Server.
- **Photo Upload**: Ability to upload photos directly to Google Drive in the system.
- **Real-Time Notifications**: Real-time updates using SignalR.
- **API Gateway**: Centralized routing with Ocelot.
- **Postman Collection**: Pre-configured Postman requests for easy testing.

- **Swagger Integration**: Auto-generated documentation for the API.

## API Documentation

API documentation is provided by Swagger. Once the application is running, you can access the Swagger interface via the following URL:

- [Swagger](http://localhost:5000/swagger)
