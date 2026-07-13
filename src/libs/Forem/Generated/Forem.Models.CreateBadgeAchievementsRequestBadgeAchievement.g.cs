
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBadgeAchievementsRequestBadgeAchievement
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
        [global::System.Text.Json.Serialization.JsonPropertyName("badge_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BadgeId { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBadgeAchievementsRequestBadgeAchievement" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="badgeId"></param>
        /// <param name="rewardingContextMessageMarkdown"></param>
        /// <param name="includeDefaultDescription"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBadgeAchievementsRequestBadgeAchievement(
            int userId,
            int badgeId,
            string? rewardingContextMessageMarkdown,
            bool? includeDefaultDescription)
        {
            this.UserId = userId;
            this.BadgeId = badgeId;
            this.RewardingContextMessageMarkdown = rewardingContextMessageMarkdown;
            this.IncludeDefaultDescription = includeDefaultDescription;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBadgeAchievementsRequestBadgeAchievement" /> class.
        /// </summary>
        public CreateBadgeAchievementsRequestBadgeAchievement()
        {
        }

    }
}