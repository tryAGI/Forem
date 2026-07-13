#nullable enable

namespace Forem
{
    public partial interface IBadgeAchievementsClient
    {
        /// <summary>
        /// Create a badge achievement<br/>
        /// Award a badge to a user. Requires administrator privileges.<br/>
        /// ### Integration Tips:<br/>
        /// - **user_id**: The numeric ID of the user receiving the badge.<br/>
        /// - **badge_id**: The numeric ID of the badge being awarded.<br/>
        /// - **rewarding_context_message_markdown**: Optional personalized message shown in the notification or profile feed to explain why the user was awarded the badge.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.BadgeAchievement> CreateBadgeAchievementsAsync(

            global::Forem.CreateBadgeAchievementsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a badge achievement<br/>
        /// Award a badge to a user. Requires administrator privileges.<br/>
        /// ### Integration Tips:<br/>
        /// - **user_id**: The numeric ID of the user receiving the badge.<br/>
        /// - **badge_id**: The numeric ID of the badge being awarded.<br/>
        /// - **rewarding_context_message_markdown**: Optional personalized message shown in the notification or profile feed to explain why the user was awarded the badge.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.BadgeAchievement>> CreateBadgeAchievementsAsResponseAsync(

            global::Forem.CreateBadgeAchievementsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a badge achievement<br/>
        /// Award a badge to a user. Requires administrator privileges.<br/>
        /// ### Integration Tips:<br/>
        /// - **user_id**: The numeric ID of the user receiving the badge.<br/>
        /// - **badge_id**: The numeric ID of the badge being awarded.<br/>
        /// - **rewarding_context_message_markdown**: Optional personalized message shown in the notification or profile feed to explain why the user was awarded the badge.
        /// </summary>
        /// <param name="badgeAchievement"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.BadgeAchievement> CreateBadgeAchievementsAsync(
            global::Forem.CreateBadgeAchievementsRequestBadgeAchievement? badgeAchievement = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}