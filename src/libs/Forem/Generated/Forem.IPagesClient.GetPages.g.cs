#nullable enable

namespace Forem
{
    public partial interface IPagesClient
    {
        /// <summary>
        /// show details for all pages<br/>
        /// This endpoint allows the client to retrieve details for all Page objects.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Page>> GetPagesAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}