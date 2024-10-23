
#nullable enable

namespace Forem
{
    public partial class UsersClient
    {
        partial void PrepareUnpublishUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id);
        partial void PrepareUnpublishUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id);
        partial void ProcessUnpublishUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Unpublish a User's Articles and Comments<br/>
        /// This endpoint allows the client to unpublish all of the articles and<br/>
        /// comments created by a user.<br/>
        /// The user associated with the API key must have any 'admin' or 'moderator' role.<br/>
        /// This specified user's articles and comments will be unpublished and will no longer be<br/>
        /// visible to the public. They will remain in the database and will set back to draft status<br/>
        /// on the specified user's  dashboard. Any notifications associated with the specified user's<br/>
        /// articles and comments will be deleted.<br/>
        /// Note this endpoint unpublishes articles and comments asychronously: it will return a 204 NO CONTENT<br/>
        /// status code immediately, but the articles and comments will not be unpublished until the<br/>
        /// request is completed on the server.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task UnpublishUserAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareUnpublishUserArguments(
                httpClient: HttpClient,
                id: ref id);

            var __pathBuilder = new PathBuilder(
                path: $"/users/{id}/unpublish",
                baseUri: HttpClient.BaseAddress); 
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
            PrepareUnpublishUserRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUnpublishUserResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            __response.EnsureSuccessStatusCode();
        }
    }
}