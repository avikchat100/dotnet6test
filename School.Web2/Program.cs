using Microsoft.EntityFrameworkCore;
using School.Data;
using School.Lib.Services.StudentService;
using System.Reflection;
using static School.Lib.Services.Iservice;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddControllersWithViews();
builder.Services.AddMvc(options => options.EnableEndpointRouting=false);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                        builder.Configuration.GetConnectionString("SchoolDatabase")
                        ));

builder.Services.AddScoped<IStudentService, StudentService>();



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

//app.MapControllerRoute(
app.UseMvcWithDefaultRoute();
    //name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
