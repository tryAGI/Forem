#nullable enable

namespace Forem
{
    public partial interface IBadgesClient
    {
        /// <summary>
        /// Update a badge<br/>
        /// Update badge details (title, description, credits awarded, etc.) by unique ID. Requires administrator privileges.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Badge> EditBadgesByIdAsync(
            int id,

            global::Forem.PatchBadgesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a badge<br/>
        /// Update badge details (title, description, credits awarded, etc.) by unique ID. Requires administrator privileges.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.Badge>> EditBadgesByIdAsResponseAsync(
            int id,

            global::Forem.PatchBadgesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a badge<br/>
        /// Update badge details (title, description, credits awarded, etc.) by unique ID. Requires administrator privileges.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="badge"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Badge> EditBadgesByIdAsync(
            int id,
            global::Forem.PatchBadgesRequestBadge? badge = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}