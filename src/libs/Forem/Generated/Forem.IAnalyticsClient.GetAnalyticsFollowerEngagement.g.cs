#nullable enable

namespace Forem
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Retrieve follower engagement analytics<br/>
        /// Retrieve stats detailing new follower growth and engagement over time.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAnalyticsFollowerEngagementAsync(
            string? start = default,
            string? end = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve follower engagement analytics<br/>
        /// Retrieve stats detailing new follower growth and engagement over time.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetAnalyticsFollowerEngagementAsResponseAsync(
            string? start = default,
            string? end = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}