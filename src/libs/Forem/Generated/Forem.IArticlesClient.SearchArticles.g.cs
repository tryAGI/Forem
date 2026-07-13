#nullable enable

namespace Forem
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Search for articles<br/>
        /// This endpoint allows the client to search for articles.<br/>
        /// ### Search Guidance:<br/>
        /// - **q**: The search query term. Matches against article titles, tags, and body content.<br/>
        /// - **top**: Restricts search results to articles published within the last `N` days.<br/>
        /// - **page** &amp; **per_page**: Standard pagination support. Use this to display results sequentially on a search results page.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="top"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>> SearchArticlesAsync(
            string? q = default,
            int? top = default,
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for articles<br/>
        /// This endpoint allows the client to search for articles.<br/>
        /// ### Search Guidance:<br/>
        /// - **q**: The search query term. Matches against article titles, tags, and body content.<br/>
        /// - **top**: Restricts search results to articles published within the last `N` days.<br/>
        /// - **page** &amp; **per_page**: Standard pagination support. Use this to display results sequentially on a search results page.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="top"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>>> SearchArticlesAsResponseAsync(
            string? q = default,
            int? top = default,
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}