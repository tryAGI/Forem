#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Search for users<br/>
        /// Search for a user by email address.<br/>
        /// ### Permissions &amp; Context:<br/>
        /// - Requires administrative privileges (`api-key` of an administrator).<br/>
        /// - Used to verify account existence or map email addresses to platform usernames.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.ExtendedUser> SearchUsersAsync(
            string email,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for users<br/>
        /// Search for a user by email address.<br/>
        /// ### Permissions &amp; Context:<br/>
        /// - Requires administrative privileges (`api-key` of an administrator).<br/>
        /// - Used to verify account existence or map email addresses to platform usernames.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.ExtendedUser>> SearchUsersAsResponseAsync(
            string email,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}