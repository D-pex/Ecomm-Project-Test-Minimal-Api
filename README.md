---

# 🛒 E-Commerce Backend API

### ⚡ Built with .NET Minimal API

A modular **E-Commerce backend service** built using **ASP.NET Minimal API architecture**.
This project demonstrates **clean architecture principles**, layered design, and modern backend development practices.

The API handles core e-commerce operations such as **users, products, categories, and orders**, and exposes RESTful endpoints that can be consumed by **web, mobile, or frontend applications**.

---

# 📌 Project Overview

This repository represents a backend service designed to simulate a **basic e-commerce platform**.

It focuses on implementing:

✔ Clean architecture
✔ Service-based business logic
✔ DTO-based communication
✔ RESTful APIs
✔ Scalable modular structure

These patterns are widely used in **production-grade backend systems** to improve maintainability and scalability.

---

# 🏗 Architecture

The project follows a **layered architecture** separating concerns across multiple modules.

```
Ecomm-Project-Test-Minimal-Api
│
├── 📦 Core
│   ├── Entities
│   ├── DTOs
│   └── Requests
│
├── 🗄 Persistence
│   ├── DbContext
│   ├── Configurations
│   └── Migrations
│
├── ⚙ Services
│   └── Business Logic
│
├── 🌐 Web
│   ├── Minimal API Endpoints
│   └── Program.cs
│
└── 📄 Solution File (.sln)
```

---

# 📂 Layer Responsibilities

### 📦 Core

Contains the **domain models and contracts**.

* Entities (database models)
* DTOs (Data Transfer Objects)
* Request models

---

### 🗄 Persistence

Responsible for **database operations**.

* DbContext
* Entity configurations
* Database migrations

---

### ⚙ Services

Handles the **business logic layer**.

* Application services
* Data validation
* Processing rules

---

### 🌐 Web

The **entry point of the application**.

* Minimal API endpoints
* Dependency Injection configuration
* Application startup logic

---

# ✨ Features

🚀 Minimal API architecture
📦 Modular layered design
🔄 CRUD operations for core entities
📑 DTO pattern for data transfer
🗄 Entity Framework Core integration
⚙ Dependency Injection
🧩 Clean separation of concerns

---

# 🛠 Technologies Used

| Technology               | Purpose                |
| ------------------------ | ---------------------- |
| 💻 .NET                  | Backend framework      |
| 🌐 ASP.NET Minimal API   | API endpoint framework |
| 🗄 Entity Framework Core | ORM                    |
| 🧾 SQL Server            | Database               |
| 🧠 C#                    | Programming language   |
| 🔧 Git                   | Version control        |

---

# 🚀 Getting Started

## 📋 Prerequisites

Make sure the following are installed:

* ✔ .NET SDK (7 or later)
* ✔ SQL Server
* ✔ Git
* ✔ IDE (JetBrains Rider / Visual Studio / VS Code)

---

# ⚙ Installation

### 1️⃣ Clone the repository

```bash
git clone https://github.com/D-pex/Ecomm-Project-Test-Minimal-Api.git
```

---

### 2️⃣ Navigate to project folder

```bash
cd Ecomm-Project-Test-Minimal-Api
```

---

### 3️⃣ Restore dependencies

```bash
dotnet restore
```

---

### 4️⃣ Run the application

```bash
dotnet run
```

API will start at:

```
https://localhost:5001
```

---

# 🔗 Example API Endpoints

| Method | Endpoint         | Description           |
| ------ | ---------------- | --------------------- |
| GET    | `/products`      | Retrieve all products |
| GET    | `/products/{id}` | Get product by ID     |
| POST   | `/products`      | Create new product    |
| PUT    | `/products/{id}` | Update product        |
| DELETE | `/products/{id}` | Delete product        |

---

# 📦 Example Entity

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
}
```

---

# 🎯 Development Goals

This project was built to practice and demonstrate:

* Clean architecture principles
* Minimal API development
* API design best practices
* DTO-based communication
* Layered backend structure

---

# 🔮 Future Improvements

Possible future enhancements:

🔐 JWT Authentication
👤 Role-based authorization
💳 Payment gateway integration
📊 API logging and monitoring
🧪 Unit testing
🐳 Docker containerization
📚 Swagger / OpenAPI documentation

---

# 👨‍💻 Author

**D-pex**

🔗 GitHub
[https://github.com/D-pex](https://github.com/D-pex)

---

# 📜 License

This project is intended for **educational and development purposes**.

---
