
#nullable enable

namespace Forem
{
    public partial class ReactionsClient
    {
        partial void PrepareCreateReactionsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Forem.Category2 category,
            ref int reactableId,
            ref global::Forem.ReactableType2 reactableType);
        partial void PrepareCreateReactionsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Forem.Category2 category,
            int reactableId,
            global::Forem.ReactableType2 reactableType);
        partial void ProcessCreateReactionsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// create reaction<br/>
        /// This endpoint allows the client to create a reaction to a specified reactable (eg, Article, Comment, or User). For examples:<br/>
        ///         * "Like"ing an Article will create a new "like" Reaction from the user for that Articles<br/>
        ///         * "Like"ing that Article a second time will return the previous "like"
        /// </summary>
        /// <param name="category"></param>
        /// <param name="reactableId"></param>
        /// <param name="reactableType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateReactionsAsync(
            global::Forem.Category2 category,
            int reactableId,
            global::Forem.ReactableType2 reactableType,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCreateReactionsArguments(
                httpClient: _httpClient,
                category: ref category,
                reactableId: ref reactableId,
                reactableType: ref reactableType);

            var __pathBuilder = new PathBuilder(
                path: "/reactions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("category", category.ToValueString()) 
                .AddRequiredParameter("reactable_id", reactableId.ToString()) 
                .AddRequiredParameter("reactable_type", reactableType.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCreateReactionsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                category: category,
                reactableId: reactableId,
                reactableType: reactableType);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateReactionsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}