
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchFeedbackMessagesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_message")]
        public global::Forem.PatchFeedbackMessagesRequestFeedbackMessage? FeedbackMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchFeedbackMessagesRequest" /> class.
        /// </summary>
        /// <param name="feedbackMessage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchFeedbackMessagesRequest(
            global::Forem.PatchFeedbackMessagesRequestFeedbackMessage? feedbackMessage)
        {
            this.FeedbackMessage = feedbackMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchFeedbackMessagesRequest" /> class.
        /// </summary>
        public PatchFeedbackMessagesRequest()
        {
        }

    }
}