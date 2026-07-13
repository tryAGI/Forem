#nullable enable

namespace Forem
{
    public partial interface ISurveysClient
    {
        /// <summary>
        /// A survey with polls<br/>
        /// Retrieve a single survey (by ID or slug) with its nested structure.<br/>
        /// ### Nested Format Details:<br/>
        /// - Returns the target Survey object including all associated Polls, multiple choice options, and configuration states.<br/>
        /// - Requires Administrator authorization.
        /// </summary>
        /// <param name="idOrSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.SurveyWithPolls> GetSurveyByIdOrSlugAsync(
            string idOrSlug,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// A survey with polls<br/>
        /// Retrieve a single survey (by ID or slug) with its nested structure.<br/>
        /// ### Nested Format Details:<br/>
        /// - Returns the target Survey object including all associated Polls, multiple choice options, and configuration states.<br/>
        /// - Requires Administrator authorization.
        /// </summary>
        /// <param name="idOrSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.SurveyWithPolls>> GetSurveyByIdOrSlugAsResponseAsync(
            string idOrSlug,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}