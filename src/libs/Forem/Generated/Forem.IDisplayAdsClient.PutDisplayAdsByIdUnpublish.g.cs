#nullable enable

namespace Forem
{
    public partial interface IDisplayAdsClient
    {
        /// <summary>
        /// unpublish<br/>
        /// This endpoint allows the client to remove a display ad from rotation by un-publishing it.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task PutDisplayAdsByIdUnpublishAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}