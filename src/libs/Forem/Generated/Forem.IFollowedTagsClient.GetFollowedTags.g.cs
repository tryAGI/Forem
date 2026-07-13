#nullable enable

namespace Forem
{
    public partial interface IFollowedTagsClient
    {
        /// <summary>
        /// Followed Tags<br/>
        /// Retrieve the list of tags followed by the authenticated user.<br/>
        ///         ### Integration &amp; Personalization Guidance:<br/>
        ///         - Requires authentication.<br/>
        ///         - Returns tags in ascending/popularity order based on user interactions.<br/>
        ///         - Useful for customizing the home feed interface, constructing personalized sidebar navigation, or displaying a user's customized topic preferences in a dashboard.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.FollowedTag>> GetFollowedTagsAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Followed Tags<br/>
        /// Retrieve the list of tags followed by the authenticated user.<br/>
        ///         ### Integration &amp; Personalization Guidance:<br/>
        ///         - Requires authentication.<br/>
        ///         - Returns tags in ascending/popularity order based on user interactions.<br/>
        ///         - Useful for customizing the home feed interface, constructing personalized sidebar navigation, or displaying a user's customized topic preferences in a dashboard.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.FollowedTag>>> GetFollowedTagsAsResponseAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}