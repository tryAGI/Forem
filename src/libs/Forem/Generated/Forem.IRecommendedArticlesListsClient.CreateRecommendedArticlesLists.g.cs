#nullable enable

namespace Forem
{
    public partial interface IRecommendedArticlesListsClient
    {
        /// <summary>
        /// Create or update a recommended articles list<br/>
        /// Create a new recommended articles list or update an existing one. Requires Administrator privileges.<br/>
        /// ### Body Parameter Guidelines:<br/>
        /// - **name**: Curated list title or label (e.g. "Editor's Choice").<br/>
        /// - **placement_area**: Target UI layout region (e.g. `main_feed`, `sidebar_top`, `onboarding`).<br/>
        /// - **expires_at**: ISO 8601 timestamp after which the list recommendation automatically expires.<br/>
        /// - **user_id**: Owner/curator numeric user ID.<br/>
        /// - **article_ids**: Staged array of numeric article IDs to include in the recommendation sequence.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.RecommendedArticlesList> CreateRecommendedArticlesListsAsync(

            global::Forem.CreateRecommendedArticlesListsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a recommended articles list<br/>
        /// Create a new recommended articles list or update an existing one. Requires Administrator privileges.<br/>
        /// ### Body Parameter Guidelines:<br/>
        /// - **name**: Curated list title or label (e.g. "Editor's Choice").<br/>
        /// - **placement_area**: Target UI layout region (e.g. `main_feed`, `sidebar_top`, `onboarding`).<br/>
        /// - **expires_at**: ISO 8601 timestamp after which the list recommendation automatically expires.<br/>
        /// - **user_id**: Owner/curator numeric user ID.<br/>
        /// - **article_ids**: Staged array of numeric article IDs to include in the recommendation sequence.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.RecommendedArticlesList>> CreateRecommendedArticlesListsAsResponseAsync(

            global::Forem.CreateRecommendedArticlesListsRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create or update a recommended articles list<br/>
        /// Create a new recommended articles list or update an existing one. Requires Administrator privileges.<br/>
        /// ### Body Parameter Guidelines:<br/>
        /// - **name**: Curated list title or label (e.g. "Editor's Choice").<br/>
        /// - **placement_area**: Target UI layout region (e.g. `main_feed`, `sidebar_top`, `onboarding`).<br/>
        /// - **expires_at**: ISO 8601 timestamp after which the list recommendation automatically expires.<br/>
        /// - **user_id**: Owner/curator numeric user ID.<br/>
        /// - **article_ids**: Staged array of numeric article IDs to include in the recommendation sequence.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="placementArea"></param>
        /// <param name="expiresAt"></param>
        /// <param name="userId"></param>
        /// <param name="articleIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.RecommendedArticlesList> CreateRecommendedArticlesListsAsync(
            string placementArea,
            int userId,
            string? name = default,
            global::System.DateTime? expiresAt = default,
            global::System.Collections.Generic.IList<int>? articleIds = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}