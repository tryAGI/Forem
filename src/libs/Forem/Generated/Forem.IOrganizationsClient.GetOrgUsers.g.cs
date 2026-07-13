#nullable enable

namespace Forem
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// Organization's users<br/>
        /// Retrieve a list of public user profiles associated with the organization.<br/>
        /// ### Path Parameter Options:<br/>
        /// - **organization_id_or_username**: Supports either the organization's unique numerical ID OR its string username (slug).<br/>
        /// - Ideal for displaying team member directory lists on organization/brand pages.
        /// </summary>
        /// <param name="organizationIdOrUsername"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.User>> GetOrgUsersAsync(
            string organizationIdOrUsername,
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Organization's users<br/>
        /// Retrieve a list of public user profiles associated with the organization.<br/>
        /// ### Path Parameter Options:<br/>
        /// - **organization_id_or_username**: Supports either the organization's unique numerical ID OR its string username (slug).<br/>
        /// - Ideal for displaying team member directory lists on organization/brand pages.
        /// </summary>
        /// <param name="organizationIdOrUsername"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.User>>> GetOrgUsersAsResponseAsync(
            string organizationIdOrUsername,
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}