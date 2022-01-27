using Centric.eCommerce.Customer.Api.DB;
using Centric.eCommerce.Customer.Api.Interfaces;
using Centric.eCommerce.Product.Api.Providers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddScoped<ICustomersProvider, CustomersProvider>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


// project dependencies
builder.Services.AddDbContext<CustomersDbContext>(options => options.UseInMemoryDatabase("Customers"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
