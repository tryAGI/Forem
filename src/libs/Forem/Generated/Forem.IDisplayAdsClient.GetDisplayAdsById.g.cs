#nullable enable

namespace Forem
{
    public partial interface IDisplayAdsClient
    {
        /// <summary>
        /// display ad<br/>
        /// This endpoint allows the client to retrieve a single display ad, via its id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task GetDisplayAdsByIdAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}