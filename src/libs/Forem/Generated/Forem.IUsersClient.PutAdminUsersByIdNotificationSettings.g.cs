#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Update user notification settings (Admin)<br/>
        /// Update a user's email notification preferences (e.g., unsubscribing them from the system newsletter). Requires Super Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task PutAdminUsersByIdNotificationSettingsAsync(
            int id,

            global::Forem.PutAdminUsersNotificationSettingsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user notification settings (Admin)<br/>
        /// Update a user's email notification preferences (e.g., unsubscribing them from the system newsletter). Requires Super Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> PutAdminUsersByIdNotificationSettingsAsResponseAsync(
            int id,

            global::Forem.PutAdminUsersNotificationSettingsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update user notification settings (Admin)<br/>
        /// Update a user's email notification preferences (e.g., unsubscribing them from the system newsletter). Requires Super Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="notificationSetting"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutAdminUsersByIdNotificationSettingsAsync(
            int id,
            global::Forem.PutAdminUsersNotificationSettingsRequestNotificationSetting notificationSetting,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}