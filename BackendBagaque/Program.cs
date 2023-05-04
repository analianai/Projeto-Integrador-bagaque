using BackendBagaque.Data;
using BackendBagaque.Models;
using BackendBagaque.Services.Users;
using BackendBagaque.Services.Products;
using BackendBagaque.Services.Orders;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add connection
builder.Services.AddDbContext<BagaqueDBContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add Services
builder.Services.AddScoped<UsersService>();
builder.Services.AddScoped<ProductsService>();
builder.Services.AddScoped<OrdersService>();
builder.Services.AddScoped<ProductOrder>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();