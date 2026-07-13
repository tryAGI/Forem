
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAdminUsersMergeRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MergeUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersMergeRequest" /> class.
        /// </summary>
        /// <param name="mergeUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminUsersMergeRequest(
            int mergeUserId)
        {
            this.MergeUserId = mergeUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersMergeRequest" /> class.
        /// </summary>
        public CreateAdminUsersMergeRequest()
        {
        }

    }
}