#nullable enable

namespace Forem
{
    public partial interface IPagesClient
    {
        /// <summary>
        /// show details for all pages<br/>
        /// Retrieve details for all Page objects in the system.<br/>
        ///         ### Pages Overview:<br/>
        ///         - Pages are custom static or dynamic views hosted on the Forem instance.<br/>
        ///         - Publicly visible unless restricted.<br/>
        ///         - Helpful for building custom menus, rendering site policies, or embedding custom forms.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Page>> GetPagesAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// show details for all pages<br/>
        /// Retrieve details for all Page objects in the system.<br/>
        ///         ### Pages Overview:<br/>
        ///         - Pages are custom static or dynamic views hosted on the Forem instance.<br/>
        ///         - Publicly visible unless restricted.<br/>
        ///         - Helpful for building custom menus, rendering site policies, or embedding custom forms.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Page>>> GetPagesAsResponseAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}