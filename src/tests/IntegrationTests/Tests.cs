namespace Forem.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ForemClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("FOREM_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("FOREM_API_KEY environment variable is not found.");

        var client = new ForemClient(apiKey);
        
        return client;
    }
}
