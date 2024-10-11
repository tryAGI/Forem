#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// A User<br/>
        /// This endpoint allows the client to retrieve a single user, either by id<br/>
        /// or by the user's username.<br/>
        /// For complete documentation, see the v0 API docs: https://developers.forem.com/api/v0#tag/users/operation/getUser
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> GetUserAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}