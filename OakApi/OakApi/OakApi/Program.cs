using Microsoft.EntityFrameworkCore;
using OakApi.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApiDbContext>();

builder.Services.AddControllers();

builder.Services.AddCors(x => x.AddPolicy("OakPolicy", policy =>		//**//
	policy.WithMethods().WithOrigins("https://oakacademy.uk").AllowAnyHeader()
));

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

app.UseCors("OakPolicy");	//**//

app.MapControllers();

app.Run();
