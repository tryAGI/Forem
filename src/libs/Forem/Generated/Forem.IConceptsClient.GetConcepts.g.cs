#nullable enable

namespace Forem
{
    public partial interface IConceptsClient
    {
        /// <summary>
        /// Retrieve all accessible concepts<br/>
        /// Retrieve all accessible concepts in the system.<br/>
        /// ### Concepts Overview:<br/>
        /// - Concepts are semantic tags generated automatically by analyzing article text using ML embeddings (`gemini-embedding-2`), rather than explicit user tags.<br/>
        /// - Primarily used for advanced semantic categorization, automated feeds, and interest mapping.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="days"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Concept>> GetConceptsAsync(
            int? page = default,
            int? perPage = default,
            int? days = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve all accessible concepts<br/>
        /// Retrieve all accessible concepts in the system.<br/>
        /// ### Concepts Overview:<br/>
        /// - Concepts are semantic tags generated automatically by analyzing article text using ML embeddings (`gemini-embedding-2`), rather than explicit user tags.<br/>
        /// - Primarily used for advanced semantic categorization, automated feeds, and interest mapping.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="days"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Concept>>> GetConceptsAsResponseAsync(
            int? page = default,
            int? perPage = default,
            int? days = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}