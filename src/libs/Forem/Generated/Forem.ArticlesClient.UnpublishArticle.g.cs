
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
        /// <exception cref="global::Forem.ApiException"></exception>
        public async global::System.Threading.Tasks.Task UnpublishArticleAsync(
            int id,
            string? note = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUnpublishArticleArguments(
                httpClient: HttpClient,
                id: ref id,
                note: ref note);

            var __pathBuilder = new PathBuilder(
                path: $"/articles/{id}/unpublish",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("note", note) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUnpublishArticleRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                note: note);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUnpublishArticleResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::Forem.ApiException(
                    message: __response.ReasonPhrase ?? string.Empty,
                    innerException: __ex,
                    statusCode: __response.StatusCode)
                {
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
        }
    }
}