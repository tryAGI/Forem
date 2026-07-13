
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAgentSessionRequest
    {
        /// <summary>
        /// Title for the session (auto-generated if omitted)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// JSON string of curated session data with messages array and metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("curated_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CuratedData { get; set; }

        /// <summary>
        /// S3 object key from presign endpoint (optional).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("s3_key")]
        public string? S3Key { get; set; }

        /// <summary>
        /// Tool that produced the session (e.g. claude_code, codex).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.CreateAgentSessionRequestToolNameJsonConverter))]
        public global::Forem.CreateAgentSessionRequestToolName? ToolName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequest" /> class.
        /// </summary>
        /// <param name="curatedData">
        /// JSON string of curated session data with messages array and metadata.
        /// </param>
        /// <param name="title">
        /// Title for the session (auto-generated if omitted)
        /// </param>
        /// <param name="s3Key">
        /// S3 object key from presign endpoint (optional).
        /// </param>
        /// <param name="toolName">
        /// Tool that produced the session (e.g. claude_code, codex).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentSessionRequest(
            string curatedData,
            string? title,
            string? s3Key,
            global::Forem.CreateAgentSessionRequestToolName? toolName)
        {
            this.Title = title;
            this.CuratedData = curatedData ?? throw new global::System.ArgumentNullException(nameof(curatedData));
            this.S3Key = s3Key;
            this.ToolName = toolName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentSessionRequest" /> class.
        /// </summary>
        public CreateAgentSessionRequest()
        {
        }

    }
}