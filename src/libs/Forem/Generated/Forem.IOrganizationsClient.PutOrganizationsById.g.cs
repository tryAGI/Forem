#nullable enable

namespace Forem
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Update an organization by id<br/>
        /// This endpoint allows the client to update an existing organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task PutOrganizationsByIdAsync(
            int id,

            global::Forem.Organization request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an organization by id<br/>
        /// This endpoint allows the client to update an existing organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> PutOrganizationsByIdAsResponseAsync(
            int id,

            global::Forem.Organization request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an organization by id<br/>
        /// This endpoint allows the client to update an existing organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="typeOf"></param>
        /// <param name="username"></param>
        /// <param name="name"></param>
        /// <param name="summary"></param>
        /// <param name="twitterUsername"></param>
        /// <param name="githubUsername"></param>
        /// <param name="url"></param>
        /// <param name="location"></param>
        /// <param name="joinedAt"></param>
        /// <param name="techStack"></param>
        /// <param name="tagLine"></param>
        /// <param name="story"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutOrganizationsByIdAsync(
            int id,
            string? typeOf = default,
            string? username = default,
            string? name = default,
            string? summary = default,
            string? twitterUsername = default,
            string? githubUsername = default,
            string? url = default,
            string? location = default,
            string? joinedAt = default,
            string? techStack = default,
            string? tagLine = default,
            string? story = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}