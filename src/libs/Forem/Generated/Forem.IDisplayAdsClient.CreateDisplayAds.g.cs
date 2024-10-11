#nullable enable

namespace Forem
{
    public partial interface IDisplayAdsClient
    {
        /// <summary>
        /// display ads<br/>
        /// This endpoint allows the client to create a new display ad.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> CreateDisplayAdsAsync(
            object request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// display ads<br/>
        /// This endpoint allows the client to create a new display ad.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> CreateDisplayAdsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}