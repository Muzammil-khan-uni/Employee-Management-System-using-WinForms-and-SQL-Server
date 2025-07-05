# Employee Management System using WinForms and SQL Server

LOAD:

![image alt](https://github.com/Muzammil-khan-uni/Employee-Management-System-using-WinForms-and-SQL-Server/blob/main/Output%20SS/LOAD.png)

ADD:

![image alt](https://github.com/Muzammil-khan-uni/Employee-Management-System-using-WinForms-and-SQL-Server/blob/main/Output%20SS/ADD.png)

UPDATE:

![image alt](https://github.com/Muzammil-khan-uni/Employee-Management-System-using-WinForms-and-SQL-Server/blob/main/Output%20SS/UPDATE.png)

DELETE:

 ![image alt](https://github.com/Muzammil-khan-uni/Employee-Management-System-using-WinForms-and-SQL-Server/blob/main/Output%20SS/DELETE.png)

The Employee Management System is a simple and user-friendly desktop application developed using C# WinForms that allows users to perform CRUD operations (Create, Read, Update, Delete) on employee data stored in a SQL Server database.

This project helps users manage employee records efficiently with a GUI interface.

🧰 Technologies Used:

| Component            | Technology                                |
| -------------------- | ----------------------------------------- |
| Programming Language | C#                                        |
| Framework            | .NET Framework (WinForms)                 |
| Database             | SQL Server                                |
| ADO.NET              | SqlConnection, SqlCommand, SqlDataAdapter |
| UI Controls          | DataGridView, TextBoxes, Buttons, Labels  |

📂 Project Structure:

1. ConnectDB.cs

This class handles all database connectivity and operations.
-It:

Reads the connection string from App.config.

Contains two main methods:

ExecuteNonQuery(): Used for INSERT, UPDATE, and DELETE.

ExecuteQuery(): Used for SELECT queries and returns data in a DataTable.

2. Form1.cs

This is the main user interface form for interacting with the database.

Features:

Load All Employees: Fetches and displays all employee records in a DataGridView.

Add Employee: Inserts a new employee using values from text fields.

Update Employee: Updates existing employee information based on the given ID.

Delete Employee: Deletes an employee from the database based on the given ID.

Clear Fields: Clears all input fields for fresh entry.

3. Form1.Designer.cs

Auto-generated code by Visual Studio that defines the layout of the form:

TextBoxes for ID, Name, Position, Salary.

Buttons for Load, Add, Update, Delete, Clear.

A DataGridView for displaying employee records.

Labels for UI clarity.

🔄 CRUD Operations Explained:

| Operation  | Action                                                                          |
| ---------- | ------------------------------------------------------------------------------- |
| **Create** | `btnadd_Click` inserts a new employee with parameters to avoid SQL injection.   |
| **Read**   | `btnload_Click` uses a SELECT query to fetch all employee records.              |
| **Update** | `btnupdate_Click` modifies employee details based on the given `ID`.            |
| **Delete** | `btndelete_Click` removes the employee from the table using the specified `ID`. |
| **Clear**  | `btnclear_Click` resets the input fields for new entry.                         |



