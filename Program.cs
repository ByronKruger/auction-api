using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NftApi;
using NftApi.Data;
using NftApi.Entities;
using NftApi.Extensions;
using NftApi.Interfaces;
using NftApi.Middleware;
using NftApi.SignalR;
// using NftContract.Contracts.NftContract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

// builder.Services.AddScoped<NftContractTests>(opts => 
// {
//     opts.
// });

var app = builder.Build();

app.UseFactoryActivatedMiddleware();
// app.UseMiddleware<ErrorHandleMiddleware>();

app.MapHub<BiddingHub>("hubs/bidding");
// app.MapHub<PresenceHub>("hubs/presence");

// CORS
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod()
    .AllowCredentials().WithOrigins("http://localhost:4200", "http://localhost:8080"));

app.UseAuthentication();
app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UseAuthorization();

app.MapControllers();

app.Run();
