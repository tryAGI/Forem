#nullable enable

namespace Forem
{
    public partial interface ITrendsClient
    {
        /// <summary>
        /// Articles in a Trend<br/>
        /// Retrieve a list of published articles belonging to a trend.<br/>
        /// ### Article Ordering &amp; Proximity:<br/>
        /// - Articles are mapped to trends based on their embedding distance to the trend's centroid.<br/>
        /// - Returned articles are ordered by proximity/similarity (distance) first (most relevant posts first), and then by overall article engagement score.<br/>
        /// - Supports pagination, each page will contain 10 articles by default.
        /// </summary>
        /// <param name="trendIdOrSlug"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>> GetTrendArticlesAsync(
            string trendIdOrSlug,
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Articles in a Trend<br/>
        /// Retrieve a list of published articles belonging to a trend.<br/>
        /// ### Article Ordering &amp; Proximity:<br/>
        /// - Articles are mapped to trends based on their embedding distance to the trend's centroid.<br/>
        /// - Returned articles are ordered by proximity/similarity (distance) first (most relevant posts first), and then by overall article engagement score.<br/>
        /// - Supports pagination, each page will contain 10 articles by default.
        /// </summary>
        /// <param name="trendIdOrSlug"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>>> GetTrendArticlesAsResponseAsync(
            string trendIdOrSlug,
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}