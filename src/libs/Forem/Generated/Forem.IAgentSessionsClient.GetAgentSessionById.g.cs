#nullable enable

namespace Forem
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// show details for an agent session<br/>
        /// Retrieve details for a single agent session by unique slug or ID.<br/>
        /// ### Integration Tip:<br/>
        /// - Returns the complete session structure including parsed message logs, token counts, slices, and tool execution metadata.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AgentSessionShow> GetAgentSessionByIdAsync(
            string id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// show details for an agent session<br/>
        /// Retrieve details for a single agent session by unique slug or ID.<br/>
        /// ### Integration Tip:<br/>
        /// - Returns the complete session structure including parsed message logs, token counts, slices, and tool execution metadata.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.AgentSessionShow>> GetAgentSessionByIdAsResponseAsync(
            string id,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}