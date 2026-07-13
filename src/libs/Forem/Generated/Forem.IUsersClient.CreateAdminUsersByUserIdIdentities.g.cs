#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Link an identity to a user (Admin)<br/>
        /// Manually link an OAuth provider identity to a user. Requires Super Admin credentials.<br/>
        /// ### Identity Binding:<br/>
        /// - **provider**: The login provider name (e.g. `github`, `twitter`).<br/>
        /// - **uid**: The provider's unique user identifier.<br/>
        /// - **username**: The user's username on the provider's service.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminUsersByUserIdIdentitiesAsync(
            int userId,

            global::Forem.CreateAdminUsersIdentitiesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Link an identity to a user (Admin)<br/>
        /// Manually link an OAuth provider identity to a user. Requires Super Admin credentials.<br/>
        /// ### Identity Binding:<br/>
        /// - **provider**: The login provider name (e.g. `github`, `twitter`).<br/>
        /// - **uid**: The provider's unique user identifier.<br/>
        /// - **username**: The user's username on the provider's service.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreateAdminUsersByUserIdIdentitiesAsResponseAsync(
            int userId,

            global::Forem.CreateAdminUsersIdentitiesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Link an identity to a user (Admin)<br/>
        /// Manually link an OAuth provider identity to a user. Requires Super Admin credentials.<br/>
        /// ### Identity Binding:<br/>
        /// - **provider**: The login provider name (e.g. `github`, `twitter`).<br/>
        /// - **uid**: The provider's unique user identifier.<br/>
        /// - **username**: The user's username on the provider's service.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="provider"></param>
        /// <param name="uid"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminUsersByUserIdIdentitiesAsync(
            int userId,
            string provider,
            string uid,
            string? username = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}