#nullable enable

namespace Forem
{
    public partial interface ISurveysClient
    {
        /// <summary>
        /// Survey poll text responses<br/>
        /// Retrieve free-text poll responses for a specific survey.<br/>
        /// ### Integration &amp; Cursor Tip:<br/>
        /// - Fetches written user answers for text-input questions.<br/>
        /// - Uses cursor-based pagination (`after` query param) to stream responses.<br/>
        /// - Requires Administrator authorization.
        /// </summary>
        /// <param name="idOrSlug"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.PollTextResponse>> GetSurveyPollTextResponsesAsync(
            string idOrSlug,
            int? perPage = default,
            int? after = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Survey poll text responses<br/>
        /// Retrieve free-text poll responses for a specific survey.<br/>
        /// ### Integration &amp; Cursor Tip:<br/>
        /// - Fetches written user answers for text-input questions.<br/>
        /// - Uses cursor-based pagination (`after` query param) to stream responses.<br/>
        /// - Requires Administrator authorization.
        /// </summary>
        /// <param name="idOrSlug"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="after"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.PollTextResponse>>> GetSurveyPollTextResponsesAsResponseAsync(
            string idOrSlug,
            int? perPage = default,
            int? after = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}