#nullable enable

namespace Forem
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// Users in a manually managed audience segment<br/>
        /// Retrieve a paginated list of users enrolled in the specified manual audience segment.<br/>
        /// ### Pagination Guidance:<br/>
        /// - Supports standard `page` and `per_page` controls, returning 30 users per page by default.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.User>> GetUsersInSegmentAsync(
            int id,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Users in a manually managed audience segment<br/>
        /// Retrieve a paginated list of users enrolled in the specified manual audience segment.<br/>
        /// ### Pagination Guidance:<br/>
        /// - Supports standard `page` and `per_page` controls, returning 30 users per page by default.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.User>>> GetUsersInSegmentAsResponseAsync(
            int id,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}