using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FilmList_CW_04_10.Data;
using FilmList_CW_04_10.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<FilmList_CW_04_10Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FilmList_CW_04_10Context") ?? throw new InvalidOperationException("Connection string 'FilmList_CW_04_10Context' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
