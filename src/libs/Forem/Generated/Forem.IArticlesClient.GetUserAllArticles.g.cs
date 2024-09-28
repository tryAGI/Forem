#nullable enable

namespace Forem
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// User's all articles<br/>
        /// This endpoint allows the client to retrieve a list of all articles on behalf of an authenticated user.<br/>
        /// "Articles" are all the posts that users create on DEV that typically show up in the feed. They can be a blog post, a discussion question, a help thread etc. but is referred to as article within the code.<br/>
        /// It will return both published and unpublished articles with pagination.<br/>
        /// Unpublished articles will be at the top of the list in reverse chronological creation order. Published articles will follow in reverse chronological publication order.<br/>
        /// By default a page will contain 30 articles.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>> GetUserAllArticlesAsync(
            int? page = 1,
            int? perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}