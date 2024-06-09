using ApplicationLayer;
using InfrastructureLayer.Repository;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(http=>new HttpClient{
    BaseAddress=new Uri(builder.HostEnvironment.BaseAddress)
});
builder.Services.AddScoped<ITopFilmsViewer,TopFilmsViewerRepository>();
await builder.Build().RunAsync();
