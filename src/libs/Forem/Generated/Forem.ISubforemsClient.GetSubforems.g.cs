#nullable enable

namespace Forem
{
    public partial interface ISubforemsClient
    {
        /// <summary>
        /// Retrieve all discoverable subforems<br/>
        /// Retrieve a list of all discoverable subforems/communities.<br/>
        /// ### Subforems Overview:<br/>
        /// - Subforems represent distinct sub-communities or specialized sections hosted within the Forem instance.<br/>
        /// - Bypasses authentication (can be accessed publicly).<br/>
        /// - Returns list of names, slugs, color schemes, and target interests.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Subforem>> GetSubforemsAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve all discoverable subforems<br/>
        /// Retrieve a list of all discoverable subforems/communities.<br/>
        /// ### Subforems Overview:<br/>
        /// - Subforems represent distinct sub-communities or specialized sections hosted within the Forem instance.<br/>
        /// - Bypasses authentication (can be accessed publicly).<br/>
        /// - Returns list of names, slugs, color schemes, and target interests.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Subforem>>> GetSubforemsAsResponseAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}