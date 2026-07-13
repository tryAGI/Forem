#nullable enable

namespace Forem
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Published articles<br/>
        /// This endpoint allows the client to retrieve a list of articles.<br/>
        /// "Articles" are all the posts that users create on DEV/Forem that typically show up in the feed. They can be a blog post, a discussion question, a help thread etc. but are referred to as articles within the code.<br/>
        /// By default it will return featured, published articles ordered by descending popularity.<br/>
        /// It supports pagination, each page will contain `30` articles by default.<br/>
        /// ### Query Parameter Usage Tips:<br/>
        /// - **Filtering by Tags**:<br/>
        ///   - Use `tag` to filter articles containing a single exact tag (e.g. `tag=discuss`).<br/>
        ///   - Use `tags` to retrieve articles containing *any* of the comma-separated list of tags (e.g. `tags=javascript,css`).<br/>
        ///   - Use `tags_exclude` to filter out articles containing any of the comma-separated list of tags (e.g. `tags_exclude=node,java`).<br/>
        /// - **Filtering by User / Organization**:<br/>
        ///   - Use `username` to retrieve articles belonging to a specific User or Organization. Articles are returned in reverse chronological publication order.<br/>
        /// - **State Options**:<br/>
        ///   - Use `state=fresh` to fetch fresh articles.<br/>
        ///   - Use `state=rising` to fetch rising/trending articles.<br/>
        ///   - Combine `state=all` with `username` to fetch up to `1000` articles (both published and unpublished) from that user/organization in a single page.<br/>
        /// - **Top / Popularity**:<br/>
        ///   - Use `top=N` to return the most popular articles published in the last `N` days (e.g. `top=7` for top articles of the week, `top=30` for top of the month). This parameter can be combined with `tag` to find top articles in a specific niche.<br/>
        /// - **Collections**:<br/>
        ///   - Use `collection_id` to retrieve articles belonging to a specific collection/series, sorted chronologically.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="tag"></param>
        /// <param name="tags"></param>
        /// <param name="tagsExclude"></param>
        /// <param name="username"></param>
        /// <param name="state"></param>
        /// <param name="top"></param>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>> GetArticlesAsync(
            int? page = default,
            int? perPage = default,
            string? tag = default,
            string? tags = default,
            string? tagsExclude = default,
            string? username = default,
            global::Forem.GetArticlesState? state = default,
            int? top = default,
            int? collectionId = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Published articles<br/>
        /// This endpoint allows the client to retrieve a list of articles.<br/>
        /// "Articles" are all the posts that users create on DEV/Forem that typically show up in the feed. They can be a blog post, a discussion question, a help thread etc. but are referred to as articles within the code.<br/>
        /// By default it will return featured, published articles ordered by descending popularity.<br/>
        /// It supports pagination, each page will contain `30` articles by default.<br/>
        /// ### Query Parameter Usage Tips:<br/>
        /// - **Filtering by Tags**:<br/>
        ///   - Use `tag` to filter articles containing a single exact tag (e.g. `tag=discuss`).<br/>
        ///   - Use `tags` to retrieve articles containing *any* of the comma-separated list of tags (e.g. `tags=javascript,css`).<br/>
        ///   - Use `tags_exclude` to filter out articles containing any of the comma-separated list of tags (e.g. `tags_exclude=node,java`).<br/>
        /// - **Filtering by User / Organization**:<br/>
        ///   - Use `username` to retrieve articles belonging to a specific User or Organization. Articles are returned in reverse chronological publication order.<br/>
        /// - **State Options**:<br/>
        ///   - Use `state=fresh` to fetch fresh articles.<br/>
        ///   - Use `state=rising` to fetch rising/trending articles.<br/>
        ///   - Combine `state=all` with `username` to fetch up to `1000` articles (both published and unpublished) from that user/organization in a single page.<br/>
        /// - **Top / Popularity**:<br/>
        ///   - Use `top=N` to return the most popular articles published in the last `N` days (e.g. `top=7` for top articles of the week, `top=30` for top of the month). This parameter can be combined with `tag` to find top articles in a specific niche.<br/>
        /// - **Collections**:<br/>
        ///   - Use `collection_id` to retrieve articles belonging to a specific collection/series, sorted chronologically.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="tag"></param>
        /// <param name="tags"></param>
        /// <param name="tagsExclude"></param>
        /// <param name="username"></param>
        /// <param name="state"></param>
        /// <param name="top"></param>
        /// <param name="collectionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>>> GetArticlesAsResponseAsync(
            int? page = default,
            int? perPage = default,
            string? tag = default,
            string? tags = default,
            string? tagsExclude = default,
            string? username = default,
            global::Forem.GetArticlesState? state = default,
            int? top = default,
            int? collectionId = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}