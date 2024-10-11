#nullable enable

namespace Forem
{
    public partial interface IOrganizationsClient
    {
        /// <summary>
        /// An organization<br/>
        /// This endpoint allows the client to retrieve a single organization by their username
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> GetOrganizationAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}