namespace ActionFilterAttributeBaseSample.Requests;

public sealed record MyRequest
{
    public Guid Guid { get; set; }
    public string Name { get; set; }
}
