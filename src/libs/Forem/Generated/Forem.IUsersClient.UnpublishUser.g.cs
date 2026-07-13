#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Unpublish a User's Articles and Comments<br/>
        /// This endpoint allows the client to unpublish all of the articles and comments created by a user.<br/>
        /// ### Administrative Action:<br/>
        /// - Requires the authenticated user to be an Administrator.<br/>
        /// - This is a destructive administrative action that immediately unpublishes all posts/comments from public feeds.<br/>
        /// - Ideal for handling spam accounts or cleanup operations.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task UnpublishUserAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unpublish a User's Articles and Comments<br/>
        /// This endpoint allows the client to unpublish all of the articles and comments created by a user.<br/>
        /// ### Administrative Action:<br/>
        /// - Requires the authenticated user to be an Administrator.<br/>
        /// - This is a destructive administrative action that immediately unpublishes all posts/comments from public feeds.<br/>
        /// - Ideal for handling spam accounts or cleanup operations.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> UnpublishUserAsResponseAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}