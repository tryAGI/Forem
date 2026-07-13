#nullable enable

namespace Forem
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Retrieve dashboard analytics bundle<br/>
        /// Retrieve a complete bundled metrics package (totals, history, top posts) for rendering dashboard landing pages.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="articleId"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAnalyticsDashboardAsync(
            string? start = default,
            string? end = default,
            int? articleId = default,
            int? organizationId = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve dashboard analytics bundle<br/>
        /// Retrieve a complete bundled metrics package (totals, history, top posts) for rendering dashboard landing pages.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="articleId"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetAnalyticsDashboardAsResponseAsync(
            string? start = default,
            string? end = default,
            int? articleId = default,
            int? organizationId = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}