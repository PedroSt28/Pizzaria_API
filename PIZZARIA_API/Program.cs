using Microsoft.EntityFrameworkCore;
using PIZZARIA_API.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<PizzariaContext>(options =>

        options.UseSqlServer(builder.Configuration.GetConnectionString("Pizzaria"))

   //Diz o que o banco é SQL SERVER e busca a connection string chamada "Escola".
   //dentro da secao ConnectionStrings do appsettings.json

   );
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();
 
app.MapControllers();

app.MapGet("/api/Pizza", (PizzariaContext db) => db.Pizza.ToList());
app.Run();

//dotnet ef dbcontext scaffold "Server=(localdb)\MSSQLLocalDB;Database=Pizzaria;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Models --context-dir Contexts --context PizzariaContext --no-pluralize --no-onconfiguring