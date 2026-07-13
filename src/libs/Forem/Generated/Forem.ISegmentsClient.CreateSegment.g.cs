#nullable enable

namespace Forem
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// Create a manually managed audience segment<br/>
        /// Create a new manually managed audience segment.<br/>
        /// ### Usage Guidance:<br/>
        /// - Used by administrators to define a new target cohort group.<br/>
        /// - Users can be added or removed in bulk later via segment member endpoints.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateSegmentAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a manually managed audience segment<br/>
        /// Create a new manually managed audience segment.<br/>
        /// ### Usage Guidance:<br/>
        /// - Used by administrators to define a new target cohort group.<br/>
        /// - Users can be added or removed in bulk later via segment member endpoints.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreateSegmentAsResponseAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}