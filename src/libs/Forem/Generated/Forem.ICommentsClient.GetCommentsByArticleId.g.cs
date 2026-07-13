#nullable enable

namespace Forem
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Comments<br/>
        /// This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.<br/>
        /// ### Threaded Structure &amp; Pagination Tips:<br/>
        /// - **Threaded Format**: Comments are returned as a tree structure (nested arrays of replies). Each top-level comment contains its nested child comments recursively.<br/>
        /// - **Query Constraints**: You must provide either `a_id` (Article ID) OR `p_id` (Podcast Episode ID) to fetch comments. Specifying both is not supported.<br/>
        /// - **Pagination**: When paginating, the `page` parameter filters the *top-level* comments only. All replies to those top-level comments are returned nested inline, regardless of page index.<br/>
        /// - If the `page` parameter is omitted, the response returns the full comment tree in a single payload.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="aId"></param>
        /// <param name="pId"></param>
        /// <param name="page2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Comment>> GetCommentsByArticleIdAsync(
            int? page = default,
            int? perPage = default,
            string? aId = default,
            string? pId = default,
            string? page2 = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Comments<br/>
        /// This endpoint allows the client to retrieve all comments belonging to an article or podcast episode as threaded conversations.<br/>
        /// ### Threaded Structure &amp; Pagination Tips:<br/>
        /// - **Threaded Format**: Comments are returned as a tree structure (nested arrays of replies). Each top-level comment contains its nested child comments recursively.<br/>
        /// - **Query Constraints**: You must provide either `a_id` (Article ID) OR `p_id` (Podcast Episode ID) to fetch comments. Specifying both is not supported.<br/>
        /// - **Pagination**: When paginating, the `page` parameter filters the *top-level* comments only. All replies to those top-level comments are returned nested inline, regardless of page index.<br/>
        /// - If the `page` parameter is omitted, the response returns the full comment tree in a single payload.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="aId"></param>
        /// <param name="pId"></param>
        /// <param name="page2"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Comment>>> GetCommentsByArticleIdAsResponseAsync(
            int? page = default,
            int? perPage = default,
            string? aId = default,
            string? pId = default,
            string? page2 = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}