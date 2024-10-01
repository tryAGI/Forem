
#nullable enable

namespace Forem
{
    public partial class ReactionsClient
    {
        partial void PrepareCreateReactionsToggleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::Forem.Category category,
            ref int reactableId,
            ref global::Forem.ReactableType reactableType);
        partial void PrepareCreateReactionsToggleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Forem.Category category,
            int reactableId,
            global::Forem.ReactableType reactableType);
        partial void ProcessCreateReactionsToggleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// toggle reaction<br/>
        /// This endpoint allows the client to toggle the user's reaction to a specified reactable (eg, Article, Comment, or User). For examples:<br/>
        ///         * "Like"ing an Article will create a new "like" Reaction from the user for that Articles<br/>
        ///         * "Like"ing that Article a second time will remove the "like" from the user
        /// </summary>
        /// <param name="category"></param>
        /// <param name="reactableId"></param>
        /// <param name="reactableType"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task CreateReactionsToggleAsync(
            global::Forem.Category category,
            int reactableId,
            global::Forem.ReactableType reactableType,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCreateReactionsToggleArguments(
                httpClient: _httpClient,
                category: ref category,
                reactableId: ref reactableId,
                reactableType: ref reactableType);

            var __pathBuilder = new PathBuilder(
                path: "/reactions/toggle",
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

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateReactionsToggleRequest(
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
            ProcessCreateReactionsToggleResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}