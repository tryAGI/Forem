#nullable enable

namespace Forem
{
    public partial interface IBillboardsClient
    {
        /// <summary>
        /// Billboards<br/>
        /// Retrieve a list of all billboards configured in the system.<br/>
        ///         ### Billboards Overview:<br/>
        ///         - Billboards are custom promotional ads, notification banners, or call-to-actions shown on the Forem website.<br/>
        ///         - Requires administrative privileges.<br/>
        ///         - Returned objects include layout code, scheduling parameters, geo-targeting configurations, and custom target audience segment associations.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Billboard>> GetBillboardsAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Billboards<br/>
        /// Retrieve a list of all billboards configured in the system.<br/>
        ///         ### Billboards Overview:<br/>
        ///         - Billboards are custom promotional ads, notification banners, or call-to-actions shown on the Forem website.<br/>
        ///         - Requires administrative privileges.<br/>
        ///         - Returned objects include layout code, scheduling parameters, geo-targeting configurations, and custom target audience segment associations.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Billboard>>> GetBillboardsAsResponseAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}