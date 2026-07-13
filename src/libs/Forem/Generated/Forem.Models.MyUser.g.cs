
#nullable enable

namespace Forem
{
    /// <summary>
    /// The representation of a user when accessed by themselves
    /// </summary>
    public sealed partial class MyUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        public string? TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_username")]
        public string? GithubUsername { get; set; }

        /// <summary>
        /// Email (if user allows displaying email on their profile) or nil
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("joined_at")]
        public string? JoinedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profile_image")]
        public string? ProfileImage { get; set; }

        /// <summary>
        /// ids of the badges awarded to the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badge_ids")]
        public global::System.Collections.Generic.IList<int>? BadgeIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers_count")]
        public int? FollowersCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MyUser" /> class.
        /// </summary>
        /// <param name="typeOf"></param>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="name"></param>
        /// <param name="summary"></param>
        /// <param name="twitterUsername"></param>
        /// <param name="githubUsername"></param>
        /// <param name="email">
        /// Email (if user allows displaying email on their profile) or nil
        /// </param>
        /// <param name="websiteUrl"></param>
        /// <param name="location"></param>
        /// <param name="joinedAt"></param>
        /// <param name="profileImage"></param>
        /// <param name="badgeIds">
        /// ids of the badges awarded to the user
        /// </param>
        /// <param name="followersCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MyUser(
            string? typeOf,
            long? id,
            string? username,
            string? name,
            string? summary,
            string? twitterUsername,
            string? githubUsername,
            string? email,
            string? websiteUrl,
            string? location,
            string? joinedAt,
            string? profileImage,
            global::System.Collections.Generic.IList<int>? badgeIds,
            int? followersCount)
        {
            this.TypeOf = typeOf;
            this.Id = id;
            this.Username = username;
            this.Name = name;
            this.Summary = summary;
            this.TwitterUsername = twitterUsername;
            this.GithubUsername = githubUsername;
            this.Email = email;
            this.WebsiteUrl = websiteUrl;
            this.Location = location;
            this.JoinedAt = joinedAt;
            this.ProfileImage = profileImage;
            this.BadgeIds = badgeIds;
            this.FollowersCount = followersCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MyUser" /> class.
        /// </summary>
        public MyUser()
        {
        }

    }
}