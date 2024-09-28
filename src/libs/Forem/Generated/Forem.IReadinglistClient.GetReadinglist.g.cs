#nullable enable

namespace Forem
{
    public partial interface IReadinglistClient
    {
        /// <summary>
        /// Readinglist<br/>
        /// This endpoint allows the client to retrieve a list of articles that were saved to a Users readinglist.<br/>
        ///         It supports pagination, each page will contain `30` articles by default
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>> GetReadinglistAsync(
            int? page = 1,
            int? perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}