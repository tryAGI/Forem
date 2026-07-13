#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Invite a User<br/>
        /// Invite a new user to join the platform by email.<br/>
        /// ### Super Admin Action:<br/>
        /// - Requires Super Admin privileges.<br/>
        /// - Triggers a system invitation flow and sends an invitation email containing a sign-up link.<br/>
        /// - Handy for invite-only platforms or private enterprise instances.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task PostAdminUsersCreateAsync(

            global::Forem.UserInviteParam request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite a User<br/>
        /// Invite a new user to join the platform by email.<br/>
        /// ### Super Admin Action:<br/>
        /// - Requires Super Admin privileges.<br/>
        /// - Triggers a system invitation flow and sends an invitation email containing a sign-up link.<br/>
        /// - Handy for invite-only platforms or private enterprise instances.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> PostAdminUsersCreateAsResponseAsync(

            global::Forem.UserInviteParam request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Invite a User<br/>
        /// Invite a new user to join the platform by email.<br/>
        /// ### Super Admin Action:<br/>
        /// - Requires Super Admin privileges.<br/>
        /// - Triggers a system invitation flow and sends an invitation email containing a sign-up link.<br/>
        /// - Handy for invite-only platforms or private enterprise instances.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PostAdminUsersCreateAsync(
            string? email = default,
            string? name = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}