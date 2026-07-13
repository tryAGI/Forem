#nullable enable

namespace Forem
{
    public partial interface IBillboardsClient
    {
        /// <summary>
        /// Update a billboard by ID<br/>
        /// Update an existing billboard's configurations.<br/>
        ///         ### Integration Guidance:<br/>
        ///         - Allows changing placement area, geolocations, target segments, or text copy.<br/>
        ///         - Updating an active billboard takes effect instantly in the layout delivery cache.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PutBillboardsByIdAsync(
            int id,

            object request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a billboard by ID<br/>
        /// Update an existing billboard's configurations.<br/>
        ///         ### Integration Guidance:<br/>
        ///         - Allows changing placement area, geolocations, target segments, or text copy.<br/>
        ///         - Updating an active billboard takes effect instantly in the layout delivery cache.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<string>> PutBillboardsByIdAsResponseAsync(
            int id,

            object request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a billboard by ID<br/>
        /// Update an existing billboard's configurations.<br/>
        ///         ### Integration Guidance:<br/>
        ///         - Allows changing placement area, geolocations, target segments, or text copy.<br/>
        ///         - Updating an active billboard takes effect instantly in the layout delivery cache.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PutBillboardsByIdAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}