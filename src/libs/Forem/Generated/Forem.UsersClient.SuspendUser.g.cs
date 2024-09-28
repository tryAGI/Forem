
#nullable enable

namespace Forem
{
    public partial class UsersClient
    {
        partial void PrepareSuspendUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id);
        partial void PrepareSuspendUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id);
        partial void ProcessSuspendUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Suspend a User<br/>
        /// This endpoint allows the client to suspend a user.<br/>
        /// The user associated with the API key must have any 'admin' or 'moderator' role.<br/>
        /// This specified user will be assigned the 'suspended' role. Suspending a user will stop the<br/>
        /// user from posting new posts and comments. It doesn't delete any of the user's content, just<br/>
        /// prevents them from creating new content while suspended. Users are not notified of their suspension<br/>
        /// in the UI, so if you want them to know about this, you must notify them.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task SuspendUserAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSuspendUserArguments(
                httpClient: _httpClient,
                id: ref id);

            var __pathBuilder = new PathBuilder(
                path: $"/users/{id}/suspend",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSuspendUserRequest(
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
            ProcessSuspendUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }
    }
}