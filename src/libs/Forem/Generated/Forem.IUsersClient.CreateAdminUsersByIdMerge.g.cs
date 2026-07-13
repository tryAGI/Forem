#nullable enable

namespace Forem
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Merge user into another (Admin)<br/>
        /// Merge a duplicate user account into a target main account.<br/>
        /// ### Account Merging Behavior:<br/>
        /// - Transfers all comments, articles, reactions, and follows to the target user (`merge_user_id`).<br/>
        /// - Deletes/destroys the source user account once the merge completes successfully.<br/>
        /// - High risk! Action is permanent and irreversible.<br/>
        /// - Requires Super Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateAdminUsersByIdMergeAsync(
            int id,

            global::Forem.CreateAdminUsersMergeRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge user into another (Admin)<br/>
        /// Merge a duplicate user account into a target main account.<br/>
        /// ### Account Merging Behavior:<br/>
        /// - Transfers all comments, articles, reactions, and follows to the target user (`merge_user_id`).<br/>
        /// - Deletes/destroys the source user account once the merge completes successfully.<br/>
        /// - High risk! Action is permanent and irreversible.<br/>
        /// - Requires Super Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreateAdminUsersByIdMergeAsResponseAsync(
            int id,

            global::Forem.CreateAdminUsersMergeRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Merge user into another (Admin)<br/>
        /// Merge a duplicate user account into a target main account.<br/>
        /// ### Account Merging Behavior:<br/>
        /// - Transfers all comments, articles, reactions, and follows to the target user (`merge_user_id`).<br/>
        /// - Deletes/destroys the source user account once the merge completes successfully.<br/>
        /// - High risk! Action is permanent and irreversible.<br/>
        /// - Requires Super Admin credentials.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="mergeUserId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task CreateAdminUsersByIdMergeAsync(
            int id,
            int mergeUserId,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}