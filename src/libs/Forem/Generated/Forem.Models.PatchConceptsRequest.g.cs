
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConceptsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("concept")]
        public global::Forem.PatchConceptsRequestConcept? Concept { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConceptsRequest" /> class.
        /// </summary>
        /// <param name="concept"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConceptsRequest(
            global::Forem.PatchConceptsRequestConcept? concept)
        {
            this.Concept = concept;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConceptsRequest" /> class.
        /// </summary>
        public PatchConceptsRequest()
        {
        }

    }
}