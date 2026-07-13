#nullable enable

namespace Forem
{
    public partial interface IBadgesClient
    {
        /// <summary>
        /// Create a badge<br/>
        /// Create a new badge. Requires administrator privileges.<br/>
        /// ### Body Parameter Guidelines:<br/>
        /// - **title**: Unique name for the badge.<br/>
        /// - **description**: Text explanation of the achievement.<br/>
        /// - **remote_badge_image_url**: Public URL to an image asset (PNG, GIF, or SVG) representing the badge icon.<br/>
        /// - **allow_multiple_awards**: Set to `true` if a user can earn the same badge multiple times (e.g. weekly challenges).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Badge> CreateBadgesAsync(

            global::Forem.CreateBadgesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a badge<br/>
        /// Create a new badge. Requires administrator privileges.<br/>
        /// ### Body Parameter Guidelines:<br/>
        /// - **title**: Unique name for the badge.<br/>
        /// - **description**: Text explanation of the achievement.<br/>
        /// - **remote_badge_image_url**: Public URL to an image asset (PNG, GIF, or SVG) representing the badge icon.<br/>
        /// - **allow_multiple_awards**: Set to `true` if a user can earn the same badge multiple times (e.g. weekly challenges).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.Badge>> CreateBadgesAsResponseAsync(

            global::Forem.CreateBadgesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a badge<br/>
        /// Create a new badge. Requires administrator privileges.<br/>
        /// ### Body Parameter Guidelines:<br/>
        /// - **title**: Unique name for the badge.<br/>
        /// - **description**: Text explanation of the achievement.<br/>
        /// - **remote_badge_image_url**: Public URL to an image asset (PNG, GIF, or SVG) representing the badge icon.<br/>
        /// - **allow_multiple_awards**: Set to `true` if a user can earn the same badge multiple times (e.g. weekly challenges).
        /// </summary>
        /// <param name="badge"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Badge> CreateBadgesAsync(
            global::Forem.CreateBadgesRequestBadge? badge = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}