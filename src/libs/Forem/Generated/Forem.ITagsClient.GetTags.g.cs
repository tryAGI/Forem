#nullable enable

namespace Forem
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Tags<br/>
        /// Retrieve a list of tags used on the platform, ordered by popularity.<br/>
        /// ### Integration Tips:<br/>
        /// - Bypasses authentication (can be accessed publicly).<br/>
        /// - Ordered by overall popularity/usage metrics on the platform.<br/>
        /// - Useful for autocomplete inputs in article editors, tag selection screens in settings, or rendering global navigation/explore lists.<br/>
        /// It supports pagination, each page will contain 10 tags by default.
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
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Tag>> GetTagsAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tags<br/>
        /// Retrieve a list of tags used on the platform, ordered by popularity.<br/>
        /// ### Integration Tips:<br/>
        /// - Bypasses authentication (can be accessed publicly).<br/>
        /// - Ordered by overall popularity/usage metrics on the platform.<br/>
        /// - Useful for autocomplete inputs in article editors, tag selection screens in settings, or rendering global navigation/explore lists.<br/>
        /// It supports pagination, each page will contain 10 tags by default.
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
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.Tag>>> GetTagsAsResponseAsync(
            int? page = default,
            int? perPage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}