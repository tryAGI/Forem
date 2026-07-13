#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Add spam role for a User<br/>
        /// Flag a user as spammer.<br/>
        /// ### Spam Role Details:<br/>
        /// - Requires `admin` or `moderator` privileges.<br/>
        /// - Stops the user from creating new posts or comments, acting as a shadowban or block on activity.<br/>
        /// - Existing content remains but is hidden from search/feeds.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task SpamUserAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add spam role for a User<br/>
        /// Flag a user as spammer.<br/>
        /// ### Spam Role Details:<br/>
        /// - Requires `admin` or `moderator` privileges.<br/>
        /// - Stops the user from creating new posts or comments, acting as a shadowban or block on activity.<br/>
        /// - Existing content remains but is hidden from search/feeds.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> SpamUserAsResponseAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}