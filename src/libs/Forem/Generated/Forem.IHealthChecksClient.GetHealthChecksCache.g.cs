#nullable enable

namespace Forem
{
    public partial interface IHealthChecksClient
    {
        /// <summary>
        /// Check cache connection<br/>
        /// Cache connection health check.<br/>
        /// ### Usage Guidance:<br/>
        /// - Verifies that the application can successfully ping the Redis cache instance.<br/>
        /// - Used to monitor cache and background worker queue connection health.
        /// </summary>
        /// <param name="healthCheckToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetHealthChecksCacheAsync(
            string? healthCheckToken = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check cache connection<br/>
        /// Cache connection health check.<br/>
        /// ### Usage Guidance:<br/>
        /// - Verifies that the application can successfully ping the Redis cache instance.<br/>
        /// - Used to monitor cache and background worker queue connection health.
        /// </summary>
        /// <param name="healthCheckToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetHealthChecksCacheAsResponseAsync(
            string? healthCheckToken = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}