using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using App_Consultorio.Application;
using MediatR;
using App_Consultorio.Application.Features.Doctor.CreateDoctors;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthenticationStateDeserialization();

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(CreateDoctorRequestHandler).Assembly));


builder.Services.AddApplication();

await builder.Build().RunAsync();
