
#nullable enable

namespace Forem
{
    public sealed partial class ForemClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            _authorization = new global::Forem.EndPointAuthorization
            {
                Name = "api-key",
                Value = apiKey,
            };
        }
    }
}