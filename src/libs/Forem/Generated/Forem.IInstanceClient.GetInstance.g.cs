#nullable enable

namespace Forem
{
    public partial interface IInstanceClient
    {
        /// <summary>
        /// Retrieve instance configuration details<br/>
        /// Retrieve configuration details for the current Forem instance.<br/>
        /// ### Instance Metadata:<br/>
        /// - Bypasses authentication.<br/>
        /// - Returns public Forem version, branding parameters, community guidelines references, and supported features configurations.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetInstanceAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve instance configuration details<br/>
        /// Retrieve configuration details for the current Forem instance.<br/>
        /// ### Instance Metadata:<br/>
        /// - Bypasses authentication.<br/>
        /// - Returns public Forem version, branding parameters, community guidelines references, and supported features configurations.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetInstanceAsResponseAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}