#nullable enable

namespace Forem
{
    public partial interface IPagesClient
    {
        /// <summary>
        /// remove a page<br/>
        /// This endpoint allows the client to delete a single Page object, specified by ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.Page> DeletePagesByIdAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}