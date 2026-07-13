#nullable enable

namespace Forem
{
    public partial interface IFollowersClient
    {
        /// <summary>
        /// Followers<br/>
        /// This endpoint allows the client to retrieve a list of the followers they have.<br/>
        ///         ### Integration &amp; Pagination Guidance:<br/>
        ///         - "Followers" are other users registered on the platform who follow the authenticated user.<br/>
        ///         - Supports pagination, defaulting to 80 followers per page.<br/>
        ///         - The `sort` query parameter determines the sorting order based on when the follow relationship was established.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.GetFollowersResponseItem>> GetFollowersAsync(
            int? page = default,
            int? perPage = default,
            string? sort = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Followers<br/>
        /// This endpoint allows the client to retrieve a list of the followers they have.<br/>
        ///         ### Integration &amp; Pagination Guidance:<br/>
        ///         - "Followers" are other users registered on the platform who follow the authenticated user.<br/>
        ///         - Supports pagination, defaulting to 80 followers per page.<br/>
        ///         - The `sort` query parameter determines the sorting order based on when the follow relationship was established.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="sort"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.GetFollowersResponseItem>>> GetFollowersAsResponseAsync(
            int? page = default,
            int? perPage = default,
            string? sort = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}