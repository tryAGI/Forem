
#nullable enable

namespace Forem
{
    /// <summary>
    /// Full representation of an agent session including messages and curation data
    /// </summary>
    public sealed partial class AgentSessionShow
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
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Tool that produced the session (e.g. claude_code, codex)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalMessages { get; set; }

        /// <summary>
        /// Number of curated messages selected for display
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("curated_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CuratedCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Published { get; set; }

        /// <summary>
        /// Session metadata (tool-specific)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// All normalized messages in the session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Messages { get; set; }

        /// <summary>
        /// Named slices grouping message ranges
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Slices { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionShow" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="title"></param>
        /// <param name="toolName">
        /// Tool that produced the session (e.g. claude_code, codex)
        /// </param>
        /// <param name="totalMessages"></param>
        /// <param name="curatedCount">
        /// Number of curated messages selected for display
        /// </param>
        /// <param name="published"></param>
        /// <param name="messages">
        /// All normalized messages in the session
        /// </param>
        /// <param name="slices">
        /// Named slices grouping message ranges
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        /// <param name="metadata">
        /// Session metadata (tool-specific)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionShow(
            long id,
            string slug,
            string title,
            string toolName,
            int totalMessages,
            int curatedCount,
            bool published,
            global::System.Collections.Generic.IList<object> messages,
            global::System.Collections.Generic.IList<object> slices,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string url,
            object? metadata)
        {
            this.Id = id;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.TotalMessages = totalMessages;
            this.CuratedCount = curatedCount;
            this.Published = published;
            this.Metadata = metadata;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Slices = slices ?? throw new global::System.ArgumentNullException(nameof(slices));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionShow" /> class.
        /// </summary>
        public AgentSessionShow()
        {
        }

    }
}