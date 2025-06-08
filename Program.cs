var builder = WebApplication.CreateBuilder(args);

var env = builder.Environment.EnvironmentName; // Development // Production

builder.Configuration
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
    //.AddJsonFile($"appsettings.{env}.json", optional: true, reloadOnChange: false)
    ;

var con = builder.Configuration.GetSection("SqlCon").Value;

Console.WriteLine(con);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
