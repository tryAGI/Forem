#nullable enable

namespace Forem
{
    public partial interface IProfileImagesClient
    {
        /// <summary>
        /// A Users or organizations profile image<br/>
        /// This endpoint allows the client to retrieve a user or organization profile image information by its<br/>
        ///         corresponding username.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetProfileImageAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}