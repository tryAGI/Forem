#nullable enable

namespace Forem
{
    public partial interface IBillboardsClient
    {
        /// <summary>
        /// Unpublish a billboard<br/>
        /// Remove a billboard from active rotation by unpublishing it.<br/>
        ///         ### Usage:<br/>
        ///         - Instantly disables display across all pages while keeping the configuration stored in the database for later reactivations or historical reporting.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task PutBillboardsByIdUnpublishAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Unpublish a billboard<br/>
        /// Remove a billboard from active rotation by unpublishing it.<br/>
        ///         ### Usage:<br/>
        ///         - Instantly disables display across all pages while keeping the configuration stored in the database for later reactivations or historical reporting.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> PutBillboardsByIdUnpublishAsResponseAsync(
            int id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}