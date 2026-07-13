
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAdminRequestRedirectsRequestRequestRedirect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_url")]
        public string? OriginalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_url")]
        public string? DestinationUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_domain")]
        public string? RequestDomain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAdminRequestRedirectsRequestRequestRedirect" /> class.
        /// </summary>
        /// <param name="originalUrl"></param>
        /// <param name="destinationUrl"></param>
        /// <param name="requestDomain"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAdminRequestRedirectsRequestRequestRedirect(
            string? originalUrl,
            string? destinationUrl,
            string? requestDomain)
        {
            this.OriginalUrl = originalUrl;
            this.DestinationUrl = destinationUrl;
            this.RequestDomain = requestDomain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAdminRequestRedirectsRequestRequestRedirect" /> class.
        /// </summary>
        public PatchAdminRequestRedirectsRequestRequestRedirect()
        {
        }

    }
}