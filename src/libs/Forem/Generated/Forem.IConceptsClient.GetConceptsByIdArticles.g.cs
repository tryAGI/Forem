#nullable enable

namespace Forem
{
    public partial interface IConceptsClient
    {
        /// <summary>
        /// Retrieve articles mapped to a concept<br/>
        /// Retrieve articles classified under this concept.<br/>
        /// ### Parameter Guidelines:<br/>
        /// - **sort**: Set to `-similarity` to sort articles by cosine similarity (most relevant first), `-published_at` to sort chronologically, or `-score` to sort by platform popularity score.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>> GetConceptsByIdArticlesAsync(
            int id,
            string? sort = default,
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve articles mapped to a concept<br/>
        /// Retrieve articles classified under this concept.<br/>
        /// ### Parameter Guidelines:<br/>
        /// - **sort**: Set to `-similarity` to sort articles by cosine similarity (most relevant first), `-published_at` to sort chronologically, or `-score` to sort by platform popularity score.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="sort"></param>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>>> GetConceptsByIdArticlesAsResponseAsync(
            int id,
            string? sort = default,
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}