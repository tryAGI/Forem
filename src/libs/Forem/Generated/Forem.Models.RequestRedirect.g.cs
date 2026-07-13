
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of a request redirect
    /// </summary>
    public sealed partial class RequestRedirect
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestRedirect" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="originalUrl"></param>
        /// <param name="destinationUrl"></param>
        /// <param name="requestDomain"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestRedirect(
            long id,
            string originalUrl,
            string destinationUrl,
            string requestDomain,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id;
            this.OriginalUrl = originalUrl ?? throw new global::System.ArgumentNullException(nameof(originalUrl));
            this.DestinationUrl = destinationUrl ?? throw new global::System.ArgumentNullException(nameof(destinationUrl));
            this.RequestDomain = requestDomain ?? throw new global::System.ArgumentNullException(nameof(requestDomain));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestRedirect" /> class.
        /// </summary>
        public RequestRedirect()
        {
        }

    }
}