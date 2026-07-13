#nullable enable

namespace Forem
{
    public partial interface IReactionsClient
    {
        /// <summary>
        /// toggle reaction<br/>
        /// Toggle a reaction on a target resource (Article, Comment, or User) on behalf of the authenticated user.<br/>
        ///         ### Toggle Logic:<br/>
        ///         - **First Request**: Creates a new reaction of the specified category on the reactable target.<br/>
        ///         - **Second Request (with same parameters)**: Deletes the existing reaction.<br/>
        ///         - Particularly useful for simple, interactive UI buttons like "Like", "Unicorn", or "Save" where clicking toggles the active state.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="reactableId"></param>
        /// <param name="reactableType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task CreateReactionsToggleAsync(
            global::Forem.CreateReactionsToggleCategory category,
            int reactableId,
            global::Forem.CreateReactionsToggleReactableType reactableType,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// toggle reaction<br/>
        /// Toggle a reaction on a target resource (Article, Comment, or User) on behalf of the authenticated user.<br/>
        ///         ### Toggle Logic:<br/>
        ///         - **First Request**: Creates a new reaction of the specified category on the reactable target.<br/>
        ///         - **Second Request (with same parameters)**: Deletes the existing reaction.<br/>
        ///         - Particularly useful for simple, interactive UI buttons like "Like", "Unicorn", or "Save" where clicking toggles the active state.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="reactableId"></param>
        /// <param name="reactableType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse> CreateReactionsToggleAsResponseAsync(
            global::Forem.CreateReactionsToggleCategory category,
            int reactableId,
            global::Forem.CreateReactionsToggleReactableType reactableType,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}