
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAdminRequestRedirectsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_redirect")]
        public global::Forem.PatchAdminRequestRedirectsRequestRequestRedirect? RequestRedirect { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAdminRequestRedirectsRequest" /> class.
        /// </summary>
        /// <param name="requestRedirect"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAdminRequestRedirectsRequest(
            global::Forem.PatchAdminRequestRedirectsRequestRequestRedirect? requestRedirect)
        {
            this.RequestRedirect = requestRedirect;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAdminRequestRedirectsRequest" /> class.
        /// </summary>
        public PatchAdminRequestRedirectsRequest()
        {
        }

    }
}