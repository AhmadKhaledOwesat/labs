
using JoLab.Application.DI;
using JoLab.Application.Dto;
using JoLab.Application.Hubs;
using JoLab.Domain.Entities;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.Features;
using Newtonsoft.Json;
using Scalar.AspNetCore;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDcpMapper();
builder.Services.AddSignalR();
builder.Services.AddEfDbContext(builder.Configuration);
builder.Services.AddHttpContextAccessor();
builder.Services.AddServices();
builder.Services.AddCors(op =>
{
    op.AddPolicy("AllowAllOrigins", builder =>
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
});
builder.Services.Configure<FormOptions>(o =>
{
    o.ValueLengthLimit = int.MaxValue;
    o.MultipartBodyLengthLimit = int.MaxValue;
    o.MemoryBufferThreshold = int.MaxValue;
});
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddAuthorization();
builder.Services.AddControllers();
builder.WebHost.ConfigureKestrel(options =>
{
    options.Limits.MaxRequestBodySize = null;
});
//builder.Services.AddHostedService<JoLab.Application.HostedService.BackgroundService>();

var app = builder.Build();
app.UseExceptionHandler(appError =>
{
    appError.Run(async context =>
    {
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        context.Response.ContentType = "application/json";
        var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
        if (contextFeature != null)
            await context.Response.WriteAsync(JsonConvert.SerializeObject(new ApiResponse<ErrorDto>(new ErrorDto(), contextFeature.Error.InnerException?.Message ?? contextFeature.Error.Message + Environment.NewLine + contextFeature.Error.StackTrace, false)));
    });
});

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();        
app.UseRouting();
app.MapHub<NotificationHub>("/notificationHub");
app.UseCors("AllowAllOrigins");     
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.MapScalarApiReference();       
app.MapOpenApi();

app.Run();
