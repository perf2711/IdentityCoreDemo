# ASP.NET Core Identity - Demo
Projekt zawierający podstawowe wykorzystanie biblioteki Identity.

Zakładane są dwie wersje projektu - jedna z domyślnym typem identyfikatorów `string`, drugi z podmienionym na `System.Guid`. Druga wersja znajduje się na branchu `CustomDataType`.

### Kompilacja
Aby poprawnie skompilować projekt, wymagany jest .NET Core SDK.
https://www.microsoft.com/net/core#windowscmd

Po zainstalowaniu SDK należy wejść za pomocą konsoli do folderu z plikiem `.csproj`, a następnie wykonać komendy:
```
dotnet restore
dotnet build
```

Należy także zaktualizować bazę danych. Wymagany jest SQL Server. Domyślna konfiguracja połączenia zakłada połączenie:
```
Server=localhost;Database=IdentityDemo;Trusted_Connection=True;
```
W przypadku innego połączenia należy zmienić zmienną `connectionString` w metodzie `ConfigureServices` w klasie `Startup.cs`.

W celu zaktualizowania bazy danych należy wykonać komendę:
```
dotnet ef database update
```

### Uruchamianie
Aby uruchomić projekt po skompilowaniu, należy wykonać komendę:
```
dotnet run
```