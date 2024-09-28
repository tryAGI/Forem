
#nullable enable

namespace Forem
{
    public sealed partial class ForemClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKey(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _httpClient.DefaultRequestHeaders.Add("api-key", apiKey);
        }
    }
}