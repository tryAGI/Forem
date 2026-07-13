
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAdminUsersIdentitiesBulkRequestIdentitie
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersIdentitiesBulkRequestIdentitie" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="uid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminUsersIdentitiesBulkRequestIdentitie(
            int userId,
            string uid)
        {
            this.UserId = userId;
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersIdentitiesBulkRequestIdentitie" /> class.
        /// </summary>
        public CreateAdminUsersIdentitiesBulkRequestIdentitie()
        {
        }

    }
}