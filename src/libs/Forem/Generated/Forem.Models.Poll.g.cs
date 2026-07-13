
#nullable enable

namespace Forem
{
    /// <summary>
    /// A poll (question) belonging to a survey or article
    /// </summary>
    public sealed partial class Poll
    {
        /// <summary>
        /// Resource discriminator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.PollTypeOfJsonConverter))]
        public global::Forem.PollTypeOf TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Question text in markdown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_markdown")]
        public string? PromptMarkdown { get; set; }

        /// <summary>
        /// Question text rendered as HTML
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_html")]
        public string? PromptHtml { get; set; }

        /// <summary>
        /// Poll question type: single_choice, multiple_choice, scale, or text_input
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_type_of")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.PollPollTypeOfJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Forem.PollPollTypeOf PollTypeOf { get; set; }

        /// <summary>
        /// Display order within the survey
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Position { get; set; }

        /// <summary>
        /// Total number of votes across all options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_votes_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PollVotesCount { get; set; }

        /// <summary>
        /// Number of users who skipped this poll
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_skips_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PollSkipsCount { get; set; }

        /// <summary>
        /// Number of options in this poll
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_options_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PollOptionsCount { get; set; }

        /// <summary>
        /// Minimum value for scale polls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_min")]
        public int? ScaleMin { get; set; }

        /// <summary>
        /// Maximum value for scale polls
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_max")]
        public int? ScaleMax { get; set; }

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
        /// The available options for this poll
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Forem.PollOption> PollOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Poll" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pollTypeOf">
        /// Poll question type: single_choice, multiple_choice, scale, or text_input
        /// </param>
        /// <param name="position">
        /// Display order within the survey
        /// </param>
        /// <param name="pollVotesCount">
        /// Total number of votes across all options
        /// </param>
        /// <param name="pollSkipsCount">
        /// Number of users who skipped this poll
        /// </param>
        /// <param name="pollOptionsCount">
        /// Number of options in this poll
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="pollOptions">
        /// The available options for this poll
        /// </param>
        /// <param name="typeOf">
        /// Resource discriminator
        /// </param>
        /// <param name="promptMarkdown">
        /// Question text in markdown
        /// </param>
        /// <param name="promptHtml">
        /// Question text rendered as HTML
        /// </param>
        /// <param name="scaleMin">
        /// Minimum value for scale polls
        /// </param>
        /// <param name="scaleMax">
        /// Maximum value for scale polls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Poll(
            long id,
            global::Forem.PollPollTypeOf pollTypeOf,
            int position,
            int pollVotesCount,
            int pollSkipsCount,
            int pollOptionsCount,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::Forem.PollOption> pollOptions,
            global::Forem.PollTypeOf typeOf,
            string? promptMarkdown,
            string? promptHtml,
            int? scaleMin,
            int? scaleMax)
        {
            this.TypeOf = typeOf;
            this.Id = id;
            this.PromptMarkdown = promptMarkdown;
            this.PromptHtml = promptHtml;
            this.PollTypeOf = pollTypeOf;
            this.Position = position;
            this.PollVotesCount = pollVotesCount;
            this.PollSkipsCount = pollSkipsCount;
            this.PollOptionsCount = pollOptionsCount;
            this.ScaleMin = scaleMin;
            this.ScaleMax = scaleMax;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PollOptions = pollOptions ?? throw new global::System.ArgumentNullException(nameof(pollOptions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Poll" /> class.
        /// </summary>
        public Poll()
        {
        }

    }
}