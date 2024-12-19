using Examen.ApplicationCore.Interfaces;
using Examen.ApplicationCore.Services;
using Examen.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


//injection de dépendance
builder.Services.AddDbContext<DbContext, GFContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IChansonService, ChansonServiceImpl>();
builder.Services.AddScoped<IArtisteService, ArtisteServiceImpl>();
builder.Services.AddScoped<IConcertService, ConcertServiceImpl>();
builder.Services.AddScoped<IFestivalService, FestivalServiceImpl>();














var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
