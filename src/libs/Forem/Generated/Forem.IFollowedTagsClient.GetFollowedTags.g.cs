#nullable enable

namespace Forem
{
    public partial interface IFollowedTagsClient
    {
        /// <summary>
        /// Followed Tags<br/>
        /// This endpoint allows the client to retrieve a list of the tags they follow.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.FollowedTag>> GetFollowedTagsAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}