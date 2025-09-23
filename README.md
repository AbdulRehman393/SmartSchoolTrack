# 🎓 SmartSchoolTrack

SmartSchoolTrack is a **School Management System** built with **C# WinForms** and **SQL Server**.  
It provides an easy-to-use desktop interface for managing school operations such as student records, teacher information, attendance, enrollment, and more – all from one central dashboard.

---

## 🚀 Features
- 👨‍🎓 **Student Management** – Add, edit, and view student details.  
- 📘 **Subject Management** – Manage subjects taught in the school.  
- 👨‍🏫 **Teacher Management** – Store and update teacher records.  
- 🏫 **Section Management** – Organize students into sections/classes.  
- 📑 **Enrollment** – Enroll students into subjects and sections.  
- ✅ **Attendance** – Record and track daily student attendance.  
- 📊 **Dashboard** – View total students, teachers, enrollments, and attendance stats at a glance.  
- 🔐 **Login System** – Secure login with authentication.  

---

## 🛠️ Tech Stack
- **Language:** C#  
- **Framework:** .NET Framework (WinForms)  
- **Database:** Microsoft SQL Server  
- **IDE:** Visual Studio 2022  

---

## 📷 Screenshots  

| Login Page | Dashboard | Student Management | Attendance |
|------------|-----------|--------------------|------------|
| ![Login](screenshots/login.png) | ![Dashboard](screenshots/dashboard.png) | ![Students](screenshots/students.png) | ![Attendance](screenshots/attendance.png) |

> Place your 4 screenshots in a folder named **`screenshots/`** inside the repository.  

---

## ⚡ Getting Started

### Prerequisites
- Visual Studio 2022 (or later)  
- Microsoft SQL Server installed  

### Setup
1. Clone the repository:  
   ```bash
   git clone https://github.com/your-username/SmartSchoolTrack.git
Open the solution in Visual Studio.

Update the connection string in Form1.cs with your SQL Server details:

csharp
Copy code
SqlConnection con = new SqlConnection(@"Data Source=YOUR_SERVER;Initial Catalog=schooldb;Integrated Security=True");
Run the SQL script (schooldb.sql) to create the database schema.

Build and run the project.

👨‍💻 Author
Abdul Rehman
<br>
<a href="https://github.com/AbdulRehman393" target="_blank">
<img src="https://img.shields.io/badge/GitHub-000?style=for-the-badge&logo=github&logoColor=white"/>
</a>
