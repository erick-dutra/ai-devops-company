using AIDevOpsCompany.Core.Interfaces;
using AIDevOpsCompany.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure MongoDB
builder.Services.Configure<MongoDbSettings>(
    builder.Configuration.GetSection("MongoDB"));

builder.Services.AddSingleton<IPromptRepository, MongoPromptRepository>();

// Configure RabbitMQ
//builder.Services.Configure<RabbitMQSettings>(
//    builder.Configuration.GetSection("RabbitMQ"));

// Add RabbitMQ messaging
//builder.Services.AddRabbitMQMessaging(builder.Configuration);

// Configure LLAMA AI
//builder.Services.AddLlamaClient(builder.Configuration);

// Configure Semantic Kernel
builder.Services.AddKernel();

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Add health checks
builder.Services.AddHealthChecks()
    .AddCheck("mongodb", () => Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Healthy());
    //.AddCheck("rabbitmq", () => Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Healthy())
    //.AddCheck("llama", () => Microsoft.Extensions.Diagnostics.HealthChecks.HealthCheckResult.Healthy());

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseAuthorization();
app.MapControllers();

// Add health check endpoint
app.MapHealthChecks("/health");

//app.Run("http://0.0.0.0:8080");

app.Run();

