
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchBadgesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badge")]
        public global::Forem.PatchBadgesRequestBadge? Badge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchBadgesRequest" /> class.
        /// </summary>
        /// <param name="badge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchBadgesRequest(
            global::Forem.PatchBadgesRequestBadge? badge)
        {
            this.Badge = badge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchBadgesRequest" /> class.
        /// </summary>
        public PatchBadgesRequest()
        {
        }

    }
}