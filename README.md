# Book Store Web Application

This is a web application built with ASP.NET Core MVC and Entity Framework for managing a book store. Users can browse through the available books, view details, and make purchases.

## Features

- **Browse Books:** Users can explore a list of available books.
- **Book Details:** View detailed information about a specific book.
- **Shopping Cart:** Add books to a shopping cart and proceed to checkout.
- **User Authentication:** Secure user authentication and authorization.
- **Admin Panel:** Admins can manage books, categories, and user orders.

## Technologies Used

- **ASP.NET Core MVC:** Web application framework.
- **Entity Framework Core:** Object-Relational Mapping (ORM) for database interaction.
- **SQL Server:** Database for storing book and user information.
- **Bootstrap:** Front-end framework for responsive design.
- **Identity Framework:** For user authentication and authorization.

## Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (optional)

## Getting Started

1. Clone the repository:

   ```bash
    git clone https://github.com/aminul-islam-niloy/Book-Shop-MVC.git
   ```

   Add identity in Scaffolding <br>
   Update database and update database link

2. Create Model: Book,Genere,Order,ShoppingCart,OrderDetails,CartDetails,OrderStatus etc and Link them each other

   2.1 Add DbSet so that change reflect to the database <br>
   2.2 Add-Migration Added-Tables<br>
   2.3 Update-Database

3. Authintication and Authorization: <br>
   3.1 assigning role to user <br>
   3.2 Add Constans and Eenum rule<br>
   3.3 Add DbSeed in Data and adding some role to database (admin) <br>
   3.4 Add scope and configuree in builder.services and comment it<br>
   3.5 Add Role Direct admin in View,LoginPartial
