
#nullable enable

namespace Forem
{
    public partial class OrganizationsClient
    {
        partial void PrepareGetOrgUsersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string username,
            ref int? page,
            ref int? perPage);
        partial void PrepareGetOrgUsersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string username,
            int? page,
            int? perPage);
        partial void ProcessGetOrgUsersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetOrgUsersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Organization's users<br/>
        /// This endpoint allows the client to retrieve a list of users belonging to the organization<br/>
        /// It supports pagination, each page will contain `30` users by default.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.User>> GetOrgUsersAsync(
            string username,
            int? page = 1,
            int? perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetOrgUsersArguments(
                httpClient: _httpClient,
                username: ref username,
                page: ref page,
                perPage: ref perPage);

            var __pathBuilder = new PathBuilder(
                path: $"/organizations/{username}/users",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page", page?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
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
            PrepareGetOrgUsersRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                username: username,
                page: page,
                perPage: perPage);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetOrgUsersResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetOrgUsersResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Forem.User>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::Forem.User> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}