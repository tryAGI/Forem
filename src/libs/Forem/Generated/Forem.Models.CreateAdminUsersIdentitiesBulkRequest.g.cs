
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAdminUsersIdentitiesBulkRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("identities")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Forem.CreateAdminUsersIdentitiesBulkRequestIdentitie> Identities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersIdentitiesBulkRequest" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="identities"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminUsersIdentitiesBulkRequest(
            string provider,
            global::System.Collections.Generic.IList<global::Forem.CreateAdminUsersIdentitiesBulkRequestIdentitie> identities)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Identities = identities ?? throw new global::System.ArgumentNullException(nameof(identities));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminUsersIdentitiesBulkRequest" /> class.
        /// </summary>
        public CreateAdminUsersIdentitiesBulkRequest()
        {
        }

    }
}