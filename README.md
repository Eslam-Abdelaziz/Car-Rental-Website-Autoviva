# Car Rental Website ( Autoviva )

Welcome to our Car Rental Website! This project is an online platform designed to facilitate car rental services. Whether you're a customer looking to rent a car or an administrator managing the rental fleet, our website provides a seamless experience for all users.

## Description

The Car Rental Website simplifies the process of renting vehicles for users and managing inventory for administrators. It includes features such as user registration, car browsing, booking management, and administrative tools for inventory management.

## Main Features

### 1. User Registration and Authentication
-  Users can register accounts and log in securely to access rental services, using multiple platform as Facebook, Google or Email and Password.

### 2. Car Browsing and Booking
- Browse through available cars with detailed information including specifications, availability, and rental rates.
- Reserve cars for specific dates and durations.

### 3. User Profile Management
- Users can manage their rental history, update personal information, and view current bookings or cancel it for a limited hours after booking it.

### 4. Admin Panel
- Administrators have access to tools for managing car listings, user accounts, bookings, and other site settings.

## User Roles

### 1. User
- View and search for Cars.
- Rent car for specific dates and durations
- Add cars to his favourite list.
- View detailed Car Specification.
- Manage user profile, including rent history.
- Cancel renting for a limited hours.

### 2. Admin
- Access the admin dashboard.
- Monitor and manage cars.
- View and manage user accounts.
- Manage branches and managers.
- Access all rent history.

### 3. Manager
- Access all rent history for his branch.
- Monitor and manage cars for his branch.

## Technologies Used

Our Application is built using the following technologies:
- **ASP.NET Core MVC:** Provides the framework for building web applications.
- **SQL Server:** Used for storing and managing data.
- **Entity Framework Core:** ORM for database operations.
- **HTML, CSS, JavaScript:** Used for frontend development.
- **Bootstrap:** Used for responsive design.
- **Windows Forms:** Used for Admin Dashboard.

## Get Started

To get started with the Attendance Management System, follow these steps:

1. Clone the repository to your local machine.
    ```bash
        git clone https://github.com/Eslam-Abdelaziz/Car-Rental-Website-Autoviva-.git
    ```
2. Open the project in Visual Studio.
3. Make CarRent.Data as Startup project.
4. Build the project to resolve any dependencies.
4. open Package Manager Console type "update-database" and hit Enter.
5. Make CarInsertData as Startup project then run the project.
6. Make CarRental.UI as Startup project then run the project.
7. if you want to access admin dashboard : open solution properties.
8. select Multiple StartUp Projects option.
9. select CarRental.API and AdminPanel as start.
10. Run "Multiple StartUp Projects".
11. add admin email and password using API
12. login by them to adminn dashboard

## Contributing

Contributions are welcome! Please fork the repository, create a new branch for your feature, make your changes, and submit a pull request.

## Contact

For any questions or inquiries, contact us at [eslam.abdelaziz.momeh@gmail.com](mailto:eslam.abdelaziz.momeh@gmail.com).
