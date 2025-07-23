
# 📝 To-Do List API

A simple, modular, and secure To-Do List API built with **ASP.NET Core** using:

- ✅ Entity Framework Core (Code First)
- ✅ Repository & Unit of Work Pattern
- ✅ FluentValidation
- ✅ JWT-based Authentication
- ✅ Asynchronous operations for performance
- ✅ Swagger API documentation

---

## 🛠 **Setup Instructions**

1. Clone the repository:
   ```bash
   git clone git@github.com:Abdelmageed99/To-DoListAPI.git
   cd todo-api
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Run the application:
   ```bash
   dotnet run
   ```

4. API will be available at:
   ```bash
   http://localhost:5000
   ```

---

## 🔐 Authentication

| Method | Endpoint               | Description                |
|--------|------------------------|----------------------------|
| POST   | `/api/auth/register`   | Register a new user        |
| POST   | `/api/auth/login`      | User login (returns token) |

Use the JWT token from login in `Authorization` header:

```
Authorization: Bearer YOUR_ACCESS_TOKEN
```

---

## 🚀 API Endpoints

### 📌 To-Do Endpoints

| Method | Endpoint             | Description                          |
|--------|----------------------|--------------------------------------|
| GET    | `/api/todo`          | Retrieve all to-do items (paginated) |
| GET    | `/api/todo/{id}`     | Retrieve a specific to-do item       |
| POST   | `/api/todo`          | Create a new to-do item              |
| PUT    | `/api/todo/{id}`     | Update a to-do item                  |
| DELETE | `/api/todo/{id}`     | Delete a to-do item                  |

---

## 📦 Request & Response Examples

### 🔹 Get All To-Do Items

**Request:**
```http
GET /api/todo
```

**Response:**
```json
[
  {
    "id": 1,
    "title": "Buy groceries",
    "description": "Milk, Bread, Eggs",
    "isCompleted": false
  }
]
```

---

### 🔹 Get To-Do Item by ID

```http
GET /api/todo/1
```

```json
{
  "id": 1,
  "title": "Buy groceries",
  "description": "Milk, Bread, Eggs",
  "isCompleted": false
}
```

---

### 🔹 Create a New To-Do Item

```http
POST /api/todo
Content-Type: application/json
```

```json
{
  "title": "Read a book",
  "description": "Read a chapter from ASP.NET Core book"
}
```

---

### 🔹 Update To-Do Item

```http
PUT /api/todo/1
```

```json
{
  "title": "Buy groceries",
  "description": "Milk, Bread, Eggs, and Butter"
}
```

---

### 🔹 Delete To-Do Item

```http
DELETE /api/todo/1
```

```json
{
  "message": "To-Do item deleted successfully"
}
```

---

### 🔹 Register

```http
POST /api/auth/register
```

```json
{
  "fName": "John",
  "lName": "Doe",
  "email": "john@example.com",
  "userName": "john_doe",
  "password": "P@ssword123"
}
```

---

### 🔹 Login

```http
POST /api/auth/login
```

```json
{
  "userName": "john_doe",
  "password": "P@ssword123"
}
```

**Response:**
```json
{
  "token": "eyJhbGciOiJIUzI1..."
}
```

---

## 🔧 Features

- 🧱 **monolithic Architecture**
- 💾 **EF Core Code First** with SQL Server
- 🧪 **FluentValidation**
- 🔁 **Repository Pattern**
- 🔐 **JWT Authentication**
- 📄 **Swagger API Docs**
- 🧵 **Global Exception Handling**
- ⚡ **Async/Await** for performance

---


