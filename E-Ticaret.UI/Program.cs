using E_Ticaret.BL.Repositories;
using E_Ticaret.DAL.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SQLContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("CS1")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(SQLRepository<>));

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
{
    opt.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    opt.LoginPath = "/admin/login"; // yetkisi olmadan giris yaptiginda login sayfasina gondermek icin yazdik
    opt.LogoutPath = "/admin/logout"; // sure doldugunda gidecegi sayfa (yani timespan uzerinde verdigimiz fromminutes 60 dk doldugunda otomatik olarak logout sayfasina yonlendirme islemi yapiyor.
});

var app = builder.Build();

if (!app.Environment.IsDevelopment()) app.UseStatusCodePagesWithRedirects("/hata/{0}");
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication(); // kimlik dogrulama
app.UseAuthorization(); // yetkilendirme

app.MapControllerRoute(name: "areas", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(name: "default", pattern: "{Controller=Home}/{Action=Index}/{id?}");

app.Run();
