#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List notes for a user (Admin)<br/>
        /// Retrieve all moderator/administrator audit log notes appended to a user. Requires Super Admin credentials.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetAdminUsersByUserIdNotesAsync(
            int userId,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List notes for a user (Admin)<br/>
        /// Retrieve all moderator/administrator audit log notes appended to a user. Requires Super Admin credentials.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetAdminUsersByUserIdNotesAsResponseAsync(
            int userId,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}