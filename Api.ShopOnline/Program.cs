using Api.ShopOnline;
using Api.ShopOnline.AutoMapperConvert;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using shopOnline.Api.Repositories.Contracts;
using shopOnline.Api.Repositories.Emplemention;

var builder = WebApplication.CreateBuilder(args);
string connexion = builder.Configuration.GetConnectionString("StringConnection");
builder.Services.AddDbContext<MyContext>(c => c.UseSqlServer(connexion));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddAutoMapper(typeof(MapperConfig));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy =>
policy.WithOrigins("http://localhost:7253", "https://localhost:7253")
.AllowAnyMethod()
.WithHeaders(HeaderNames.ContentType)
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
