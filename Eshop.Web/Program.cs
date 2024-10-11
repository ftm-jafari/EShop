using Eshop.Infra.Data.Context;
using Eshop.Infra.IoC.Container;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region Config Services

builder.Services.RegisterServices();

#endregion


#region Config Db Context

string connectionString = builder.Configuration.GetConnectionString("EshopConnectionString");

builder.Services.AddDbContext<EshopContext>(options =>
{
    options.UseSqlServer(connectionString);
});

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
