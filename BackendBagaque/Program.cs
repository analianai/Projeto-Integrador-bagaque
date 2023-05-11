using BackendBagaque.Data;
using BackendBagaque.Models;
using BackendBagaque.Services.ProducsOrders;
using BackendBagaque.Services.Users;
using BackendBagaque.Services.Products;
using BackendBagaque.Services.Orders;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using BackendBagaque.Services.ProducsOrders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();
builder.Services.AddAuthentication("Bearer").AddJwtBearer();

// Add connection
builder.Services.AddDbContext<BagaqueDBContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add Services
builder.Services.AddScoped<UsersService>();
builder.Services.AddScoped<ProductsService>();
builder.Services.AddScoped<OrdersService>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();