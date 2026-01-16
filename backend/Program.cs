using FlightBookingApp.Data;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.SwaggerGen;
using Microsoft.OpenApi.Models;
using backend.Interface;
using backend.Service;

var builder = WebApplication.CreateBuilder(args);



// Get the connection string from configuration
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add DbContext to the service collection
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));

// Add MVC (controllers with views)
builder.Services.AddControllersWithViews();

// Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register application services




builder.Services.AddScoped<IFlightServices, FlightServices>();
builder.Services.AddScoped<IAircraftServices, AircraftServices>();
builder.Services.AddScoped<IAirportServices, AirportServices>();

// Allow CORS from frontend dev server (Vite default: http://localhost:5173)
builder.Services.AddCors(options =>
{
    options.AddPolicy("LocalDevPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:3000", "http://localhost:5173").AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Flight API V1"));
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Use CORS policy before authorization
app.UseCors("LocalDevPolicy");
app.UseAuthorization();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    SeedData.SeedFlights(dbContext);
    SeedData.SeedAircraft(dbContext);
    SeedData.SeedAirpots(dbContext);
}

// Map attribute-routed controllers and add a conventional default route for MVC views
app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

