#nullable enable

namespace Forem
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Articles with a video<br/>
        /// This endpoint allows the client to retrieve a list of articles that are uploaded with a video.<br/>
        /// It will only return published video articles ordered by descending popularity.<br/>
        /// It supports pagination, each page will contain 24 articles by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 24
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.VideoArticle>> VideosAsync(
            int? page = default,
            int? perPage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}