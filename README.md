
# HotelReservationApp

HotelReservationApp is a desktop application built with Windows Forms in C# (.NET Framework) for managing hotel reservations, clients, and rooms efficiently.

## Features

- Add hotel rooms
- Manage client information
- Create and view reservations
- Generate invoice text files for each reservation
- View revenue statistics using charts
- Filter reservations by client, room type, and date range
- SQL Server database integration

## Technologies Used

- C# (.NET Framework 4.7.2)
- Windows Forms (WinForms)
- SQL Server
- ADO.NET
- Visual Studio 2019+

## Getting Started

### Requirements

- Visual Studio 2019 or newer
- .NET Framework 4.7.2
- SQL Server (Express or Standard)

### Setup

1. Clone this repository:
   ```bash
   git clone https://github.com/gladisBraete/HotelReservationApp.git
   ```

2. Open `HotelReservationApp.sln` in Visual Studio

3. Restore the SQL Server database using `GladisHotelzz.bak` in SSMS

4. Update `App.config` with the correct database connection string if necessary

5. Build and run the application (press `F5`)
