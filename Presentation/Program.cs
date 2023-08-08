using Business.Services.Admin.Abstract;
using Business.Services.Admin.Concrete;
using Common.Entities;
using DataAccess.Contexts;
using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Concrete;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

#region builder
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Default"), x=>x.MigrationsAssembly("DataAccess")));
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredUniqueChars = 0;
    options.Password.RequireDigit = true;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = true;
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<AppDbContext>();
#endregion

builder.Services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

#region app
var app = builder.Build();
app.MapDefaultControllerRoute();
app.Run();
#endregion

#region Repositories
builder.Services.AddScoped<ISliderRepository, SliderRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

#endregion

#region Services
builder.Services.AddScoped<ISliderService, SliderService>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAccountService, AccountService>();


#endregion
