
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of a badge achievement
    /// </summary>
    public sealed partial class BadgeAchievement
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badge_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long BadgeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewarding_context_message_markdown")]
        public string? RewardingContextMessageMarkdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_default_description")]
        public bool? IncludeDefaultDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BadgeAchievement" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="badgeId"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="rewardingContextMessageMarkdown"></param>
        /// <param name="includeDefaultDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BadgeAchievement(
            long id,
            long userId,
            long badgeId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? rewardingContextMessageMarkdown,
            bool? includeDefaultDescription)
        {
            this.Id = id;
            this.UserId = userId;
            this.BadgeId = badgeId;
            this.RewardingContextMessageMarkdown = rewardingContextMessageMarkdown;
            this.IncludeDefaultDescription = includeDefaultDescription;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BadgeAchievement" /> class.
        /// </summary>
        public BadgeAchievement()
        {
        }

    }
}