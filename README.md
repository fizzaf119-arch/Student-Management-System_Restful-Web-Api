

---

# Student Management System – RESTful Web API

This project is a RESTful Web API for managing student records. It is developed using ASP.NET Core Web API as part of the Software Construction and Development Practice

The API allows users to create, view, update, and delete student records. Instead of using a real database, it uses an in-memory List collection to store data and simulate database behavior.

---

## Features

* Create new student records
* Retrieve all students
* Retrieve a student by ID
* Update student information
* Delete student records
* Input validation and error handling
* Proper HTTP status codes
* Clean layered structure (Model → Service → Controller)

---

## Student Model Fields

Each student record contains:

* StudentId
* Name
* Email
* Department
* CGPA (range 0–4)

Validation rules are applied:

* Required fields cannot be empty
* Email must be in valid format
* CGPA must be between 0 and 4

---

## Project Structure

```
HW1_SCD
 ├── Models
 │    └── Student.cs
 ├── Services
 │    └── StudentService.cs
 ├── Controllers
 │    └── StudentController.cs
 └── Program.cs
```

---

## In-Memory Repository

StudentService acts as an in-memory repository:

* Stores data in a List collection
* Performs CRUD operations
* Generates auto-increment StudentId
* Separates business logic from controller
* Simulates database behavior without using a real DB

Note: Data is not permanent. When the app stops, all records are lost.

---

## REST API Endpoints

### Get all students

```
GET /api/student
```

### Get student by ID

```
GET /api/student/{id}
```

### Create student

```
POST /api/student
```

Example body:

```json
{
  "name": "Ali",
  "email": "ali@gmail.com",
  "department": "CS",
  "cgpa": 3.4
}
```

### Update student

```
PUT /api/student/{id}
```

### Delete student

```
DELETE /api/student/{id}
```

---

## HTTP Status Codes Used

* 200 — Request successful
* 201 — Resource created
* 204 — Successfully updated/deleted
* 400 — Invalid request data
* 404 — Student not found
* 500 — Server error

---

## How to Run the Project

1. Open the project in Visual Studio
2. Build the solution
3. Press **F5** or click Run
4. Swagger UI will open automatically
5. Test all endpoints using Swagger

If Swagger does not open automatically, go to:

```
https://localhost:{port}/swagger
```

---

## Testing

The API can be tested using:

* Swagger UI (built-in)
* Postman
* Browser (for GET requests)

---

## Notes

* This project is created for learning REST API design.
* No external database is used.
* Focus is on clean code, validation, and proper API behavior.


