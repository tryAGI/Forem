#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// A User<br/>
        /// This endpoint allows the client to retrieve a single user, either by id or by the user's username.<br/>
        /// ### Path Parameter Options:<br/>
        /// - **id**: Can be either the user's unique numerical ID (e.g. `123`) OR the user's string username (e.g. `ben`).<br/>
        /// - Note that the returned user object schema (`ExtendedUser`) includes extended profile statistics and social link details.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetUserAsync(
            string id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// A User<br/>
        /// This endpoint allows the client to retrieve a single user, either by id or by the user's username.<br/>
        /// ### Path Parameter Options:<br/>
        /// - **id**: Can be either the user's unique numerical ID (e.g. `123`) OR the user's string username (e.g. `ben`).<br/>
        /// - Note that the returned user object schema (`ExtendedUser`) includes extended profile statistics and social link details.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<string>> GetUserAsResponseAsync(
            string id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}