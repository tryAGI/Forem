
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAdminRequestRedirectsRequestRequestRedirect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OriginalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DestinationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminRequestRedirectsRequestRequestRedirect" /> class.
        /// </summary>
        /// <param name="originalUrl"></param>
        /// <param name="destinationUrl"></param>
        /// <param name="requestDomain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminRequestRedirectsRequestRequestRedirect(
            string originalUrl,
            string destinationUrl,
            string requestDomain)
        {
            this.OriginalUrl = originalUrl ?? throw new global::System.ArgumentNullException(nameof(originalUrl));
            this.DestinationUrl = destinationUrl ?? throw new global::System.ArgumentNullException(nameof(destinationUrl));
            this.RequestDomain = requestDomain ?? throw new global::System.ArgumentNullException(nameof(requestDomain));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminRequestRedirectsRequestRequestRedirect" /> class.
        /// </summary>
        public CreateAdminRequestRedirectsRequestRequestRedirect()
        {
        }

    }
}