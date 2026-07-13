#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user detail (Admin)<br/>
        /// Retrieve details of a single user by numerical ID.<br/>
        /// ### Super Admin Action:<br/>
        /// - Requires Super Admin privileges.<br/>
        /// - Includes administrative settings, audit notes, email newsletter preferences, and OAuth login identity states.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAdminUsersByIdAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get user detail (Admin)<br/>
        /// Retrieve details of a single user by numerical ID.<br/>
        /// ### Super Admin Action:<br/>
        /// - Requires Super Admin privileges.<br/>
        /// - Includes administrative settings, audit notes, email newsletter preferences, and OAuth login identity states.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetAdminUsersByIdAsResponseAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}