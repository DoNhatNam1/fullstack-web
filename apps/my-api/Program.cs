// Program.cs
using Microsoft.EntityFrameworkCore;
using FullstackWeb.MyApi.Models; // Thay YourNamespace bằng namespace thực tế của bạn

var builder = WebApplication.CreateBuilder(args);

// Cấu hình kết nối PostgreSQL
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Database=finaldb;Username=postgres;Password=postgres"));
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();