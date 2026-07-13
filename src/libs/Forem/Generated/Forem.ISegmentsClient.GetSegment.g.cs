#nullable enable

namespace Forem
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// A manually managed audience segment<br/>
        /// Retrieve details of a single manually-managed audience segment specified by ID.<br/>
        /// ### Integration Tip:<br/>
        /// - Includes segment type (`manual`), configuration, and metadata.<br/>
        /// - Automatic/system-generated segments cannot be queried or updated via this endpoint.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetSegmentAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// A manually managed audience segment<br/>
        /// Retrieve details of a single manually-managed audience segment specified by ID.<br/>
        /// ### Integration Tip:<br/>
        /// - Includes segment type (`manual`), configuration, and metadata.<br/>
        /// - Automatic/system-generated segments cannot be queried or updated via this endpoint.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<string>> GetSegmentAsResponseAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}