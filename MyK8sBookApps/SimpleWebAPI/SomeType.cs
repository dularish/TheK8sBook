public class SomeType
{
    private string myId = $"App-{Random.Shared.NextInt64(1, 100)}";

    public string Id { get { return myId; } }
}