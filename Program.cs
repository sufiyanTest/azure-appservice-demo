```csharp
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Hello! My first Azure App Service website is running.");

app.Run();
```
