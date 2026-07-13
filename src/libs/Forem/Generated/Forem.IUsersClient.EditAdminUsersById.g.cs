#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update user profile (Admin)<br/>
        /// Update a user's public profile fields (name, location, bio summary, website) on their behalf. Requires Super Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task EditAdminUsersByIdAsync(
            int id,

            global::Forem.PatchAdminUsersRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user profile (Admin)<br/>
        /// Update a user's public profile fields (name, location, bio summary, website) on their behalf. Requires Super Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> EditAdminUsersByIdAsResponseAsync(
            int id,

            global::Forem.PatchAdminUsersRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user profile (Admin)<br/>
        /// Update a user's public profile fields (name, location, bio summary, website) on their behalf. Requires Super Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="username"></param>
        /// <param name="summary"></param>
        /// <param name="location"></param>
        /// <param name="websiteUrl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditAdminUsersByIdAsync(
            int id,
            string? name = default,
            string? username = default,
            string? summary = default,
            string? location = default,
            string? websiteUrl = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}