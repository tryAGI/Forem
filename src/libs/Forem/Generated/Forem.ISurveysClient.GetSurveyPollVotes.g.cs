#nullable enable

namespace Forem
{
    public partial interface ISurveysClient
    {
        /// <summary>
        /// Survey poll votes<br/>
        /// Retrieve multiple-choice poll votes for a specific survey.<br/>
        /// ### Cursor Pagination Tip:<br/>
        /// - Uses cursor-based pagination to safely stream high volumes of voting records.<br/>
        /// - Specify the `after` query parameter with the last retrieved record ID to get the next page.<br/>
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.PollVote>> GetSurveyPollVotesAsync(
            string idOrSlug,
            int? perPage = default,
            int? after = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Survey poll votes<br/>
        /// Retrieve multiple-choice poll votes for a specific survey.<br/>
        /// ### Cursor Pagination Tip:<br/>
        /// - Uses cursor-based pagination to safely stream high volumes of voting records.<br/>
        /// - Specify the `after` query parameter with the last retrieved record ID to get the next page.<br/>
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
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.PollVote>>> GetSurveyPollVotesAsResponseAsync(
            string idOrSlug,
            int? perPage = default,
            int? after = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}