#nullable enable

namespace Forem
{
    public partial interface IAnalyticsClient
    {
        /// <summary>
        /// Retrieve historical analytics<br/>
        /// Retrieve historical analytics data graphed over a time range.<br/>
        /// ### Time Range Formats:<br/>
        /// - **start**: Start date (e.g. `2024-01-01`). Required.<br/>
        /// - **end**: End date (e.g. `2024-01-31`). Defaults to current date if omitted.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="articleId"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAnalyticsHistoricalAsync(
            string start,
            string? end = default,
            int? articleId = default,
            int? organizationId = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve historical analytics<br/>
        /// Retrieve historical analytics data graphed over a time range.<br/>
        /// ### Time Range Formats:<br/>
        /// - **start**: Start date (e.g. `2024-01-01`). Required.<br/>
        /// - **end**: End date (e.g. `2024-01-31`). Defaults to current date if omitted.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="articleId"></param>
        /// <param name="organizationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetAnalyticsHistoricalAsResponseAsync(
            string start,
            string? end = default,
            int? articleId = default,
            int? organizationId = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}