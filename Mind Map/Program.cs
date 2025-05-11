using Microsoft.Extensions.Configuration;
using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args); // Add this line to your service configuration
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));


builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
//options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection"),
    sqlServerOptions =>
    {
    sqlServerOptions.EnableRetryOnFailure(
        maxRetryCount: 3,                // Number of retries
        maxRetryDelay: TimeSpan.FromSeconds(30),  // Max delay between retries
        errorNumbersToAdd: null          // Optional: specify SQL errors to retry on
    );

        sqlServerOptions.CommandTimeout(30);  // Command timeout in seconds
    }
));

//chatbot
builder.Services.AddHttpClient();

//Create Token
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

builder.Services.AddAuthentication("Bearer")
    .AddJwtBearer("Bearer", options =>
    {
        var jwtSettings = builder.Configuration.GetSection("JWT");
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings["Issuer"],
            ValidAudience = jwtSettings["Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["SecretKey"]))
        };
    });

builder.Services.AddAuthorization();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
c.SwaggerDoc("v1", new OpenApiInfo { Title = "MindMapAPI", Version = "v1" });

c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
{
    In = ParameterLocation.Header,
    Description = "JWT Authorization header using the Bearer scheme",
    Name = "Authorization",
    Type = SecuritySchemeType.Http,
    Scheme = "bearer",
    BearerFormat = "JWT"
});

c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    try
    {
        await db.Database.CanConnectAsync();
        Console.WriteLine(" Database connection successful");
    }
    catch (Exception ex)
    {
        Console.WriteLine($" Database error: {ex.Message}");
    }
}

// Enable middleware to serve swagger-ui
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MindMapAPI v1");
    c.RoutePrefix = string.Empty; // Set Swagger UI at the root
});

// Enable development exception page for all environments
app.UseDeveloperExceptionPage();

// Enable CORS with the policy
app.UseCors("AllowAll");

// Add HTTP to HTTPS redirection
app.UseHttpsRedirection();

// Add routing middleware
app.UseRouting();

// Add authentication and authorization middleware in the correct order
app.UseAuthentication();
app.UseAuthorization();

// Map controller endpoints
app.MapControllers();

// Add a health check endpoint
app.MapGet("/health", () => Results.Ok("API is healthy"));

// Launch browser when starting the app in development
if (app.Environment.IsDevelopment())
{
    var url = "http://localhost:5000"; // Make sure this matches your launchSettings.json
    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
    {
        FileName = url,
        UseShellExecute = true
    });
}

Console.WriteLine($" Server running at: {DateTime.Now}");
app.Run();