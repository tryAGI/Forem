#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Suspend a User<br/>
        /// Suspend a user's account.<br/>
        /// ### Suspension Details:<br/>
        /// - The user associated with the API key must have an `admin` or `moderator` role.<br/>
        /// - Assigns the `suspended` role to the user, preventing them from posting new content (articles or comments) while suspended.<br/>
        /// - Existing content is not deleted.<br/>
        /// - Suspended users are not notified in the UI; if you want them to know, you must notify them explicitly.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task SuspendUserAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Suspend a User<br/>
        /// Suspend a user's account.<br/>
        /// ### Suspension Details:<br/>
        /// - The user associated with the API key must have an `admin` or `moderator` role.<br/>
        /// - Assigns the `suspended` role to the user, preventing them from posting new content (articles or comments) while suspended.<br/>
        /// - Existing content is not deleted.<br/>
        /// - Suspended users are not notified in the UI; if you want them to know, you must notify them explicitly.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> SuspendUserAsResponseAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}