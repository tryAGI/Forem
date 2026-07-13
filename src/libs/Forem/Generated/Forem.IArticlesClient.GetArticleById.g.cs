#nullable enable

namespace Forem
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Published article by id<br/>
        /// This endpoint allows the client to retrieve a single published article given its unique numerical `id`.<br/>
        /// ### Integration Tip:<br/>
        /// - Returns the complete serialized article object including its HTML/markdown representation, tags, and author profile details.<br/>
        /// - To retrieve an article using its URL path structure instead of its numeric ID, use the `/api/articles/{username}/{slug}` endpoint.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetArticleByIdAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Published article by id<br/>
        /// This endpoint allows the client to retrieve a single published article given its unique numerical `id`.<br/>
        /// ### Integration Tip:<br/>
        /// - Returns the complete serialized article object including its HTML/markdown representation, tags, and author profile details.<br/>
        /// - To retrieve an article using its URL path structure instead of its numeric ID, use the `/api/articles/{username}/{slug}` endpoint.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<string>> GetArticleByIdAsResponseAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}