# List Tags



This example assumes `using Forem;` is in scope and `apiKey` contains your Forem API key.

```csharp
using var client = new ForemClient(apiKey);

var tags = await client.Tags.GetTagsAsync(
    perPage: 10,
    page: 1);

foreach (var tag in tags)
{
    Console.WriteLine($"Tag: {tag.Name}");
}
```