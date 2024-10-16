
#nullable enable

namespace Forem
{
    public partial class DisplayAdsClient
    {
        partial void PreparePutDisplayAdsByIdUnpublishArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id);
        partial void PreparePutDisplayAdsByIdUnpublishRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id);
        partial void ProcessPutDisplayAdsByIdUnpublishResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// unpublish<br/>
        /// This endpoint allows the client to remove a display ad from rotation by un-publishing it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PutDisplayAdsByIdUnpublishAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PreparePutDisplayAdsByIdUnpublishArguments(
                httpClient: _httpClient,
                id: ref id);

            var __pathBuilder = new PathBuilder(
                path: $"/display_ads/{id}/unpublish",
                baseUri: _httpClient.BaseAddress); 
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
            PreparePutDisplayAdsByIdUnpublishRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPutDisplayAdsByIdUnpublishResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}