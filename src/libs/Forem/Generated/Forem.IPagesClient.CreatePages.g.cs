#nullable enable

namespace Forem
{
    public partial interface IPagesClient
    {
        /// <summary>
        /// pages<br/>
        /// Create a new custom page. Requires administrative privileges.<br/>
        ///         ### Body Parameter Guidelines:<br/>
        ///         - **title**: Heading displayed at the top of the page.<br/>
        ///         - **slug**: URL path identifier. Must be unique and URL-safe.<br/>
        ///         - **body_markdown**: Content written in Markdown format.<br/>
        ///         - **body_json**: Optional JSON payload for API-consumed/structured data pages.<br/>
        ///         - **is_top_level_path**: Set to `true` to serve the page directly at the root (e.g. `/{slug}`) instead of under the default namespace `/page/{slug}`. Use with caution to avoid namespace collisions with core Forem paths.<br/>
        ///         - **template**: Layout styling options (`contained` or custom layouts).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreatePagesAsync(

            global::Forem.CreatePagesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// pages<br/>
        /// Create a new custom page. Requires administrative privileges.<br/>
        ///         ### Body Parameter Guidelines:<br/>
        ///         - **title**: Heading displayed at the top of the page.<br/>
        ///         - **slug**: URL path identifier. Must be unique and URL-safe.<br/>
        ///         - **body_markdown**: Content written in Markdown format.<br/>
        ///         - **body_json**: Optional JSON payload for API-consumed/structured data pages.<br/>
        ///         - **is_top_level_path**: Set to `true` to serve the page directly at the root (e.g. `/{slug}`) instead of under the default namespace `/page/{slug}`. Use with caution to avoid namespace collisions with core Forem paths.<br/>
        ///         - **template**: Layout styling options (`contained` or custom layouts).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreatePagesAsResponseAsync(

            global::Forem.CreatePagesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// pages<br/>
        /// Create a new custom page. Requires administrative privileges.<br/>
        ///         ### Body Parameter Guidelines:<br/>
        ///         - **title**: Heading displayed at the top of the page.<br/>
        ///         - **slug**: URL path identifier. Must be unique and URL-safe.<br/>
        ///         - **body_markdown**: Content written in Markdown format.<br/>
        ///         - **body_json**: Optional JSON payload for API-consumed/structured data pages.<br/>
        ///         - **is_top_level_path**: Set to `true` to serve the page directly at the root (e.g. `/{slug}`) instead of under the default namespace `/page/{slug}`. Use with caution to avoid namespace collisions with core Forem paths.<br/>
        ///         - **template**: Layout styling options (`contained` or custom layouts).
        /// </summary>
        /// <param name="title">
        /// Title of the page
        /// </param>
        /// <param name="slug">
        /// Used to link to this page in URLs, must be unique and URL-safe
        /// </param>
        /// <param name="description">
        /// For internal use, helps similar pages from one another
        /// </param>
        /// <param name="bodyMarkdown">
        /// The text (in markdown) of the page (required)
        /// </param>
        /// <param name="bodyJson">
        /// For JSON pages, the JSON body
        /// </param>
        /// <param name="isTopLevelPath">
        /// If true, the page is available at '/{slug}' instead of '/page/{slug}', use with caution
        /// </param>
        /// <param name="template">
        /// Controls what kind of layout the page is rendered in<br/>
        /// Default Value: contained
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreatePagesAsync(
            string? title = default,
            string? slug = default,
            string? description = default,
            string? bodyMarkdown = default,
            string? bodyJson = default,
            bool? isTopLevelPath = default,
            global::Forem.CreatePagesRequestTemplate? template = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}