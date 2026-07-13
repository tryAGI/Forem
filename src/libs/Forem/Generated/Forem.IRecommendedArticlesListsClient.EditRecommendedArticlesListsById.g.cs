#nullable enable

namespace Forem
{
    public partial interface IRecommendedArticlesListsClient
    {
        /// <summary>
        /// Update a recommended articles list<br/>
        /// Update an existing recommended articles list by ID. Requires Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.RecommendedArticlesList> EditRecommendedArticlesListsByIdAsync(
            int id,

            global::Forem.PatchRecommendedArticlesListsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a recommended articles list<br/>
        /// Update an existing recommended articles list by ID. Requires Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.RecommendedArticlesList>> EditRecommendedArticlesListsByIdAsResponseAsync(
            int id,

            global::Forem.PatchRecommendedArticlesListsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a recommended articles list<br/>
        /// Update an existing recommended articles list by ID. Requires Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="placementArea"></param>
        /// <param name="expiresAt"></param>
        /// <param name="userId"></param>
        /// <param name="articleIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.RecommendedArticlesList> EditRecommendedArticlesListsByIdAsync(
            int id,
            string? name = default,
            string? placementArea = default,
            global::System.DateTime? expiresAt = default,
            int? userId = default,
            global::System.Collections.Generic.IList<int>? articleIds = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}