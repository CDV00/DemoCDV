using SER.Domain.Interfaces;
using SER.Domain.Services;
using SER.Infrastructure.Data;
using SER.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
// Add services to the container.

builder.Services.AddControllers();
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//AddAutoMapper
//builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<VI_GPMBContext>();
//unitOfworkk
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
//Repositories
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IDuAnRepository, DuAnRepository>();
builder.Services.AddScoped<IKhoKhanRepository, KhoKhanRepository>();
//Service
builder.Services.AddScoped(typeof(IBaseService<,,>), typeof(BaseService<,,>));
builder.Services.AddScoped(typeof(IDanhMucService<>), typeof(DanhMucService<>));
builder.Services.AddScoped<IDuAnService, DuAnService>();
builder.Services.AddScoped<IKhoKhanService, KhoKhanService>();

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
