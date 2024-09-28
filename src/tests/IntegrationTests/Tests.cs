namespace Forem.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static ForemClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("FOREM_API_KEY") ??
            throw new AssertInconclusiveException("FOREM_API_KEY environment variable is not found.");

        var client = new ForemClient(apiKey);
        
        return client;
    }
}
