using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Presentation.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<CollectContext>(options => options.UseSqlite(
    builder.Configuration.GetConnectionString("localDB")));

builder.Services.AddTransient<IPeopleRepository, PeopleRepository>();

var app = builder.Build();

app.Use(async (context, next) =>
{
    await next();
    if(context.Response.StatusCode == 404)
    {
        context.Request.Path = "/NotFound";
        await next();
    }
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=People}/{action=Index}/{id?}");

app.Run();

