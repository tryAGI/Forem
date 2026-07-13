#nullable enable

namespace Forem
{
    public partial interface IHealthChecksClient
    {
        /// <summary>
        /// Check app health<br/>
        /// Basic application liveness check.<br/>
        /// ### Usage Guidance:<br/>
        /// - Verifies that the Rails application process is running and responding to requests.<br/>
        /// - Does not check database or cache connectivity.<br/>
        /// - Typically used by load balancers, container orchestrators (like Kubernetes), or uptime checkers to verify container health.
        /// </summary>
        /// <param name="healthCheckToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetHealthChecksAppAsync(
            string? healthCheckToken = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Check app health<br/>
        /// Basic application liveness check.<br/>
        /// ### Usage Guidance:<br/>
        /// - Verifies that the Rails application process is running and responding to requests.<br/>
        /// - Does not check database or cache connectivity.<br/>
        /// - Typically used by load balancers, container orchestrators (like Kubernetes), or uptime checkers to verify container health.
        /// </summary>
        /// <param name="healthCheckToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> GetHealthChecksAppAsResponseAsync(
            string? healthCheckToken = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}