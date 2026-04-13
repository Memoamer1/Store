# 🛒 Store Backend API

A robust and scalable backend system for an online fashion store, built using ASP.NET Core.
This project provides RESTful APIs to manage products, users, orders, and shopping cart functionality.

---

## 🚀 Features

* User Authentication & Authorization
* Product Management (CRUD Operations)
* Shopping Cart System
* Order Processing
* Clean Architecture
* RESTful API Design

---

## 🛠️ Technologies Used

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* LINQ
* Dependency Injection

---

## 📂 Project Structure

```
/Controllers
/Models
/Data
/Repositories
/Services
```

---

## ⚙️ Getting Started

### Prerequisites

* .NET SDK
* SQL Server
* Visual Studio or VS Code

---

### Installation

1. Clone the repository:

```
git clone https://github.com/Memoamer1/Store.git
```

2. Navigate to the project folder:

```
cd backend
```

3. Update database connection string in:

```
appsettings.json
```

4. Apply migrations:

```
Update-Database
```

5. Run the project:

```
dotnet run
```

---

## 🔗 API Endpoints (Examples)

| Method | Endpoint      | Description      |
| ------ | ------------- | ---------------- |
| GET    | /api/products | Get all products |
| POST   | /api/products | Create product   |
| PUT    | /api/products | Update product   |
| DELETE | /api/products | Delete product   |

---

## 📌 Future Improvements

* Payment Integration
* Admin Dashboard
* Product Reviews & Ratings
* JWT Authentication Enhancement

---

## 👨‍💻 Author

Developed by Memo Amer

---

## 📄 License

This project is for educational purposes.
