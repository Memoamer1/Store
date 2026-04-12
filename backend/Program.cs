using Microsoft.EntityFrameworkCore;
using project.Data;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// ===== Database Context =====
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// ===== MVC =====
builder.Services.AddControllersWithViews();

// ===== Session =====
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// ===== Kestrel («Œ Ì«—Ì ·Ê ⁄«Ì“ ports „⁄Ì‰…) =====
builder.WebHost.UseUrls("http://localhost:5050", "https://localhost:7225");

var app = builder.Build();

// ===== Error handling =====
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// „Â„ Ãœ«  — Ì»Â«
app.UseSession();

app.UseAuthorization();

// ===== Default Route =====
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();