#nullable enable

namespace Forem
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// Manually managed audience segments<br/>
        /// Retrieve a list of manually managed audience segments.<br/>
        /// ### Audience Segments Overview:<br/>
        /// - Audience Segments are cohorts of users grouped together for targeting announcements, features, or promotional campaign banners (Billboards).<br/>
        /// - This endpoint lists manual cohorts created and maintained by site administrators.<br/>
        /// - Requires administrator privileges.<br/>
        /// The endpoint supports pagination, and each page will contain `30` segments by default.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Segment>> GetSegmentsAsync(
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Manually managed audience segments<br/>
        /// Retrieve a list of manually managed audience segments.<br/>
        /// ### Audience Segments Overview:<br/>
        /// - Audience Segments are cohorts of users grouped together for targeting announcements, features, or promotional campaign banners (Billboards).<br/>
        /// - This endpoint lists manual cohorts created and maintained by site administrators.<br/>
        /// - Requires administrator privileges.<br/>
        /// The endpoint supports pagination, and each page will contain `30` segments by default.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Segment>>> GetSegmentsAsResponseAsync(
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}