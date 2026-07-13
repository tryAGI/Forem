#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update user moderation status (Admin)<br/>
        /// Manually update a user's moderation status.<br/>
        /// ### Status Details:<br/>
        /// - **status**: Allowed target states (e.g. `active`, `suspended`, `banned`).<br/>
        /// - **note**: Required reason text recorded in the user's moderation log audit history.<br/>
        /// - Requires Super Admin privileges.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminUsersByIdStatusAsync(
            int id,

            global::Forem.PutAdminUsersStatusRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user moderation status (Admin)<br/>
        /// Manually update a user's moderation status.<br/>
        /// ### Status Details:<br/>
        /// - **status**: Allowed target states (e.g. `active`, `suspended`, `banned`).<br/>
        /// - **note**: Required reason text recorded in the user's moderation log audit history.<br/>
        /// - Requires Super Admin privileges.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> PutAdminUsersByIdStatusAsResponseAsync(
            int id,

            global::Forem.PutAdminUsersStatusRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user moderation status (Admin)<br/>
        /// Manually update a user's moderation status.<br/>
        /// ### Status Details:<br/>
        /// - **status**: Allowed target states (e.g. `active`, `suspended`, `banned`).<br/>
        /// - **note**: Required reason text recorded in the user's moderation log audit history.<br/>
        /// - Requires Super Admin privileges.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="note"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminUsersByIdStatusAsync(
            int id,
            string status,
            string? note = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}