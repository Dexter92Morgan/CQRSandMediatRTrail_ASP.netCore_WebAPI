using CQRSandMediaRTrail.Services.Commands;
using CQRSandMediaRTrail.Services.Data;
using CQRSandMediaRTrail.Services.Handlers;
using CQRSandMediaRTrail.Services.Models;
using CQRSandMediaRTrail.Services.Queries;
using CQRSandMediaRTrail.Services.Repositories;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IRequestHandler<CreateStudentCommand, StudentDetails>, CreateStudentHandler>();
builder.Services.AddScoped<IRequestHandler<GetStudentListQuery, List<StudentDetails>>, GetStudentListHandler>();
builder.Services.AddScoped<IRequestHandler<UpdateStudentCommand, int>, UpdateStudentHandler>();
builder.Services.AddScoped<IRequestHandler<DeleteStudentCommand, int>, DeleteStudentHandler>();
builder.Services.AddScoped<IRequestHandler<GetStudentByIdQuery, StudentDetails>, GetStudentByIdHandler>();


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
