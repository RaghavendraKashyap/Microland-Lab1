using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microloand.API.Data;
using Microloand.API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// =======================
// 🔹 Database Configuration (PRE-CONFIGURED)
// =======================
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// =======================
// 🔹 Identity Configuration (PRE-CONFIGURED)
// =======================
builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>();

// =======================
// 🔹 JWT Authentication (TO BE IMPLEMENTED)
// =======================
// TODO: Configure JWT Authentication using JwtBearerDefaults
// TODO: Use Jwt:Key and Jwt:Issuer from appsettings.json

// =======================
// 🔹 Controllers
// =======================
builder.Services.AddControllers();

// =======================
// 🔹 Swagger (PRE-CONFIGURED)
// =======================
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// =======================
// 🔹 Middleware Pipeline
// =======================

// Swagger UI (for testing APIs)
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Global Exception Handling (PARTIAL IMPLEMENTATION)
app.UseMiddleware<ExceptionMiddleware>();

// =======================
// 🔹 Authentication & Authorization (TO BE IMPLEMENTED)
// =======================
// TODO: Add Authentication middleware
// TODO: Add Authorization middleware

app.MapControllers();

app.Run();