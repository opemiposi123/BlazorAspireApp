var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.BlazorAspireApp_ApiService>("apiservice");

builder.AddProject<Projects.BlazorAspireApp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
