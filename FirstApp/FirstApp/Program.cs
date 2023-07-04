var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.MapGet("/group", () => "Hello P137!");
//app.MapGet("/group/type", () => "Programming");

app.MapControllerRoute(
    "default",
    "{controller=home}/{action=index}/{id?}"
    );

app.MapControllerRoute(
    "about",
    pattern:"about-us",
    defaults: new { controller = "home", action = "about" }
    );


app.Run();
