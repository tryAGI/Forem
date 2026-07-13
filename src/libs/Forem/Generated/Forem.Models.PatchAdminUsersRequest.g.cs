
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchAdminUsersRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAdminUsersRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="summary"></param>
        /// <param name="location"></param>
        /// <param name="websiteUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchAdminUsersRequest(
            string? name,
            string? username,
            string? summary,
            string? location,
            string? websiteUrl)
        {
            this.Name = name;
            this.Username = username;
            this.Summary = summary;
            this.Location = location;
            this.WebsiteUrl = websiteUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchAdminUsersRequest" /> class.
        /// </summary>
        public PatchAdminUsersRequest()
        {
        }

    }
}