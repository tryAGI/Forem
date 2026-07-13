#nullable enable

namespace Forem
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Retrieve heatmap activity<br/>
        /// Retrieve user activity heatmap metrics (commits, posts, reactions) grouped by weekdays and hours.
        /// </summary>
        /// <param name="end"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAnalyticsHeatmapAsync(
            string? end = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve heatmap activity<br/>
        /// Retrieve user activity heatmap metrics (commits, posts, reactions) grouped by weekdays and hours.
        /// </summary>
        /// <param name="end"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetAnalyticsHeatmapAsResponseAsync(
            string? end = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}