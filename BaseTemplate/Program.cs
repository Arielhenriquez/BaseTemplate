using AutoMapper;
using BaseTemplate.Data.Context;
using BaseTemplate.Data.Repository;
using BaseTemplate.Dtos;
using BaseTemplate.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string myAppDbContextConnection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<SuperMarketDbContext>(op => op.UseSqlServer(myAppDbContextConnection),
    ServiceLifetime.Transient);

#region Injecting Services
builder.Services.AddScoped<IBrandsRepository, BrandsRepository>();
builder.Services.AddTransient<IBrandService, BrandService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IProductService, ProductsService>();
builder.Services.AddScoped<ISuperMarketRepository, SuperMarketRepository>();
builder.Services.AddTransient<ISuperMarketService, SuperMarketService>();
builder.Services.AddScoped<IShoppingListRepository, ShoppingListRepository>();
builder.Services.AddTransient<IShoppingListService, ShoppingListService>();
#endregion

var mapperConfig = new MapperConfiguration(m =>
{
    m.AddProfile(new MapperProfile());
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
