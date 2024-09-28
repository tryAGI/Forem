
#nullable enable

namespace Forem
{
    /// <summary>
    /// A follower
    /// </summary>
    public sealed partial class GetFollowersResponseItem
    {
        /// <summary>
        /// user_follower by default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        public string? TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The follower's user id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// The follower's name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A path to the follower's profile
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Profile image (640x640)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_image")]
        public string? ProfileImage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}