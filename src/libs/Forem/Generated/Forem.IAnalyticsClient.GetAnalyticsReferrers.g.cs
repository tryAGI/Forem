#nullable enable

namespace Forem
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Retrieve referrer analytics<br/>
        /// Retrieve traffic referring domains and URL source tracking metrics for articles.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="articleId"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAnalyticsReferrersAsync(
            string? start = default,
            string? end = default,
            int? articleId = default,
            int? organizationId = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve referrer analytics<br/>
        /// Retrieve traffic referring domains and URL source tracking metrics for articles.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="articleId"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetAnalyticsReferrersAsResponseAsync(
            string? start = default,
            string? end = default,
            int? articleId = default,
            int? organizationId = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}