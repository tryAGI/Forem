#nullable enable

namespace Forem
{
    public partial interface IConceptsClient
    {
        /// <summary>
        /// Update a concept's metadata<br/>
        /// Update concept metadata such as description, similarity threshold, and custom score.<br/>
        /// ### Parameter Guidelines:<br/>
        /// - **similarity_threshold**: Cosine distance threshold (range 0.0 to 1.0) determining how closely an article's embedding must align with the concept's anchor embedding to be classified under it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Concept> EditConceptsByIdAsync(
            int id,

            global::Forem.PatchConceptsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a concept's metadata<br/>
        /// Update concept metadata such as description, similarity threshold, and custom score.<br/>
        /// ### Parameter Guidelines:<br/>
        /// - **similarity_threshold**: Cosine distance threshold (range 0.0 to 1.0) determining how closely an article's embedding must align with the concept's anchor embedding to be classified under it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.Concept>> EditConceptsByIdAsResponseAsync(
            int id,

            global::Forem.PatchConceptsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a concept's metadata<br/>
        /// Update concept metadata such as description, similarity threshold, and custom score.<br/>
        /// ### Parameter Guidelines:<br/>
        /// - **similarity_threshold**: Cosine distance threshold (range 0.0 to 1.0) determining how closely an article's embedding must align with the concept's anchor embedding to be classified under it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="concept"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Concept> EditConceptsByIdAsync(
            int id,
            global::Forem.PatchConceptsRequestConcept? concept = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}