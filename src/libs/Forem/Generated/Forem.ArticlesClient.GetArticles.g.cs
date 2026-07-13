
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>> GetArticlesAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetArticlesAsResponseAsync(
                page: page,
                perPage: perPage,
                tag: tag,
                tags: tags,
                tagsExclude: tagsExclude,
                username: username,
                state: state,
                top: top,
                collectionId: collectionId,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>>> GetArticlesAsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetArticlesArguments(
                httpClient: HttpClient,
                page: ref page,
                perPage: ref perPage,
                tag: ref tag,
                tags: ref tags,
                tagsExclude: ref tagsExclude,
                username: ref username,
                state: ref state,
                top: ref top,
                collectionId: ref collectionId);

            using var __timeoutCancellationTokenSource = global::Forem.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Forem.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Forem.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Forem.PathBuilder(
                                path: "/api/articles",
                                baseUri: HttpClient.BaseAddress);
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
                __path = global::Forem.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
                global::Forem.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetArticlesRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    page: page,
                    perPage: perPage,
                    tag: tag,
                    tags: tags,
                    tagsExclude: tagsExclude,
                    username: username,
                    state: state,
                    top: top,
                    collectionId: collectionId);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Forem.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Forem.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetArticles",
                                methodName: "GetArticlesAsync",
                                pathTemplate: "\"/api/articles\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Forem.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Forem.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Forem.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetArticles",
                                methodName: "GetArticlesAsync",
                                pathTemplate: "\"/api/articles\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Forem.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Forem.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Forem.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Forem.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Forem.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetArticles",
                                methodName: "GetArticlesAsync",
                                pathTemplate: "\"/api/articles\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Forem.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetArticlesResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Forem.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Forem.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetArticles",
                                methodName: "GetArticlesAsync",
                                pathTemplate: "\"/api/articles\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Forem.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Forem.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "GetArticles",
                                methodName: "GetArticlesAsync",
                                pathTemplate: "\"/api/articles\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetArticlesResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = (global::System.Collections.Generic.IList<global::Forem.ArticleIndex>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Forem.ArticleIndex>), JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Forem.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Forem.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = (global::System.Collections.Generic.IList<global::Forem.ArticleIndex>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Forem.ArticleIndex>), JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.ArticleIndex>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Forem.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Forem.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}