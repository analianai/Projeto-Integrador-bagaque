using BackendBagaque.Date;
using BackendBagaque.Services.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// add Connection
builder.Services.AddDbContext<BagaqueDBContext>(option =>{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
}
);

builder.Services.AddScoped<UsersService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();