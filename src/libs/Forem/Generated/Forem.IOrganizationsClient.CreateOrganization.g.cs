#nullable enable

namespace Forem
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Create an Organization<br/>
        /// This endpoint allows the client to create an organization with the provided parameters.<br/>
        ///         It requires a token from a user with `admin` privileges.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateOrganizationAsync(

            global::Forem.Organization request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Organization<br/>
        /// This endpoint allows the client to create an organization with the provided parameters.<br/>
        ///         It requires a token from a user with `admin` privileges.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreateOrganizationAsResponseAsync(

            global::Forem.Organization request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an Organization<br/>
        /// This endpoint allows the client to create an organization with the provided parameters.<br/>
        ///         It requires a token from a user with `admin` privileges.
        /// </summary>
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
        global::System.Threading.Tasks.Task CreateOrganizationAsync(
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