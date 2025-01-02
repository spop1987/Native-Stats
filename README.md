# Football Matches Native Stats Web Application

This project is a web application that displays recent and upcoming football matches for various leagues. It features a dynamic UI for toggling between match statuses and uses server-side rendering (SSR) for performance and scalability.

## Features
- Displays matches grouped by leagues in carousels.
- Toggle between "Recent Matches" (finished) and "Upcoming Matches" (scheduled) with dynamic filtering.
- Responsive design optimized for mobile devices.
- Server-side rendering using ASP.NET Core MVC and Razor views.

---

## Prerequisites
To run this project, ensure you have the following installed:
- .NET 8.0 SDK or later
- VS Code
- Chrome web browser
- An active internet connection

---

## Dependencies
The project uses the following NuGet packages:
- `Microsoft.Extensions.Http` (v9.0.0): For HTTP client functionality to call external APIs.
- `System.Text.Json` (v9.0.0): For JSON serialization and deserialization.

---

## Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/spop1987/Native-Stats.git
cd ./Football
dotnet build
dotnet run
