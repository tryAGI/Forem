#nullable enable

namespace Forem
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// upload a new agent session<br/>
        /// Upload a new agent session.<br/>
        /// ### S3 Upload Workflow:<br/>
        /// 1. Call the S3 presign endpoint to obtain a direct upload URL for the raw session transcript file.<br/>
        /// 2. Upload the raw transcript to S3.<br/>
        /// 3. Send a POST request to this endpoint with the S3 key (`s3_key`) and the pre-parsed, curated JSON payload (`curated_data`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AgentSessionIndex> CreateAgentSessionAsync(

            global::Forem.CreateAgentSessionRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// upload a new agent session<br/>
        /// Upload a new agent session.<br/>
        /// ### S3 Upload Workflow:<br/>
        /// 1. Call the S3 presign endpoint to obtain a direct upload URL for the raw session transcript file.<br/>
        /// 2. Upload the raw transcript to S3.<br/>
        /// 3. Send a POST request to this endpoint with the S3 key (`s3_key`) and the pre-parsed, curated JSON payload (`curated_data`).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Forem.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AutoSDKHttpResponse<global::Forem.AgentSessionIndex>> CreateAgentSessionAsResponseAsync(

            global::Forem.CreateAgentSessionRequest request,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// upload a new agent session<br/>
        /// Upload a new agent session.<br/>
        /// ### S3 Upload Workflow:<br/>
        /// 1. Call the S3 presign endpoint to obtain a direct upload URL for the raw session transcript file.<br/>
        /// 2. Upload the raw transcript to S3.<br/>
        /// 3. Send a POST request to this endpoint with the S3 key (`s3_key`) and the pre-parsed, curated JSON payload (`curated_data`).
        /// </summary>
        /// <param name="title">
        /// Title for the session (auto-generated if omitted)
        /// </param>
        /// <param name="curatedData">
        /// JSON string of curated session data with messages array and metadata.
        /// </param>
        /// <param name="s3Key">
        /// S3 object key from presign endpoint (optional).
        /// </param>
        /// <param name="toolName">
        /// Tool that produced the session (e.g. claude_code, codex).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Forem.AgentSessionIndex> CreateAgentSessionAsync(
            string curatedData,
            string? title = default,
            string? s3Key = default,
            global::Forem.CreateAgentSessionRequestToolName? toolName = default,
            global::Forem.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}