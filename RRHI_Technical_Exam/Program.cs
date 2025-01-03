using Microsoft.EntityFrameworkCore;
using RRHI_Technical_Exam.Data;
using RRHI_Technical_Exam.Interfaces;
using RRHI_Technical_Exam.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins", builder =>
    {
        builder.AllowAnyOrigin()  // Allows all origins
               .AllowAnyMethod()  // Allows any HTTP method (GET, POST, PUT, DELETE, etc.)
               .AllowAnyHeader();  // Allows any headers
    });
});

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAllOrigins");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
