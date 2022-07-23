using Microsoft.OpenApi.Models;
using Task1_ASP.NET_Core_API.Services;
using Task1_ASP.NET_Core_API.Services.EmpolyeeServices;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(e=>e.UseSqlServer(connectionString));

builder.Services.AddScoped<ICustomerServices, CustomerServices>();
builder.Services.AddScoped<IEmpolyeeServices, EmpolyeeServices>();
builder.Services.AddScoped<IProspectServices, ProspectServices>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddCors();
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Task Api",
        Description = "This first Task api",
        TermsOfService = new Uri("https://www.googlle.com"),
        Contact = new OpenApiContact
        {
            Name = "Mahmoud Kassem",
            Email = "www.modykassem123@gmail.com",
            Url = new Uri("https://www.googlle.com"),
        },
        License = new OpenApiLicense
        {
            Name = "OpenGl",
            Url = new Uri("https://www.googlle.com"),
        }
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter you JWT key",
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer",
                },
                Name = "Bearer",
                In = ParameterLocation.Header,
            },
            new List<string>()
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(c => c.AllowAnyHeader()
                  .AllowAnyMethod().AllowAnyOrigin());

app.MapControllers();

app.Run();
