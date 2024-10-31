
# Cars Management Web App

The **Cars Management Web App** is a system for managing car data using **ASP.NET Core MVC**, **Entity Framework Core**, and **SQLite**. This app provides an easy-to-use interface for performing **CRUD** (Create, Read, Update, Delete) operations on car records with a simple and interactive UI.

---

## 🚀 Features

- **Add New Cars**: Add a new car entry with details such as type and model.
- **View Car List**: Display a comprehensive list of all registered cars.
- **Update Car Information**: Edit the available information for any car.
- **Delete Car**: Remove a car from the database.
- **Data Validation**: Ensure the correctness of input data, such as requiring a 4-digit year for the car model (e.g., 2023).

---

## 🛠️ Technologies Used

- **ASP.NET Core 8**: Backend framework.
- **Entity Framework Core**: ORM for database management.
- **SQLite**: Lightweight, easy-to-configure database.
- **Bootstrap**: Responsive design for adaptable UI.

---

## ⚙️ Setup

To start using the project, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/KAJOiq/Cars-Management-Web-App.git
---
#Navigate to the project directory:

   ```bash
   cd Cars-Management-Web-App
##Install dependencies:
---
   ```bash
dotnet restore
##Update the database:
---
   ```bash
dotnet ef database update
##Run the application:
---
   ```bash
dotnet run
---
##📖 Usage
Add a Car: Navigate to the Add Car page, fill in the required fields, and click Save.
View All Cars: Go to the Cars List page to view all registered cars.
Edit or Delete: Use the Edit and Delete buttons next to each car to update or remove records.
---
##🗂️ Project Structure
The project is organized as follows:
Controllers/: Contains the files for handling requests (CRUD operations).
Models/: Contains the entities representing database tables.
Views/: Contains Razor View files for each page.
Data/: Configures and manages the database settings.
