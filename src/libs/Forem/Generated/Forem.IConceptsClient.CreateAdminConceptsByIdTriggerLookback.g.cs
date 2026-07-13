#nullable enable

namespace Forem
{
    public partial interface IConceptsClient
    {
        /// <summary>
        /// Trigger concept lookback backfill (Admin)<br/>
        /// Trigger a background backfill worker to scan historical articles published in the last `N` days and evaluate them against this concept.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminConceptsByIdTriggerLookbackAsync(
            int id,

            global::Forem.CreateAdminConceptsTriggerLookbackRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger concept lookback backfill (Admin)<br/>
        /// Trigger a background backfill worker to scan historical articles published in the last `N` days and evaluate them against this concept.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreateAdminConceptsByIdTriggerLookbackAsResponseAsync(
            int id,

            global::Forem.CreateAdminConceptsTriggerLookbackRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trigger concept lookback backfill (Admin)<br/>
        /// Trigger a background backfill worker to scan historical articles published in the last `N` days and evaluate them against this concept.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="days"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminConceptsByIdTriggerLookbackAsync(
            int id,
            int days,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}