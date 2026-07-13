#nullable enable

namespace Forem
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// An organization (by username)<br/>
        /// Retrieve public profile information for a single organization by its username.<br/>
        /// ### Integration Tip:<br/>
        /// - Bypasses authentication.<br/>
        /// - Returns details like Tech Stack, Tagline, Story, website URLs, and joined date.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetOrganizationAsync(
            string username,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// An organization (by username)<br/>
        /// Retrieve public profile information for a single organization by its username.<br/>
        /// ### Integration Tip:<br/>
        /// - Bypasses authentication.<br/>
        /// - Returns details like Tech Stack, Tagline, Story, website URLs, and joined date.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<string>> GetOrganizationAsResponseAsync(
            string username,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}