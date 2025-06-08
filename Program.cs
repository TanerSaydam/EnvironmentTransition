var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .AddJsonFile(
    "appsettings.json",
    optional: true,
    reloadOnChange: false
    );

var key = builder.Configuration.GetSection("Key").Value;

Console.WriteLine(key);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
