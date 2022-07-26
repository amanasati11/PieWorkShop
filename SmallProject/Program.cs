using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmallProject.Models;

var builder = WebApplication.CreateBuilder(args);

string connString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});

// Identity
builder.Services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<AppDbContext>();


// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=List}/{id?}");

app.MapRazorPages();

app.Run();
