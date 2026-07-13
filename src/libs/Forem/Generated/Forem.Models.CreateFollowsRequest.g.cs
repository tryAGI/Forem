
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFollowsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<int>? UserIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_ids")]
        public global::System.Collections.Generic.IList<int>? OrganizationIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFollowsRequest" /> class.
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="organizationIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFollowsRequest(
            global::System.Collections.Generic.IList<int>? userIds,
            global::System.Collections.Generic.IList<int>? organizationIds)
        {
            this.UserIds = userIds;
            this.OrganizationIds = organizationIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFollowsRequest" /> class.
        /// </summary>
        public CreateFollowsRequest()
        {
        }

    }
}