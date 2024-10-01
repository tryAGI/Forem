
#nullable enable

namespace Forem
{
    public partial class ArticlesClient
    {
        partial void PrepareUnpublishArticleArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id,
            ref string? note);
        partial void PrepareUnpublishArticleRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id,
            string? note);
        partial void ProcessUnpublishArticleResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Unpublish an article<br/>
        /// This endpoint allows the client to unpublish an article.<br/>
        /// The user associated with the API key must have any 'admin' or 'moderator' role.<br/>
        /// The article will be unpublished and will no longer be visible to the public. It will remain<br/>
        /// in the database and will set back to draft status on the author's posts dashboard. Any<br/>
        /// notifications associated with the article will be deleted. Any comments on the article<br/>
        /// will remain.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="note"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UnpublishArticleAsync(
            int id,
            string? note = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareUnpublishArticleArguments(
                httpClient: _httpClient,
                id: ref id,
                note: ref note);

            var __pathBuilder = new PathBuilder(
                path: $"/articles/{id}/unpublish",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("note", note) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            PrepareUnpublishArticleRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                note: note);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUnpublishArticleResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}