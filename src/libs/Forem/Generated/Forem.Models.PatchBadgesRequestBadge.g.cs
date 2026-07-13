
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchBadgesRequestBadge
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_awarded")]
        public int? CreditsAwarded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_multiple_awards")]
        public bool? AllowMultipleAwards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchBadgesRequestBadge" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="creditsAwarded"></param>
        /// <param name="allowMultipleAwards"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchBadgesRequestBadge(
            string? title,
            string? description,
            int? creditsAwarded,
            bool? allowMultipleAwards)
        {
            this.Title = title;
            this.Description = description;
            this.CreditsAwarded = creditsAwarded;
            this.AllowMultipleAwards = allowMultipleAwards;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchBadgesRequestBadge" /> class.
        /// </summary>
        public PatchBadgesRequestBadge()
        {
        }

    }
}