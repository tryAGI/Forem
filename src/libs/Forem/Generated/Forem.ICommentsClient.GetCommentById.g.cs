#nullable enable

namespace Forem
{
    public partial interface ICommentsClient
    {
        /// <summary>
        /// Comment by id<br/>
        /// This endpoint allows the client to retrieve a specific comment and all of its nested descendant replies.<br/>
        /// ### Integration Tip:<br/>
        /// - Handy for linking directly to a deep comment thread or loading individual comment replies on demand.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetCommentByIdAsync(
            string id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Comment by id<br/>
        /// This endpoint allows the client to retrieve a specific comment and all of its nested descendant replies.<br/>
        /// ### Integration Tip:<br/>
        /// - Handy for linking directly to a deep comment thread or loading individual comment replies on demand.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetCommentByIdAsResponseAsync(
            string id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}