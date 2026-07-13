#nullable enable

namespace Forem
{
    public partial interface IRequestRedirectsClient
    {
        /// <summary>
        /// Update a request redirect (Admin)<br/>
        /// Update details (paths or domain scope) of an existing redirect route by ID. Requires Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.RequestRedirect> EditAdminRequestRedirectsByIdAsync(
            int id,

            global::Forem.PatchAdminRequestRedirectsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a request redirect (Admin)<br/>
        /// Update details (paths or domain scope) of an existing redirect route by ID. Requires Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.RequestRedirect>> EditAdminRequestRedirectsByIdAsResponseAsync(
            int id,

            global::Forem.PatchAdminRequestRedirectsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a request redirect (Admin)<br/>
        /// Update details (paths or domain scope) of an existing redirect route by ID. Requires Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestRedirect"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.RequestRedirect> EditAdminRequestRedirectsByIdAsync(
            int id,
            global::Forem.PatchAdminRequestRedirectsRequestRequestRedirect? requestRedirect = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}