using DataAccess1.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
var connectionstring = builder.Configuration["ConnectionStrings:Default"];
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(connectionstring);
});         
var app = builder.Build();
app.UseStaticFiles();


// handle http request



app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}"
    ) ;   //MIDDLEWEARler (yeni yoxlnis ve ya merhele kimi)




app.Run();    //Middlewearleri sonlandirir
