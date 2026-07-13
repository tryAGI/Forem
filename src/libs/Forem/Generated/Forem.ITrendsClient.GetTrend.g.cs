#nullable enable

namespace Forem
{
    public partial interface ITrendsClient
    {
        /// <summary>
        /// A Trend<br/>
        /// Retrieve details of a single trend using either its numeric ID or unique slug.<br/>
        /// ### Usage Guidance:<br/>
        /// - Useful for loading details of a trending topic (description, score, and slug details) to render header sections on trending tag or topic pages.
        /// </summary>
        /// <param name="idOrSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetTrendAsync(
            string idOrSlug,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// A Trend<br/>
        /// Retrieve details of a single trend using either its numeric ID or unique slug.<br/>
        /// ### Usage Guidance:<br/>
        /// - Useful for loading details of a trending topic (description, score, and slug details) to render header sections on trending tag or topic pages.
        /// </summary>
        /// <param name="idOrSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<string>> GetTrendAsResponseAsync(
            string idOrSlug,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}