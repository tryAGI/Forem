#nullable enable

namespace Forem
{
    public partial interface IRequestRedirectsClient
    {
        /// <summary>
        /// Retrieve a request redirect's details (Admin)<br/>
        /// Retrieve details of a single request redirect route by ID. Requires Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.RequestRedirect> GetAdminRequestRedirectsByIdAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve a request redirect's details (Admin)<br/>
        /// Retrieve details of a single request redirect route by ID. Requires Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.RequestRedirect>> GetAdminRequestRedirectsByIdAsResponseAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}