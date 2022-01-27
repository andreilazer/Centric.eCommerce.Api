using Centric.eCommerce.Search.Api.Interfaces;
using Centric.eCommerce.Search.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IProductsService, ProductsService>();
builder.Services.AddScoped<IOrdersService, OrdersService>();
builder.Services.AddScoped<ICustomersService, CustomerService>();
builder.Services.AddScoped<ISearchService, SearchService>();
builder.Services.AddHttpClient("ProductsService", config => { config.BaseAddress = new Uri(builder.Configuration["Services.Products"]); });
builder.Services.AddHttpClient("CustomersService", config => { config.BaseAddress = new Uri(builder.Configuration["Services.Customers"]); });
builder.Services.AddHttpClient("OrdersService", config => { config.BaseAddress = new Uri(builder.Configuration["Services.Orders"]); });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapControllers();
app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}