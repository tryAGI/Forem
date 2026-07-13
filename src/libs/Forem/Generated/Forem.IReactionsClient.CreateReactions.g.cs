#nullable enable

namespace Forem
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// create reaction<br/>
        /// Create a reaction on a target resource (Article, Comment, or User) on behalf of the authenticated user.<br/>
        ///         ### Usage Details:<br/>
        ///         - Unlike the toggle endpoint, this endpoint is idempotent: multiple requests to react with the same category to the same target will return the existing reaction without deleting it.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="reactableId"></param>
        /// <param name="reactableType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateReactionsAsync(
            global::Forem.CreateReactionsCategory category,
            int reactableId,
            global::Forem.CreateReactionsReactableType reactableType,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// create reaction<br/>
        /// Create a reaction on a target resource (Article, Comment, or User) on behalf of the authenticated user.<br/>
        ///         ### Usage Details:<br/>
        ///         - Unlike the toggle endpoint, this endpoint is idempotent: multiple requests to react with the same category to the same target will return the existing reaction without deleting it.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="reactableId"></param>
        /// <param name="reactableType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreateReactionsAsResponseAsync(
            global::Forem.CreateReactionsCategory category,
            int reactableId,
            global::Forem.CreateReactionsReactableType reactableType,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}