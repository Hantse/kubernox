var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

//var webfrontend = builder.AddProject<Projects.Kubernox>("webfrontend")
//                            .WithExternalHttpEndpoints()
//                            .WithReference(cache);

builder.Build().Run();
