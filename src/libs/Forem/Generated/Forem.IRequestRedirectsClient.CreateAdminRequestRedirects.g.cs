#nullable enable

namespace Forem
{
    public partial interface IRequestRedirectsClient
    {
        /// <summary>
        /// Create a request redirect (Admin)<br/>
        /// Create a new request redirect route. Requires Administrator privileges.<br/>
        /// ### Body Parameter Guidelines:<br/>
        /// - **original_url**: The source path (e.g. `/old-page`) to intercept.<br/>
        /// - **destination_url**: The target destination (e.g. `https://myforem.com/new-page`) to redirect users to.<br/>
        /// - **request_domain**: The domain scope (e.g. `dev.to`) where this redirect rule applies.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.RequestRedirect> CreateAdminRequestRedirectsAsync(

            global::Forem.CreateAdminRequestRedirectsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a request redirect (Admin)<br/>
        /// Create a new request redirect route. Requires Administrator privileges.<br/>
        /// ### Body Parameter Guidelines:<br/>
        /// - **original_url**: The source path (e.g. `/old-page`) to intercept.<br/>
        /// - **destination_url**: The target destination (e.g. `https://myforem.com/new-page`) to redirect users to.<br/>
        /// - **request_domain**: The domain scope (e.g. `dev.to`) where this redirect rule applies.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.RequestRedirect>> CreateAdminRequestRedirectsAsResponseAsync(

            global::Forem.CreateAdminRequestRedirectsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a request redirect (Admin)<br/>
        /// Create a new request redirect route. Requires Administrator privileges.<br/>
        /// ### Body Parameter Guidelines:<br/>
        /// - **original_url**: The source path (e.g. `/old-page`) to intercept.<br/>
        /// - **destination_url**: The target destination (e.g. `https://myforem.com/new-page`) to redirect users to.<br/>
        /// - **request_domain**: The domain scope (e.g. `dev.to`) where this redirect rule applies.
        /// </summary>
        /// <param name="requestRedirect"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.RequestRedirect> CreateAdminRequestRedirectsAsync(
            global::Forem.CreateAdminRequestRedirectsRequestRequestRedirect? requestRedirect = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}