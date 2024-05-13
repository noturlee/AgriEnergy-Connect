using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register session services
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout
    options.Cookie.HttpOnly = true; // Secure session cookie
    options.Cookie.IsEssential = true; // Required for GDPR compliance
});

// Register your DbContext with a connection string
builder.Services.AddDbContext<FireBasics.Models.AgrienergyContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("AgrienergyConnection");
    options.UseSqlServer(connectionString);
});



var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting(); // UseRouting comes before UseSession

// Ensure session middleware is used
app.UseSession(); // Ensure session is initialized before authorization

app.UseAuthorization(); // Authorization comes after UseSession

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Default route


app.Run();
