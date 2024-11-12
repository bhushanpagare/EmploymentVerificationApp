# Employment Verification Application

## Overview

This application allows users to verify employment details for a given employee by providing an employee ID, company name, and verification code.

## Frontend

- The frontend is a simple HTML form that collects employee details.
- The form sends a `POST` request to the backend API and displays the verification result.

## Backend

- The backend is built using ASP.NET Core Web API.
- The application uses an in-memory data structure to store employee data.

## Assumptions

- The employee database is prepopulated with a few sample records.
- The backend only checks for exact matches of employee ID, company name, and verification code.

## Running the Application

1. Clone the repository.
2. Run the backend:

   ```bash
   dotnet run
