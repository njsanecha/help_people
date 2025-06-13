using HelpPeople.Data.Repository.Generic;
using HelpPeople.Services.Implement;
using HelpPeople.Services.Implementation;
using HelpPeople.Services.Interface;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy
            .AllowAnyOrigin() 
            .AllowAnyHeader()
            .AllowAnyMethod());
});

builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the generic repository
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

//Registering services for dependency injection
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IUserService, UserService>();

var app = builder.Build();

// Use CORS
app.UseCors("AllowAll");

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
