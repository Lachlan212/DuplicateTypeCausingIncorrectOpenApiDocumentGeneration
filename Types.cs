namespace ReproduceOpenApiError;

public record MapNode
{
    public required string Name { get; init; }
}

public record MapLink
{
    public required int Source { get; init; }
    public required int Target { get; init; }
    public required decimal Value { get; init; }
}

public record OverallDataContainer
{
    public DataContainer1? Container1 { get; init; }
    public DataContainer2? Container2 { get; init; }
}

public record DataContainer1
{
    public required List<MapNode> Container1MapNodes { get; init; }
    public required List<MapLink> Container1MapLinks { get; init; }
}

public record DataContainer2
{
    public required List<MapNode> Container2MapNodes { get; init; }
    public required List<MapLink> Container2MapLinks { get; init; }
}
