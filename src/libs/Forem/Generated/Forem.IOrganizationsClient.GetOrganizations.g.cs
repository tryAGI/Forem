#nullable enable

namespace Forem
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Organizations<br/>
        /// This endpoint allows the client to retrieve a list of Dev organizations.<br/>
        ///   It supports pagination, each page will contain 10 tags by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Organization>> GetOrganizationsAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organizations<br/>
        /// This endpoint allows the client to retrieve a list of Dev organizations.<br/>
        ///   It supports pagination, each page will contain 10 tags by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Organization>>> GetOrganizationsAsResponseAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}