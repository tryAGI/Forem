#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// The authenticated user<br/>
        /// This endpoint allows the client to retrieve information about the authenticated user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> GetUserMeAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}