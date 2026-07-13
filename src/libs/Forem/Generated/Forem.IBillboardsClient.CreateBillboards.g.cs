#nullable enable

namespace Forem
{
    public partial interface IBillboardsClient
    {
        /// <summary>
        /// Create a billboard<br/>
        /// Create a new billboard.<br/>
        ///         ### Parameter Options &amp; Tips:<br/>
        ///         - **body_markdown**: The HTML/Markdown advertisement copy.<br/>
        ///         - **placement_area**: Target region in layouts (e.g. `post_comments` below comments, `sidebar` in sidebars, `home_feed` between posts).<br/>
        ///         - **display_to**: Cohort target rules (e.g. `all` for everyone, `logged_in`, `guests`, or customized segments).<br/>
        ///         - **target_geolocations**: Comma-separated ISO codes for country/region targeting.<br/>
        ///         - **approved** &amp; **published**: Set to `true` to activate billboard rotation instantly.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateBillboardsAsync(

            object request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a billboard<br/>
        /// Create a new billboard.<br/>
        ///         ### Parameter Options &amp; Tips:<br/>
        ///         - **body_markdown**: The HTML/Markdown advertisement copy.<br/>
        ///         - **placement_area**: Target region in layouts (e.g. `post_comments` below comments, `sidebar` in sidebars, `home_feed` between posts).<br/>
        ///         - **display_to**: Cohort target rules (e.g. `all` for everyone, `logged_in`, `guests`, or customized segments).<br/>
        ///         - **target_geolocations**: Comma-separated ISO codes for country/region targeting.<br/>
        ///         - **approved** &amp; **published**: Set to `true` to activate billboard rotation instantly.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<string>> CreateBillboardsAsResponseAsync(

            object request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a billboard<br/>
        /// Create a new billboard.<br/>
        ///         ### Parameter Options &amp; Tips:<br/>
        ///         - **body_markdown**: The HTML/Markdown advertisement copy.<br/>
        ///         - **placement_area**: Target region in layouts (e.g. `post_comments` below comments, `sidebar` in sidebars, `home_feed` between posts).<br/>
        ///         - **display_to**: Cohort target rules (e.g. `all` for everyone, `logged_in`, `guests`, or customized segments).<br/>
        ///         - **target_geolocations**: Comma-separated ISO codes for country/region targeting.<br/>
        ///         - **approved** &amp; **published**: Set to `true` to activate billboard rotation instantly.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateBillboardsAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}