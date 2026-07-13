#nullable enable

namespace Forem
{
    public partial interface IHealthChecksClient
    {
        /// <summary>
        /// Check database connection<br/>
        /// Database connection health check.<br/>
        /// ### Usage Guidance:<br/>
        /// - Verifies that the application can successfully query the primary PostgreSQL database.<br/>
        /// - Used to monitor database pool status and connection health.
        /// </summary>
        /// <param name="healthCheckToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetHealthChecksDatabaseAsync(
            string? healthCheckToken = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check database connection<br/>
        /// Database connection health check.<br/>
        /// ### Usage Guidance:<br/>
        /// - Verifies that the application can successfully query the primary PostgreSQL database.<br/>
        /// - Used to monitor database pool status and connection health.
        /// </summary>
        /// <param name="healthCheckToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetHealthChecksDatabaseAsResponseAsync(
            string? healthCheckToken = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}