### Factory.Solution

_By Jeremy Banka_

## Technologies Used

- 🎵 C# / .NET 5 Framework
- 🎛️ ASP.NET Core Server
- 👇 Entity Framework Core
- 🧮 MySQL Database
- 🪒 Razor Templating
- 💅 SCSS to CSS via Ritwick's Live Sass Compiler
- 🛠️ Tooling: Omnisharp
- 🅰️ Fonts: Verdana & Charter by Matthew Carter

## Description

This website is an exercise in building many-to-many relationships in a MySQL database using MS Entity Framework.

## Setup/Installation Requirements

- Get the source code: `$ git clone https://github.com/jeremybanka/Factory.Solution`
- Set up necessary database schema
  - Install Entity Framework CLI: `$ dotnet tool install --global dotnet-ef`
  - Build your database: in `Factory/`, run `dotnet ef database update`
- Add `appsettings.json` in `Factory/` and paste in the following text:

  ```json
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=hair_salon;uid=root;pwd=************;"
    }
  }
  ```

  except, instead of `************` put your password for MySQL.

- Compile and run the app as you save changes: `$ dotnet watch run` in `Factory/` (This command will also install necessary dependencies.)

## Known Bugs

- none identified

## License

Gnu Public License ^3.0

## Contact Information

hello at jeremybanka dot com
