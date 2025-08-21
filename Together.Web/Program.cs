using Together.Application;
using Together.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddControllersWithViews();
    builder.Services.AddApplication();
    builder.Services.AddInfrastructure();
}
var app = builder.Build();
{
    app.MapGet("/", () => "Hello World!");
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
}

app.Run();
