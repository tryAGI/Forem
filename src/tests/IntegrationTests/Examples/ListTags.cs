/*
order: 30
title: List Tags
slug: list-tags
*/

namespace Forem.IntegrationTests;

public partial class Tests
{
    //// Retrieve a list of tags available on the Forem community platform.

    [TestMethod]
    public async Task Example_ListTags()
    {
        using var client = GetAuthenticatedClient();

        var tags = await client.Tags.GetTagsAsync(
            perPage: 10,
            page: 1);

        tags.Should().NotBeNull();
        tags.Should().NotBeEmpty();

        foreach (var tag in tags)
        {
            Console.WriteLine($"Tag: {tag.Name}");
        }
    }
}
