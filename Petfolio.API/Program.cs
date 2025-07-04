var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

builder.Services.AddControllers();

builder.Services.AddOpenApiDocument(options =>
{
    options.DocumentName = "v1";
    options.Title = "Petfolio";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
