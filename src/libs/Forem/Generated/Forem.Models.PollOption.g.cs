
#nullable enable

namespace Forem
{
    /// <summary>
    /// A single option within a poll
    /// </summary>
    public sealed partial class PollOption
    {
        /// <summary>
        /// Resource discriminator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.PollOptionTypeOfJsonConverter))]
        public global::Forem.PollOptionTypeOf TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Option text in markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// Option text rendered as HTML
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_html")]
        public string? ProcessedHtml { get; set; }

        /// <summary>
        /// Display order within the poll
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Position { get; set; }

        /// <summary>
        /// Number of votes for this option
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_votes_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PollVotesCount { get; set; }

        /// <summary>
        /// Additional descriptive text for the option
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supplementary_text")]
        public string? SupplementaryText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PollOption" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="position">
        /// Display order within the poll
        /// </param>
        /// <param name="pollVotesCount">
        /// Number of votes for this option
        /// </param>
        /// <param name="typeOf">
        /// Resource discriminator
        /// </param>
        /// <param name="markdown">
        /// Option text in markdown
        /// </param>
        /// <param name="processedHtml">
        /// Option text rendered as HTML
        /// </param>
        /// <param name="supplementaryText">
        /// Additional descriptive text for the option
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PollOption(
            long id,
            int position,
            int pollVotesCount,
            global::Forem.PollOptionTypeOf typeOf,
            string? markdown,
            string? processedHtml,
            string? supplementaryText)
        {
            this.TypeOf = typeOf;
            this.Id = id;
            this.Markdown = markdown;
            this.ProcessedHtml = processedHtml;
            this.Position = position;
            this.PollVotesCount = pollVotesCount;
            this.SupplementaryText = supplementaryText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PollOption" /> class.
        /// </summary>
        public PollOption()
        {
        }

    }
}