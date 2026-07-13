#nullable enable

namespace Forem
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Articles with a video<br/>
        /// Retrieve a list of articles that contain uploaded videos.<br/>
        /// ### Videos Overview:<br/>
        /// - Bypasses authentication (can be accessed publicly).<br/>
        /// - Returns articles that are published and include a video asset.<br/>
        /// - Articles are ordered by descending popularity (views, watch time, and reactions).<br/>
        /// - By default, returns 24 video articles per page.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 24
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.VideoArticle>> VideosAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Articles with a video<br/>
        /// Retrieve a list of articles that contain uploaded videos.<br/>
        /// ### Videos Overview:<br/>
        /// - Bypasses authentication (can be accessed publicly).<br/>
        /// - Returns articles that are published and include a video asset.<br/>
        /// - Articles are ordered by descending popularity (views, watch time, and reactions).<br/>
        /// - By default, returns 24 video articles per page.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 24
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.VideoArticle>>> VideosAsResponseAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}