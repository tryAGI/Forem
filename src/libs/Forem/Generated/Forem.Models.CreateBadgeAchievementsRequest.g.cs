
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBadgeAchievementsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badge_achievement")]
        public global::Forem.CreateBadgeAchievementsRequestBadgeAchievement? BadgeAchievement { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBadgeAchievementsRequest" /> class.
        /// </summary>
        /// <param name="badgeAchievement"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBadgeAchievementsRequest(
            global::Forem.CreateBadgeAchievementsRequestBadgeAchievement? badgeAchievement)
        {
            this.BadgeAchievement = badgeAchievement;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBadgeAchievementsRequest" /> class.
        /// </summary>
        public CreateBadgeAchievementsRequest()
        {
        }

    }
}