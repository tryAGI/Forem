#nullable enable

namespace Forem
{
    public partial interface IBadgeAchievementsClient
    {
        /// <summary>
        /// Retrieve all badge achievements<br/>
        /// Retrieve a list of all badge achievements (awarded badges) in the system. Requires administrator privileges.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.BadgeAchievement>> GetBadgeAchievementsAsync(
            int? page = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve all badge achievements<br/>
        /// Retrieve a list of all badge achievements (awarded badges) in the system. Requires administrator privileges.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.BadgeAchievement>>> GetBadgeAchievementsAsResponseAsync(
            int? page = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}