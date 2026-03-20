/*
order: 20
title: List Articles
slug: list-articles
*/

namespace Forem.IntegrationTests;

public partial class Tests
{
    //// Retrieve a paginated list of published articles from the Forem community,
    //// sorted by descending publish date.

    [TestMethod]
    public async Task Example_ListArticles()
    {
        using var client = GetAuthenticatedClient();

        var articles = await client.Articles.GetArticlesAsync(
            perPage: 5,
            page: 1);

        articles.Should().NotBeNull();
        articles.Should().NotBeEmpty();

        foreach (var article in articles)
        {
            Console.WriteLine($"Title: {article.Title}");
            Console.WriteLine($"  URL: {article.Url}");
            Console.WriteLine($"  Published: {article.PublishedAt}");
            Console.WriteLine($"  Reactions: {article.PositiveReactionsCount}");
            Console.WriteLine();
        }
    }
}
