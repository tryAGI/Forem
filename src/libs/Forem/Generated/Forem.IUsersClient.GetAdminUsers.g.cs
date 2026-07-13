#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List all users (Admin)<br/>
        /// Retrieve a list of all users registered on the platform.<br/>
        /// ### Permissions &amp; Filters:<br/>
        /// - Requires Super Admin privileges.<br/>
        /// - Allows filtering by exact `email` or `username`.<br/>
        /// - Returns paginated list of extended user objects containing email addresses, registration dates, roles, and administrative statuses.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAdminUsersAsync(
            int? page = default,
            int? perPage = default,
            string? email = default,
            string? username = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List all users (Admin)<br/>
        /// Retrieve a list of all users registered on the platform.<br/>
        /// ### Permissions &amp; Filters:<br/>
        /// - Requires Super Admin privileges.<br/>
        /// - Allows filtering by exact `email` or `username`.<br/>
        /// - Returns paginated list of extended user objects containing email addresses, registration dates, roles, and administrative statuses.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="email"></param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetAdminUsersAsResponseAsync(
            int? page = default,
            int? perPage = default,
            string? email = default,
            string? username = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}