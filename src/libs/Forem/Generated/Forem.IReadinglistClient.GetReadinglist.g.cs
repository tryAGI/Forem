#nullable enable

namespace Forem
{
    public partial interface IReadinglistClient
    {
        /// <summary>
        /// Readinglist<br/>
        /// Retrieve the list of articles saved to the authenticated user's reading list.<br/>
        ///         ### Integration Guidance:<br/>
        ///         - Requires authentication.<br/>
        ///         - Under the hood, this endpoint retrieves articles that the user has reacted to with the `"save"` reaction category.<br/>
        ///         - Supports pagination, defaulting to 30 articles per page.<br/>
        ///         - Returned objects conform to the standard `ArticleIndex` schema.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>> GetReadinglistAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Readinglist<br/>
        /// Retrieve the list of articles saved to the authenticated user's reading list.<br/>
        ///         ### Integration Guidance:<br/>
        ///         - Requires authentication.<br/>
        ///         - Under the hood, this endpoint retrieves articles that the user has reacted to with the `"save"` reaction category.<br/>
        ///         - Supports pagination, defaulting to 30 articles per page.<br/>
        ///         - Returned objects conform to the standard `ArticleIndex` schema.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>>> GetReadinglistAsResponseAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}