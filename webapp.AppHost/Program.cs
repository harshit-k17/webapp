var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.webapp_ApiService>("apiservice");

builder.AddProject<Projects.webapp_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
