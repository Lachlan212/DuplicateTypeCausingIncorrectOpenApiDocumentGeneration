using ReproduceOpenApiError;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapOpenApi();
app.MapScalarApiReference();


app.UseHttpsRedirection();

app.MapGet("/data-container", () =>
{
    var nodes1 = new List<MapNode>()
    {
        new MapNode { Name = "Node1" },
        new MapNode { Name = "Node2" },
        new MapNode { Name = "Node3" }
    };
    var links1 = new List<MapLink>()
    {
        new MapLink { Source = 0, Target = 1, Value = 10 },
        new MapLink { Source = 1, Target = 2, Value = 20 }
    };
    var nodes2 = new List<MapNode>()
    {
        new MapNode { Name = "NodeA" },
    };
    var links2 = new List<MapLink>()
    {
        new MapLink { Source = 0, Target = 1, Value = 30 },
        new MapLink { Source = 1, Target = 2, Value = 40 }
    };

    var container1 = new DataContainer1
    {
        Container1MapNodes = nodes1,
        Container1MapLinks = links1
    };

    var container2 = new DataContainer2
    {
        Container2MapNodes = nodes2,
        Container2MapLinks = links2
    };

    var overallDataContainer = new OverallDataContainer
    {
        Container1 = container1,
        Container2 = container2
    };

    return overallDataContainer;
}).WithName("Get Data");

app.Run();
