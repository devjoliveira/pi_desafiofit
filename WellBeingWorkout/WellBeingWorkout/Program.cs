using Microsoft.EntityFrameworkCore;
using System;
using WellBeingWorkout;
using WellBeingWorkout.Data;

var builder = WebApplication.CreateBuilder(args);

builder.ApiRegister();
// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<WellBeingWorkoutContext>(options =>
    options.UseSqlite("Data Source=app.db"));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<WellBeingWorkoutContext>();
    await SeedingService.SeedAsync(dbContext);
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
