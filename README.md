# 🧪 Lab 1: Building a Secure RESTful API with JWT Authentication

## 📌 Overview

In this lab, you will build a secure RESTful API using ASP.NET Core.

You will implement:

* CRUD operations
* JWT Authentication
* API security using `[Authorize]`
* Centralized error handling

---

## 🎯 Learning Objectives

By the end of this lab, you will:

* Build RESTful APIs
* Implement JWT authentication
* Secure endpoints
* Handle errors globally

---

## ⚙️ Prerequisites

* .NET 6 or later
* VS Code / Visual Studio
* Postman or Swagger
* Basic understanding of APIs

---

## 🚀 Getting Started

### 1. Open the file Microland.API

```
cd Microloand.API
```

### 2. Run the Application

```
dotnet restore
dotnet run
```

### 3. Open Swagger

```
http://localhost:5129/swagger
```

---

## 🧩 What is Already Implemented

* Project structure
* Database setup (SQLite)
* Controllers and models
* Middleware registration

---

## 🛠️ Tasks to Complete

### ✅ Task 1: Implement CRUD APIs

Complete methods in:

```
EmployeesController.cs
```

---

### ✅ Task 2: Implement JWT Authentication

* Complete `JwtService.cs`
* Generate token in `AuthController`

---

### ✅ Task 3: Secure APIs

* Configure JWT in `Program.cs`
* Apply `[Authorize]` on EmployeesController

---

### ✅ Task 4: Exception Handling

* Complete `ExceptionMiddleware`

---

## 🧪 Testing Steps

1. Call `/api/auth/login`
2. Copy JWT token
3. Click "Authorize" in Swagger
4. Test Employee APIs

---

## ✅ Success Criteria

* CRUD works
* JWT token generated
* APIs secured
* Unauthorized returns 401
* Errors handled globally

---

## 💡 Notes

* Username: `admin`
* Password: `password`

---

## 🎉 Congratulations!

You have built a secure backend API with JWT authentication 🚀
