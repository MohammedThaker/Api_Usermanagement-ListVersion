using Application.Interfaces;
using Application.Interfaces.IRoleService;
using Application.Interfaces.IUserService;
using Application.service;
using Application.service.RoleSerivce;
using Application.service.UsersService;
using Domain.IRepository;
using Domain.Models;
using Infrastructure.Interfacies;
using Infrastructure.LibraryDB;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<LibraryDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.AddTransient<IBaseUnitOftWork, BaseUnitOfWork>();
builder.Services.AddScoped<IGetUserByIdService, GetUserByIdService>();

builder.Services.AddScoped<ICreateUserService, CreateUserService>();
builder.Services.AddScoped<IDeleteUserServiceById, DeleteUserServiceById>();
builder.Services.AddScoped<IGetAllUserSerivce, GetAllUserSerivce>();
builder.Services.AddScoped<IUpdateUserService, UpdateUserService>();




builder.Services.AddScoped<ICreateRoleService, CreateRoleService>();
builder.Services.AddScoped<IDeleteRoleServiceById, DeleteRoleServiceById>();
builder.Services.AddScoped<IGetAllRoleSerivce, GetAllRoleSerivce>();
builder.Services.AddScoped<IUpdateRoleService, UpdateRoleService>();


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
