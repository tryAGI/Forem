#nullable enable

namespace Forem
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// list the authenticated user's agent sessions<br/>
        /// Retrieve a list of the authenticated user's agent sessions.<br/>
        /// ### Agent Sessions Overview:<br/>
        /// - Agent sessions represent coding conversation transcripts uploaded from CLI tools (like Claude Code).<br/>
        /// - Used by the developer portal to render interactive walkthroughs or session summaries.<br/>
        /// - Requires authentication.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Forem.AgentSessionIndex>> GetAgentSessionsAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// list the authenticated user's agent sessions<br/>
        /// Retrieve a list of the authenticated user's agent sessions.<br/>
        /// ### Agent Sessions Overview:<br/>
        /// - Agent sessions represent coding conversation transcripts uploaded from CLI tools (like Claude Code).<br/>
        /// - Used by the developer portal to render interactive walkthroughs or session summaries.<br/>
        /// - Requires authentication.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Forem.AgentSessionIndex>>> GetAgentSessionsAsResponseAsync(
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}