#nullable enable

namespace Forem
{
    public partial interface ISurveysClient
    {
        /// <summary>
        /// List surveys<br/>
        /// Retrieve a list of surveys configured on the platform.<br/>
        /// ### Surveys Overview:<br/>
        /// - Surveys are admin-defined questionnaires consisting of multiple choice or text polls.<br/>
        /// - Requires Administrator authorization.<br/>
        /// - Supports standard pagination controls and active status filtering.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="active"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Survey>> GetSurveysAsync(
            int? page = default,
            int? perPage = default,
            bool? active = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List surveys<br/>
        /// Retrieve a list of surveys configured on the platform.<br/>
        /// ### Surveys Overview:<br/>
        /// - Surveys are admin-defined questionnaires consisting of multiple choice or text polls.<br/>
        /// - Requires Administrator authorization.<br/>
        /// - Supports standard pagination controls and active status filtering.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="active"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Survey>>> GetSurveysAsResponseAsync(
            int? page = default,
            int? perPage = default,
            bool? active = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}