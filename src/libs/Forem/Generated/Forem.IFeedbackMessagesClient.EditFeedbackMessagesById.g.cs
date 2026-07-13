#nullable enable

namespace Forem
{
    public partial interface IFeedbackMessagesClient
    {
        /// <summary>
        /// Update a feedback message's status (Admin)<br/>
        /// Update the status of a user feedback message or report.<br/>
        /// ### Feedback Messages Overview:<br/>
        /// - Feedback messages are submitted by users via support forms or content abuse reporting modals.<br/>
        /// - Requires Administrator privileges.<br/>
        /// - Used to track moderation/resolution workflows (e.g. marking a spam report as `Resolved`, `Spam`, or `Ignored`).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task EditFeedbackMessagesByIdAsync(
            int id,

            global::Forem.PatchFeedbackMessagesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a feedback message's status (Admin)<br/>
        /// Update the status of a user feedback message or report.<br/>
        /// ### Feedback Messages Overview:<br/>
        /// - Feedback messages are submitted by users via support forms or content abuse reporting modals.<br/>
        /// - Requires Administrator privileges.<br/>
        /// - Used to track moderation/resolution workflows (e.g. marking a spam report as `Resolved`, `Spam`, or `Ignored`).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> EditFeedbackMessagesByIdAsResponseAsync(
            int id,

            global::Forem.PatchFeedbackMessagesRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a feedback message's status (Admin)<br/>
        /// Update the status of a user feedback message or report.<br/>
        /// ### Feedback Messages Overview:<br/>
        /// - Feedback messages are submitted by users via support forms or content abuse reporting modals.<br/>
        /// - Requires Administrator privileges.<br/>
        /// - Used to track moderation/resolution workflows (e.g. marking a spam report as `Resolved`, `Spam`, or `Ignored`).
        /// </summary>
        /// <param name="id"></param>
        /// <param name="feedbackMessage"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task EditFeedbackMessagesByIdAsync(
            int id,
            global::Forem.PatchFeedbackMessagesRequestFeedbackMessage? feedbackMessage = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}