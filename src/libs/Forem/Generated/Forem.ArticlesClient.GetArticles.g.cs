
#nullable enable

namespace Forem
{
    public partial class ArticlesClient
    {
        partial void PrepareGetArticlesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? page,
            ref int? perPage,
            ref string? tag,
            ref string? tags,
            ref string? tagsExclude,
            ref string? username,
            ref global::Forem.GetArticlesState? state,
            ref int? top,
            ref int? collectionId);
        partial void PrepareGetArticlesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? page,
            int? perPage,
            string? tag,
            string? tags,
            string? tagsExclude,
            string? username,
            global::Forem.GetArticlesState? state,
            int? top,
            int? collectionId);
        partial void ProcessGetArticlesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetArticlesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Published articles<br/>
        /// This endpoint allows the client to retrieve a list of articles.<br/>
        /// "Articles" are all the posts that users create on DEV that typically<br/>
        /// show up in the feed. They can be a blog post, a discussion question,<br/>
        /// a help thread etc. but is referred to as article within the code.<br/>
        /// By default it will return featured, published articles ordered<br/>
        /// by descending popularity.<br/>
        /// It supports pagination, each page will contain `30` articles by default.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>> GetArticlesAsync(
            int? page = 1,
            int? perPage = 30,
            string? tag = default,
            string? tags = default,
            string? tagsExclude = default,
            string? username = default,
            global::Forem.GetArticlesState? state = default,
            int? top = default,
            int? collectionId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetArticlesArguments(
                httpClient: _httpClient,
                page: ref page,
                perPage: ref perPage,
                tag: ref tag,
                tags: ref tags,
                tagsExclude: ref tagsExclude,
                username: ref username,
                state: ref state,
                top: ref top,
                collectionId: ref collectionId);

            var __pathBuilder = new PathBuilder(
                path: "/articles",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("tag", tag) 
                .AddOptionalParameter("tags", tags) 
                .AddOptionalParameter("tags_exclude", tagsExclude) 
                .AddOptionalParameter("username", username) 
                .AddOptionalParameter("state", state?.ToValueString()) 
                .AddOptionalParameter("top", top?.ToString()) 
                .AddOptionalParameter("collection_id", collectionId?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            if (_authorization != null)
            {{
                httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                    scheme: _authorization.Name,
                    parameter: _authorization.Value);
            }}

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetArticlesRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                page: page,
                perPage: perPage,
                tag: tag,
                tags: tags,
                tagsExclude: tagsExclude,
                username: username,
                state: state,
                top: top,
                collectionId: collectionId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetArticlesResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetArticlesResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Forem.ArticleIndex>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::Forem.ArticleIndex> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}