#nullable enable

namespace Forem
{
    public partial interface IConceptsClient
    {
        /// <summary>
        /// Retrieve details of a concept<br/>
        /// Retrieve details, settings, and popularity metrics of a single concept by ID.<br/>
        /// ### Integration Tip:<br/>
        /// - Includes the semantic description, similarity thresholds, parent concept mappings, and scores.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="days"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Concept> GetConceptsByIdAsync(
            int id,
            int? days = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve details of a concept<br/>
        /// Retrieve details, settings, and popularity metrics of a single concept by ID.<br/>
        /// ### Integration Tip:<br/>
        /// - Includes the semantic description, similarity thresholds, parent concept mappings, and scores.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="days"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.Concept>> GetConceptsByIdAsResponseAsync(
            int id,
            int? days = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}