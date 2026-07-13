#nullable enable

namespace Forem
{
    public partial interface IArticlesClient
    {
        /// <summary>
        /// Publish article<br/>
        /// This endpoint allows the client to create a new article.<br/>
        /// "Articles" are all the posts that users create on DEV/Forem that typically show up in the feed. They can be a blog post, a discussion question, a help thread etc. but are referred to as articles within the code.<br/>
        /// ### Body Parameter Tips:<br/>
        /// - **title**: A compelling and descriptive title for the article.<br/>
        /// - **body_markdown**: The main text of the article in Markdown format. You can use standard Markdown as well as Forem-specific Liquid tags (e.g., `{% embed ... %}`). You can also include YAML front matter at the very beginning of the markdown to specify metadata such as tags, series, and cover image.<br/>
        /// - **published**: Set to `true` to immediately publish the article and make it visible in feeds. Set to `false` (default) to save it as a draft.<br/>
        /// - **tags**: A comma-separated list of tags (up to 4 tags). Tags help categorize your post and improve discoverability.<br/>
        /// - **series**: Group articles together by specifying a series name. If the series does not exist, it will be created.<br/>
        /// - **main_image**: Absolute URL of the cover image for the article.<br/>
        /// - **canonical_url**: If this post was originally published elsewhere, specify the canonical URL to maintain SEO integrity.<br/>
        /// - **description**: A short summary of the article used for previews and SEO meta description.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateArticleAsync(

            global::Forem.Article request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish article<br/>
        /// This endpoint allows the client to create a new article.<br/>
        /// "Articles" are all the posts that users create on DEV/Forem that typically show up in the feed. They can be a blog post, a discussion question, a help thread etc. but are referred to as articles within the code.<br/>
        /// ### Body Parameter Tips:<br/>
        /// - **title**: A compelling and descriptive title for the article.<br/>
        /// - **body_markdown**: The main text of the article in Markdown format. You can use standard Markdown as well as Forem-specific Liquid tags (e.g., `{% embed ... %}`). You can also include YAML front matter at the very beginning of the markdown to specify metadata such as tags, series, and cover image.<br/>
        /// - **published**: Set to `true` to immediately publish the article and make it visible in feeds. Set to `false` (default) to save it as a draft.<br/>
        /// - **tags**: A comma-separated list of tags (up to 4 tags). Tags help categorize your post and improve discoverability.<br/>
        /// - **series**: Group articles together by specifying a series name. If the series does not exist, it will be created.<br/>
        /// - **main_image**: Absolute URL of the cover image for the article.<br/>
        /// - **canonical_url**: If this post was originally published elsewhere, specify the canonical URL to maintain SEO integrity.<br/>
        /// - **description**: A short summary of the article used for previews and SEO meta description.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreateArticleAsResponseAsync(

            global::Forem.Article request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Publish article<br/>
        /// This endpoint allows the client to create a new article.<br/>
        /// "Articles" are all the posts that users create on DEV/Forem that typically show up in the feed. They can be a blog post, a discussion question, a help thread etc. but are referred to as articles within the code.<br/>
        /// ### Body Parameter Tips:<br/>
        /// - **title**: A compelling and descriptive title for the article.<br/>
        /// - **body_markdown**: The main text of the article in Markdown format. You can use standard Markdown as well as Forem-specific Liquid tags (e.g., `{% embed ... %}`). You can also include YAML front matter at the very beginning of the markdown to specify metadata such as tags, series, and cover image.<br/>
        /// - **published**: Set to `true` to immediately publish the article and make it visible in feeds. Set to `false` (default) to save it as a draft.<br/>
        /// - **tags**: A comma-separated list of tags (up to 4 tags). Tags help categorize your post and improve discoverability.<br/>
        /// - **series**: Group articles together by specifying a series name. If the series does not exist, it will be created.<br/>
        /// - **main_image**: Absolute URL of the cover image for the article.<br/>
        /// - **canonical_url**: If this post was originally published elsewhere, specify the canonical URL to maintain SEO integrity.<br/>
        /// - **description**: A short summary of the article used for previews and SEO meta description.
        /// </summary>
        /// <param name="article1"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateArticleAsync(
            global::Forem.ArticleArticle1? article1 = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}