#nullable enable

namespace Forem
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Retrieve analytics totals<br/>
        /// Retrieve aggregated lifetime stats (views, reactions, comments) for articles.<br/>
        /// ### Scope Control:<br/>
        /// - Specify `article_id` to query a single post's metrics.<br/>
        /// - Specify `organization_id` to retrieve metrics across all articles owned by the target organization.
        /// </summary>
        /// <param name="articleId"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAnalyticsTotalsAsync(
            int? articleId = default,
            int? organizationId = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve analytics totals<br/>
        /// Retrieve aggregated lifetime stats (views, reactions, comments) for articles.<br/>
        /// ### Scope Control:<br/>
        /// - Specify `article_id` to query a single post's metrics.<br/>
        /// - Specify `organization_id` to retrieve metrics across all articles owned by the target organization.
        /// </summary>
        /// <param name="articleId"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetAnalyticsTotalsAsResponseAsync(
            int? articleId = default,
            int? organizationId = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}