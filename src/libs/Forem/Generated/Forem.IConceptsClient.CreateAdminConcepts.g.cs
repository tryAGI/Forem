#nullable enable

namespace Forem
{
    public partial interface IConceptsClient
    {
        /// <summary>
        /// Create a concept (Admin)<br/>
        /// Create a new Concept.<br/>
        /// ### Parameters:<br/>
        /// - **name**: Human readable label for the concept.<br/>
        /// - **description**: Detailed semantic definition used to generate the anchor embedding.<br/>
        /// - **similarity_threshold**: Target similarity threshold for categorizing articles under this concept.<br/>
        /// - **parent_id**: ID of parent concept, if establishing a hierarchy.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Concept> CreateAdminConceptsAsync(

            global::Forem.CreateAdminConceptsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a concept (Admin)<br/>
        /// Create a new Concept.<br/>
        /// ### Parameters:<br/>
        /// - **name**: Human readable label for the concept.<br/>
        /// - **description**: Detailed semantic definition used to generate the anchor embedding.<br/>
        /// - **similarity_threshold**: Target similarity threshold for categorizing articles under this concept.<br/>
        /// - **parent_id**: ID of parent concept, if establishing a hierarchy.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.Concept>> CreateAdminConceptsAsResponseAsync(

            global::Forem.CreateAdminConceptsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a concept (Admin)<br/>
        /// Create a new Concept.<br/>
        /// ### Parameters:<br/>
        /// - **name**: Human readable label for the concept.<br/>
        /// - **description**: Detailed semantic definition used to generate the anchor embedding.<br/>
        /// - **similarity_threshold**: Target similarity threshold for categorizing articles under this concept.<br/>
        /// - **parent_id**: ID of parent concept, if establishing a hierarchy.
        /// </summary>
        /// <param name="concept"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Concept> CreateAdminConceptsAsync(
            global::Forem.CreateAdminConceptsRequestConcept? concept = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}