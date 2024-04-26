using ASPDotNetCEmptyDI.DAL;
using ASPDotNetCEmptyDI.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

builder.Services.AddTransient<IStudentRepository, StudentRepository>();
//builder.Services.AddSingleton<IStudentRepository, IStudentRepository>();
//builder.Services.AddScoped<IStudentRepository, IStudentRepository>();

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>endpoints.MapDefaultControllerRoute());

//app.MapGet("/", () => "Hello World!");

app.Run();
