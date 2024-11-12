var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // This is the key line for API controller services
builder.Services.AddSingleton<EmployeeService>();
builder.Services.AddEndpointsApiExplorer(); // This is required for the API explorer to work
builder.Services.AddSwaggerGen(); // Adds the Swagger generator for API documentation
var app = builder.Build();
app.UseSwagger();  // Adds the Swagger JSON endpoint (by default /swagger/v1/swagger.json)

// Enable middleware to serve Swagger UI (by default at /swagger)
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1");
    c.RoutePrefix = "swagger";  // You can customize this route if needed
});

// Enable static files to be served (for your HTML page in wwwroot)
app.UseStaticFiles();  // Make sure the static file middleware is enabled

// Map API controllers (this sets up the routes for your API controllers)
app.MapControllers();  // This is necessary for your API endpoints to work

app.Run();
