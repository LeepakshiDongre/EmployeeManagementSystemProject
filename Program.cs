using EmployeeManagementSystemProject.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Register the DbContext
builder.Services.AddDbContext<EmployeeManagementSystemProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeManagementSystemProjectContext")
    ?? throw new InvalidOperationException("Connection string 'EmployeeManagementSystemProjectContext' not found.")));

// ✅ Add session service
builder.Services.AddSession();

// Add MVC services
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

// ✅ Enable session middleware before authorization
app.UseSession();

// Authorization
app.UseAuthorization();

// Define default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();