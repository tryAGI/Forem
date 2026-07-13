
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchConceptsRequestConcept
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_threshold")]
        public double? SimilarityThreshold { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConceptsRequestConcept" /> class.
        /// </summary>
        /// <param name="score"></param>
        /// <param name="description"></param>
        /// <param name="similarityThreshold"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchConceptsRequestConcept(
            double? score,
            string? description,
            double? similarityThreshold)
        {
            this.Score = score;
            this.Description = description;
            this.SimilarityThreshold = similarityThreshold;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchConceptsRequestConcept" /> class.
        /// </summary>
        public PatchConceptsRequestConcept()
        {
        }

    }
}