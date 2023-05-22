using Microsoft.EntityFrameworkCore;
using Reclone_Users_Service.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpClient("PostMicroservice", client =>
{
    client.BaseAddress = new Uri("https://reclonepostservice.azurewebsites.net/"); // Replace with the base address of Microservice1
});

builder.Services.AddHttpClient("AuthMicroservice", client =>
{
    client.BaseAddress = new Uri("https://recloneauthservice.azurewebsites.net/"); // Replace with the base address of Microservice2
});


builder.Services.AddHttpClient("SearchMicroservice", client =>
{
    client.BaseAddress = new Uri(""); // Replace with the base address of Microservice2
});

//ADD DB CONTEXT
/*builder.Services.AddDbContext<UserDbContext>(options => 
   options.UseSqlite(builder.Configuration.GetConnectionString("UserDatabase")));*/

builder.Services.AddDbContext<UserDbContext>(options =>
    options.UseSqlite("Data Source=Database/UserDb.db"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
    app.UseSwagger();
    app.UseSwaggerUI();
if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
