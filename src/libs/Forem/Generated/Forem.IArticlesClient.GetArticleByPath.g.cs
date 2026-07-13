#nullable enable

namespace Forem
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Published article by path<br/>
        /// This endpoint allows the client to retrieve a single published article given its `username` and `slug` (the URL-friendly path identifier).<br/>
        /// ### Usage Tip:<br/>
        /// - Handy for resolving absolute Forem/DEV article URLs (e.g., `https://dev.to/username/slug`) into their corresponding API data models.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetArticleByPathAsync(
            string username,
            string slug,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Published article by path<br/>
        /// This endpoint allows the client to retrieve a single published article given its `username` and `slug` (the URL-friendly path identifier).<br/>
        /// ### Usage Tip:<br/>
        /// - Handy for resolving absolute Forem/DEV article URLs (e.g., `https://dev.to/username/slug`) into their corresponding API data models.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="slug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<string>> GetArticleByPathAsResponseAsync(
            string username,
            string slug,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}