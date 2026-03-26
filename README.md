# JwtAuthDemo

![.NET](https://img.shields.io/badge/-.NET-blue?logo=.net&logoColor=white)

## 📝 Description

JwtAuthDemo is a robust reference implementation designed to showcase secure user authentication and authorization within the .NET ecosystem using JSON Web Tokens (JWT). This project serves as a practical guide for developers looking to integrate industry-standard security practices into their ASP.NET Core applications. It covers essential security workflows, including token generation, validation, and role-based access control, providing a solid foundation for building scalable and secure web APIs.

## 🛠️ Tech Stack

- 🔷 .NET


## 📦 Key Dependencies

```
DocumentFormat.OpenXml: 3.5.1
Microsoft.AspNetCore.Authentication.JwtBearer: 10.0.5
Microsoft.AspNetCore.OpenApi: 10.0.5
Microsoft.EntityFrameworkCore: 10.0.5
Microsoft.EntityFrameworkCore.SqlServer: 10.0.5
System.IdentityModel.Tokens.Jwt: 8.17.0
```

## 📁 Project Structure

```
.
├── JwtAuthDemo
│   ├── Controllers
│   │   ├── AuthorizeController.cs
│   │   ├── ProductController.cs
│   │   └── WeatherForecastController.cs
│   ├── Data
│   │   └── ApplicationDBContext.cs
│   ├── JwtAuthDemo.csproj
│   ├── JwtAuthDemo.http
│   ├── Migrations
│   │   ├── 20260325183110_JwtAuthentication.Designer.cs
│   │   ├── 20260325183110_JwtAuthentication.cs
│   │   ├── 20260325184104_JwtAuthentication1.Designer.cs
│   │   ├── 20260325184104_JwtAuthentication1.cs
│   │   ├── 20260325184939_JwtAuthentication2.Designer.cs
│   │   ├── 20260325184939_JwtAuthentication2.cs
│   │   ├── 20260326125949_JwtAuthDemo.Designer.cs
│   │   ├── 20260326125949_JwtAuthDemo.cs
│   │   └── ApplicationDBContextModelSnapshot.cs
│   ├── Models
│   │   ├── Product.cs
│   │   ├── RefreshToken.cs
│   │   ├── TokenModel.cs
│   │   └── User.cs
│   ├── Program.cs
│   ├── Properties
│   │   └── launchSettings.json
│   ├── Service
│   │   └── TokenService.cs
│   ├── WeatherForecast.cs
│   ├── appsettings.Development.json
│   └── appsettings.json
└── JwtAuthDemo.slnx
```

## 🛠️ Development Setup

### .NET Setup
1. Install [.NET SDK](https://dotnet.microsoft.com/)
2. Restore dependencies: `dotnet restore`
3. Build the project: `dotnet build`
4. Run the project: `dotnet run`


## 👥 Contributing

Contributions are welcome! Here's how you can help:

1. **Fork** the repository
2. **Clone** your fork: `git clone https://github.com/sachinhd517/JwtAuthDemo.git`
3. **Create** a new branch: `git checkout -b feature/your-feature`
4. **Commit** your changes: `git commit -am 'Add some feature'`
5. **Push** to your branch: `git push origin feature/your-feature`
6. **Open** a pull request

Please ensure your code follows the project's style guidelines and includes tests where applicable.

---
