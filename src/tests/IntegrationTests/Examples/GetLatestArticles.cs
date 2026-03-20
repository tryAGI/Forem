/*
order: 40
title: Get Latest Articles
slug: get-latest-articles
*/

namespace Forem.IntegrationTests;

public partial class Tests
{
    //// Retrieve the most recently published articles from the Forem community.

    [TestMethod]
    public async Task Example_GetLatestArticles()
    {
        using var client = GetAuthenticatedClient();

        var articles = await client.Articles.GetLatestArticlesAsync(
            perPage: 5,
            page: 1);

        articles.Should().NotBeNull();
        articles.Should().NotBeEmpty();

        foreach (var article in articles)
        {
            Console.WriteLine($"Title: {article.Title}");
            Console.WriteLine($"  Published: {article.PublishedAt}");
            Console.WriteLine($"  Reactions: {article.PublicReactionsCount}");
            Console.WriteLine();
        }
    }
}
