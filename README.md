# Overview

This is a simple inventory tracking program written in C#. I used EFCore to communicate to the database with simple, C# objects. I also use ASP.Net to create the API's. This project is setup in the vertical slice architecture pattern. 

## Architecture Overview

```
├───Features
│   ├───Common
│   │   ├───Models
│   │   └───Repository
│   │       └───Interfaces
│   ├───Create
│   │   └───Services
│   │       └───Interfaces
│   ├───Delete
│   │   └───Services
│   │       └───Interfaces
│   ├───Get
│   │   └───Services
│   │       └───Interfaces
│   └───Update
│       └───Services
│           └───Interfaces
├───InventoryDbContext
```

Here are my models: 
[![](https://mermaid.ink/img/pako:eNptUc1qwzAMfhWj69oXCDuNltHL6NhgF1-EraaC2C6yDDVd3n1u0kNIp5P18f0h38AlT9CBGzDnHWMvGGw0bSbEHJSCuc3IfV44qjn4BZBVOPbmAwMtUE-OAw7mKOxoJf8sGJW1zvBo4zJwP5BTSZHdU_Qj6U0w-pXlD0pDtR5JOPl_jd8lOZL65LpDpW8OZPbXC0u9ryv9JHn93W7X5TpDV6Xo85q3zFqQYAOBJCD7dvGpgwU9UzscdO3p6YRlUAs2jo2KRdNXjQ46lUIbkFT6M3QnHHLbysW3po8fmynjHzOakn4?type=png)](https://mermaid.live/edit#pako:eNptUc1qwzAMfhWj69oXCDuNltHL6NhgF1-EraaC2C6yDDVd3n1u0kNIp5P18f0h38AlT9CBGzDnHWMvGGw0bSbEHJSCuc3IfV44qjn4BZBVOPbmAwMtUE-OAw7mKOxoJf8sGJW1zvBo4zJwP5BTSZHdU_Qj6U0w-pXlD0pDtR5JOPl_jd8lOZL65LpDpW8OZPbXC0u9ryv9JHn93W7X5TpDV6Xo85q3zFqQYAOBJCD7dvGpgwU9UzscdO3p6YRlUAs2jo2KRdNXjQ46lUIbkFT6M3QnHHLbysW3po8fmynjHzOakn4)

[Software Demo Video](https://youtu.be/_oL1yvsEo3Q)

# Development Environment

IDE: Visual Studio

Packages: 
- Entity Framework Core
- Entity Framework Core Design
- Entity Framework Core Sqlite

# Useful Websites

{Make a list of websites that you found helpful in this project}

- [EF Core Overview](https://learn.microsoft.com/en-us/ef/core/)
- [Vertical Slice Overview](https://www.jimmybogard.com/vertical-slice-architecture/)
- [Vertical Slice Architecture in ASP.NET Core](https://blog.ndepend.com/vertical-slice-architecture-in-asp-net-core/)

# Future Work

- Inventory Search & Filtering
   - Allow users to search and filter the inventory by various criteria such as Name, Price Range, Brand, or Expiry Date.
- Inventory Restocking Notification
   - Notify the system or user when the quantity of an item falls below a certain threshold.
- Item Reviews and Ratings
   - Allow customers to leave reviews and ratings for specific items.