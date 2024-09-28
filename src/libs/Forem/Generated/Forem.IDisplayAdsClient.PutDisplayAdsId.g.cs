#nullable enable

namespace Forem
{
    public partial interface IDisplayAdsClient
    {
        /// <summary>
        /// display ads<br/>
        /// This endpoint allows the client to update the attributes of a single display ad, via its id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Response2> PutDisplayAdsIdAsync(
            int id,
            global::Forem.Request2 request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// display ads<br/>
        /// This endpoint allows the client to update the attributes of a single display ad, via its id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Response2> PutDisplayAdsIdAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}