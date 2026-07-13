#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Add trusted role for a User<br/>
        /// Assign the trusted role to a user.<br/>
        /// ### Trusted Role Details:<br/>
        /// - Requires `admin` or `moderator` privileges.<br/>
        /// - Trusted users gain privileges like casting flag votes on inappropriate content or participating in priority review queues.<br/>
        /// - Triggers a system notification and an email to the user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task TrustUserAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add trusted role for a User<br/>
        /// Assign the trusted role to a user.<br/>
        /// ### Trusted Role Details:<br/>
        /// - Requires `admin` or `moderator` privileges.<br/>
        /// - Trusted users gain privileges like casting flag votes on inappropriate content or participating in priority review queues.<br/>
        /// - Triggers a system notification and an email to the user.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> TrustUserAsResponseAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}