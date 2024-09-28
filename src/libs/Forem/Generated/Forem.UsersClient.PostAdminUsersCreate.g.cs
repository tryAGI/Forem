
#nullable enable

namespace Forem
{
    public partial class UsersClient
    {
        partial void PreparePostAdminUsersCreateArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Forem.UserInviteParam request);
        partial void PreparePostAdminUsersCreateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Forem.UserInviteParam request);
        partial void ProcessPostAdminUsersCreateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Invite a User<br/>
        /// This endpoint allows the client to trigger an invitation to the provided email address.<br/>
        ///         It requires a token from a user with `super_admin` privileges.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PostAdminUsersCreateAsync(
            global::Forem.UserInviteParam request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePostAdminUsersCreateArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/admin/users",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePostAdminUsersCreateRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPostAdminUsersCreateResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Invite a User<br/>
        /// This endpoint allows the client to trigger an invitation to the provided email address.<br/>
        ///         It requires a token from a user with `super_admin` privileges.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task PostAdminUsersCreateAsync(
            string? email = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::Forem.UserInviteParam
            {
                Email = email,
                Name = name,
            };

            await PostAdminUsersCreateAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}