#nullable enable

namespace Forem
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Tags<br/>
        /// This endpoint allows the client to retrieve a list of tags that can be used to tag articles.<br/>
        /// It will return tags ordered by popularity.<br/>
        /// It supports pagination, each page will contain 10 tags by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.Tag>> GetTagsAsync(
            int? page = 1,
            int? perPage = 10,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}