#nullable enable

namespace Forem
{
    public partial interface IRequestRedirectsClient
    {
        /// <summary>
        /// Retrieve all request redirects (Admin)<br/>
        /// Retrieve a list of all request redirects configured on the platform.<br/>
        /// ### Redirects Overview:<br/>
        /// - Redirects map incoming HTTP request paths or domains to specific target destination URLs (301 or 302 redirects).<br/>
        /// - Primarily used for managing vanity URLs, legacy path support, or domain migrations.<br/>
        /// - Requires Administrator privileges.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.RequestRedirect>> GetAdminRequestRedirectsAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve all request redirects (Admin)<br/>
        /// Retrieve a list of all request redirects configured on the platform.<br/>
        /// ### Redirects Overview:<br/>
        /// - Redirects map incoming HTTP request paths or domains to specific target destination URLs (301 or 302 redirects).<br/>
        /// - Primarily used for managing vanity URLs, legacy path support, or domain migrations.<br/>
        /// - Requires Administrator privileges.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="perPage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.RequestRedirect>>> GetAdminRequestRedirectsAsResponseAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}