#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Add a note to a user (Admin)<br/>
        /// Add a new moderation/audit note to a user.<br/>
        /// ### Audit Logging Guidelines:<br/>
        /// - **content**: Plaintext description of behavior, infraction, or actions taken.<br/>
        /// - **reason**: Categorized classification (e.g. `spam`, `abuse`, `harassment`, `administrative`).<br/>
        /// - Requires Super Admin credentials.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminUsersByUserIdNotesAsync(
            int userId,

            global::Forem.CreateAdminUsersNotesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a note to a user (Admin)<br/>
        /// Add a new moderation/audit note to a user.<br/>
        /// ### Audit Logging Guidelines:<br/>
        /// - **content**: Plaintext description of behavior, infraction, or actions taken.<br/>
        /// - **reason**: Categorized classification (e.g. `spam`, `abuse`, `harassment`, `administrative`).<br/>
        /// - Requires Super Admin credentials.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreateAdminUsersByUserIdNotesAsResponseAsync(
            int userId,

            global::Forem.CreateAdminUsersNotesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a note to a user (Admin)<br/>
        /// Add a new moderation/audit note to a user.<br/>
        /// ### Audit Logging Guidelines:<br/>
        /// - **content**: Plaintext description of behavior, infraction, or actions taken.<br/>
        /// - **reason**: Categorized classification (e.g. `spam`, `abuse`, `harassment`, `administrative`).<br/>
        /// - Requires Super Admin credentials.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="content"></param>
        /// <param name="reason"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminUsersByUserIdNotesAsync(
            int userId,
            string content,
            string? reason = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}