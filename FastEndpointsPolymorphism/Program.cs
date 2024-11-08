using FastEndpoints;
using FastEndpointsPolymorphism;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddFastEndpoints(o => o.SourceGeneratorDiscoveredTypes = DiscoveredTypes.All.ToList());

var app = builder.Build();

app.UseHttpsRedirection();
app.UseFastEndpoints();

app.Run();
