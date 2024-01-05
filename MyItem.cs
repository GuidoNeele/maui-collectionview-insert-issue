namespace CollectionViewSample;

public class MyItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public static MyItem Create()
    {
        var id = Random.Shared.Next(1, 1000);

        return new MyItem
        {
            Id = id,
            Name = $"Item {id}",
            Description = $"Description for item {id}"
        };
    }
}
