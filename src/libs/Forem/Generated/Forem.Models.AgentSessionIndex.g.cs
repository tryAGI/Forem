
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of an agent session returned in a list or after creation
    /// </summary>
    public sealed partial class AgentSessionIndex
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Published { get; set; }

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
        public global::System.DateTime? UpdatedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="AgentSessionIndex" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="slug"></param>
        /// <param name="title"></param>
        /// <param name="toolName">
        /// Tool that produced the session (e.g. claude_code, codex)
        /// </param>
        /// <param name="totalMessages"></param>
        /// <param name="published"></param>
        /// <param name="createdAt"></param>
        /// <param name="url"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentSessionIndex(
            long id,
            string slug,
            string title,
            string toolName,
            int totalMessages,
            bool published,
            global::System.DateTime createdAt,
            string url,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.TotalMessages = totalMessages;
            this.Published = published;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentSessionIndex" /> class.
        /// </summary>
        public AgentSessionIndex()
        {
        }

    }
}