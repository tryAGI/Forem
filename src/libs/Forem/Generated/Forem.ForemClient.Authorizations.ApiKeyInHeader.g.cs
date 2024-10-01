
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

            _authorizations.Clear();
            _authorizations.Add(new global::Forem.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "api-key",
                Value = apiKey,
            });
        }
    }
}