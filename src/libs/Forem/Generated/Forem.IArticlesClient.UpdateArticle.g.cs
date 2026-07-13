#nullable enable

namespace Forem
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Update an article by id<br/>
        /// This endpoint allows the client to update an existing article by its unique numerical `id`.<br/>
        /// ### Authorization Constraints:<br/>
        /// - The API key provided must belong to the author of the article.<br/>
        /// - Supports updating individual fields such as `title`, `body_markdown`, `published`, `tags`, etc.<br/>
        /// - Setting `published: false` on an already published article will revert it to draft status.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task UpdateArticleAsync(
            int id,

            global::Forem.Article request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an article by id<br/>
        /// This endpoint allows the client to update an existing article by its unique numerical `id`.<br/>
        /// ### Authorization Constraints:<br/>
        /// - The API key provided must belong to the author of the article.<br/>
        /// - Supports updating individual fields such as `title`, `body_markdown`, `published`, `tags`, etc.<br/>
        /// - Setting `published: false` on an already published article will revert it to draft status.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> UpdateArticleAsResponseAsync(
            int id,

            global::Forem.Article request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an article by id<br/>
        /// This endpoint allows the client to update an existing article by its unique numerical `id`.<br/>
        /// ### Authorization Constraints:<br/>
        /// - The API key provided must belong to the author of the article.<br/>
        /// - Supports updating individual fields such as `title`, `body_markdown`, `published`, `tags`, etc.<br/>
        /// - Setting `published: false` on an already published article will revert it to draft status.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="article1"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task UpdateArticleAsync(
            int id,
            global::Forem.ArticleArticle1? article1 = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}