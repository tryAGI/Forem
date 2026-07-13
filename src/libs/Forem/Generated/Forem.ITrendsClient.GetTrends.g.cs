#nullable enable

namespace Forem
{
    public partial interface ITrendsClient
    {
        /// <summary>
        /// Trends<br/>
        /// Retrieve a list of active trends.<br/>
        /// ### Trends Overview &amp; Score Calculation:<br/>
        /// - Trends represent hot topics or semantic themes currently being heavily discussed in the community.<br/>
        /// - They are computed by clustering semantic concept embeddings of recently published articles.<br/>
        /// - The `score` reflects the volume and engagement (views, comments, reactions) of articles associated with the trend.<br/>
        /// - Returned trends are ordered by score and recency.<br/>
        /// - Publicly accessible without authentication.<br/>
        /// It supports pagination, each page will contain 10 trends by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Trend>> GetTrendsAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Trends<br/>
        /// Retrieve a list of active trends.<br/>
        /// ### Trends Overview &amp; Score Calculation:<br/>
        /// - Trends represent hot topics or semantic themes currently being heavily discussed in the community.<br/>
        /// - They are computed by clustering semantic concept embeddings of recently published articles.<br/>
        /// - The `score` reflects the volume and engagement (views, comments, reactions) of articles associated with the trend.<br/>
        /// - Returned trends are ordered by score and recency.<br/>
        /// - Publicly accessible without authentication.<br/>
        /// It supports pagination, each page will contain 10 trends by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Trend>>> GetTrendsAsResponseAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}