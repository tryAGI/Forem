#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Bulk link identities (Admin)<br/>
        /// Bulk link OAuth identities across multiple users. Requires Super Admin credentials.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminUsersIdentitiesBulkAsync(

            global::Forem.CreateAdminUsersIdentitiesBulkRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk link identities (Admin)<br/>
        /// Bulk link OAuth identities across multiple users. Requires Super Admin credentials.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreateAdminUsersIdentitiesBulkAsResponseAsync(

            global::Forem.CreateAdminUsersIdentitiesBulkRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk link identities (Admin)<br/>
        /// Bulk link OAuth identities across multiple users. Requires Super Admin credentials.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="identities"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminUsersIdentitiesBulkAsync(
            string provider,
            global::System.Collections.Generic.IList<global::Forem.CreateAdminUsersIdentitiesBulkRequestIdentitie> identities,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}