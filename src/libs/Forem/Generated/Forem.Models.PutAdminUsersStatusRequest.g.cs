
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutAdminUsersStatusRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminUsersStatusRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutAdminUsersStatusRequest(
            string status,
            string? note)
        {
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminUsersStatusRequest" /> class.
        /// </summary>
        public PutAdminUsersStatusRequest()
        {
        }

    }
}