
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAdminUsersIdentitiesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersIdentitiesRequest" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="uid"></param>
        /// <param name="username"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminUsersIdentitiesRequest(
            string provider,
            string uid,
            string? username)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Uid = uid ?? throw new global::System.ArgumentNullException(nameof(uid));
            this.Username = username;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersIdentitiesRequest" /> class.
        /// </summary>
        public CreateAdminUsersIdentitiesRequest()
        {
        }

    }
}