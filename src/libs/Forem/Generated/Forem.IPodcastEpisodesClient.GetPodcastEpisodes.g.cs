#nullable enable

namespace Forem
{
    public partial interface IPodcastEpisodesClient
    {
        /// <summary>
        /// Podcast Episodes<br/>
        /// Retrieve a list of podcast episodes published on the platform.<br/>
        ///         ### Integration Guidance:<br/>
        ///         - Bypasses authentication (can be accessed publicly).<br/>
        ///         - Only returns active episodes belonging to published/reachable podcasts.<br/>
        ///         - Episodes are returned in reverse chronological order based on their publication date.<br/>
        ///         - The `username` query parameter is the unique slug of the podcast channel (e.g. `codenewbie`).<br/>
        ///         It supports pagination, each page will contain 30 episodes by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.PodcastEpisodeIndex>> GetPodcastEpisodesAsync(
            int? page = default,
            int? perPage = default,
            string? username = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Podcast Episodes<br/>
        /// Retrieve a list of podcast episodes published on the platform.<br/>
        ///         ### Integration Guidance:<br/>
        ///         - Bypasses authentication (can be accessed publicly).<br/>
        ///         - Only returns active episodes belonging to published/reachable podcasts.<br/>
        ///         - Episodes are returned in reverse chronological order based on their publication date.<br/>
        ///         - The `username` query parameter is the unique slug of the podcast channel (e.g. `codenewbie`).<br/>
        ///         It supports pagination, each page will contain 30 episodes by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="username"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.PodcastEpisodeIndex>>> GetPodcastEpisodesAsResponseAsync(
            int? page = default,
            int? perPage = default,
            string? username = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}