#nullable enable

namespace Forem
{
    public partial interface IBadgesClient
    {
        /// <summary>
        /// Retrieve all badges<br/>
        /// Retrieve a list of all badges available on the platform.<br/>
        /// ### Badges Overview:<br/>
        /// - Badges recognize achievements (e.g., "Top Writer", "Beloved Community Member", or anniversary milestones).<br/>
        /// - Publicly visible on user profiles.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Badge>> GetBadgesAsync(
            int? page = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve all badges<br/>
        /// Retrieve a list of all badges available on the platform.<br/>
        /// ### Badges Overview:<br/>
        /// - Badges recognize achievements (e.g., "Top Writer", "Beloved Community Member", or anniversary milestones).<br/>
        /// - Publicly visible on user profiles.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Badge>>> GetBadgesAsResponseAsync(
            int? page = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}