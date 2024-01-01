using Microsoft.EntityFrameworkCore;
using YavinOffice.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SiteVisitorDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("YavinOfficeConnection"));
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseDeveloperExceptionPage();

app.UseStaticFiles();

app.MapDefaultControllerRoute();

app.Run();
