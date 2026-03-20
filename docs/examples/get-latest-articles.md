# Get Latest Articles



This example assumes `using Forem;` is in scope and `apiKey` contains your Forem API key.

```csharp
using var client = new ForemClient(apiKey);

var articles = await client.Articles.GetLatestArticlesAsync(
    perPage: 5,
    page: 1);

foreach (var article in articles)
{
    Console.WriteLine($"Title: {article.Title}");
    Console.WriteLine($"  Published: {article.PublishedAt}");
    Console.WriteLine($"  Reactions: {article.PublicReactionsCount}");
    Console.WriteLine();
}
```