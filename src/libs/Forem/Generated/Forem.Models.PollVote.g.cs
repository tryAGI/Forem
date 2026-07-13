
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of a single poll vote cast by a user
    /// </summary>
    public sealed partial class PollVote
    {
        /// <summary>
        /// Resource discriminator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.PollVoteTypeOfJsonConverter))]
        public global::Forem.PollVoteTypeOf TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long PollId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poll_option_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long PollOptionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SessionStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PollVote" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pollId"></param>
        /// <param name="pollOptionId"></param>
        /// <param name="userId"></param>
        /// <param name="userEmail"></param>
        /// <param name="sessionStart"></param>
        /// <param name="createdAt"></param>
        /// <param name="typeOf">
        /// Resource discriminator
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PollVote(
            long id,
            long pollId,
            long pollOptionId,
            long userId,
            string userEmail,
            int sessionStart,
            global::System.DateTime createdAt,
            global::Forem.PollVoteTypeOf typeOf)
        {
            this.TypeOf = typeOf;
            this.Id = id;
            this.PollId = pollId;
            this.PollOptionId = pollOptionId;
            this.UserId = userId;
            this.UserEmail = userEmail ?? throw new global::System.ArgumentNullException(nameof(userEmail));
            this.SessionStart = sessionStart;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PollVote" /> class.
        /// </summary>
        public PollVote()
        {
        }

    }
}