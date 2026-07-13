#nullable enable

namespace Forem
{
    public partial interface IRecommendedArticlesListsClient
    {
        /// <summary>
        /// Retrieve all recommended articles lists<br/>
        /// Retrieve a list of all recommended articles lists configured in the system.<br/>
        /// ### Overview:<br/>
        /// - Recommended Articles Lists are curated selections of articles pinned or recommended in layout regions (e.g. `main_feed` or `sidebar`).<br/>
        /// - Supports search by list name and standard query pagination.<br/>
        /// - Requires Administrator privileges.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.RecommendedArticlesList>> GetRecommendedArticlesListsAsync(
            int? page = default,
            string? search = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve all recommended articles lists<br/>
        /// Retrieve a list of all recommended articles lists configured in the system.<br/>
        /// ### Overview:<br/>
        /// - Recommended Articles Lists are curated selections of articles pinned or recommended in layout regions (e.g. `main_feed` or `sidebar`).<br/>
        /// - Supports search by list name and standard query pagination.<br/>
        /// - Requires Administrator privileges.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="search"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.RecommendedArticlesList>>> GetRecommendedArticlesListsAsResponseAsync(
            int? page = default,
            string? search = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}