#nullable enable

namespace Forem
{
    public partial interface ISegmentsClient
    {
        /// <summary>
        /// Remove users from a manually managed audience segment<br/>
        /// Remove users in bulk from the specified manual audience segment.<br/>
        /// ### Bulk Update Behavior:<br/>
        /// - Accepts a JSON array of `user_ids` in the request body.<br/>
        /// - Returns successes (users successfully removed) and failures (users who were not members of the segment).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task RemoveUsersFromSegmentAsync(
            int id,

            global::Forem.SegmentUserIds request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove users from a manually managed audience segment<br/>
        /// Remove users in bulk from the specified manual audience segment.<br/>
        /// ### Bulk Update Behavior:<br/>
        /// - Accepts a JSON array of `user_ids` in the request body.<br/>
        /// - Returns successes (users successfully removed) and failures (users who were not members of the segment).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> RemoveUsersFromSegmentAsResponseAsync(
            int id,

            global::Forem.SegmentUserIds request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove users from a manually managed audience segment<br/>
        /// Remove users in bulk from the specified manual audience segment.<br/>
        /// ### Bulk Update Behavior:<br/>
        /// - Accepts a JSON array of `user_ids` in the request body.<br/>
        /// - Returns successes (users successfully removed) and failures (users who were not members of the segment).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task RemoveUsersFromSegmentAsync(
            int id,
            global::System.Collections.Generic.IList<int>? userIds = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}