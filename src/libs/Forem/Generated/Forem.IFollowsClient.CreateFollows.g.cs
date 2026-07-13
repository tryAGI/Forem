#nullable enable

namespace Forem
{
    public partial interface IFollowsClient
    {
        /// <summary>
        /// Follow users or organizations<br/>
        /// Follow users or organizations in bulk on behalf of the authenticated user.<br/>
        /// ### Bulk Update Behavior:<br/>
        /// - Accepts arrays of `user_ids` and `organization_ids` in the request body.<br/>
        /// - Performs follow actions for all provided identifiers.<br/>
        /// - Highly efficient for onboarding flows or importing social connections.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.CreateFollowsResponse> CreateFollowsAsync(

            global::Forem.CreateFollowsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Follow users or organizations<br/>
        /// Follow users or organizations in bulk on behalf of the authenticated user.<br/>
        /// ### Bulk Update Behavior:<br/>
        /// - Accepts arrays of `user_ids` and `organization_ids` in the request body.<br/>
        /// - Performs follow actions for all provided identifiers.<br/>
        /// - Highly efficient for onboarding flows or importing social connections.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.CreateFollowsResponse>> CreateFollowsAsResponseAsync(

            global::Forem.CreateFollowsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Follow users or organizations<br/>
        /// Follow users or organizations in bulk on behalf of the authenticated user.<br/>
        /// ### Bulk Update Behavior:<br/>
        /// - Accepts arrays of `user_ids` and `organization_ids` in the request body.<br/>
        /// - Performs follow actions for all provided identifiers.<br/>
        /// - Highly efficient for onboarding flows or importing social connections.
        /// </summary>
        /// <param name="userIds"></param>
        /// <param name="organizationIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.CreateFollowsResponse> CreateFollowsAsync(
            global::System.Collections.Generic.IList<int>? userIds = default,
            global::System.Collections.Generic.IList<int>? organizationIds = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}