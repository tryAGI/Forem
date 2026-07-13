
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAdminUsersNotesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersNotesRequest" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminUsersNotesRequest(
            string content,
            string? reason)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersNotesRequest" /> class.
        /// </summary>
        public CreateAdminUsersNotesRequest()
        {
        }

    }
}