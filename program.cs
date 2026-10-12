var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("""
    <html>
      <head><title>Azure App Service Demo</title></head>
      <body style="font-family: Arial; padding: 40px;">
        <h1>Hello from Azure App Service!</h1>
        <p>My first .NET 10 deployment is working.</p>
      </body>
    </html>
    """, "text/html"));

app.Run();
