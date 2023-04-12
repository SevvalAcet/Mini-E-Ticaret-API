using ETicaretAPI.Persistence;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddPersistenceSerivces();
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
policy.WithOrigins("https://localhost:4200/", " http://localhost:4200/").AllowAnyHeader().AllowAnyMethod()
));

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ETicaretAPIDbContext>();


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
