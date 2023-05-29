using Microsoft.EntityFrameworkCore;
using Skill_tests_2.Data;
using Skill_tests_2.Interface;
using Skill_tests_2.Models;
using Skill_tests_2.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositoryPoint<Point>, PointRepository>();
builder.Services.AddScoped<IRepositoryComment<Comment>, CommentRepository>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseInMemoryDatabase("MemoryDB");
});

var app = builder.Build();

TempData.CreateTmpData(app);

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
