
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SurveyWithPollsVariant2
    {
        /// <summary>
        /// All polls in the survey, ordered by position
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Forem.Poll> Polls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyWithPollsVariant2" /> class.
        /// </summary>
        /// <param name="polls">
        /// All polls in the survey, ordered by position
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SurveyWithPollsVariant2(
            global::System.Collections.Generic.IList<global::Forem.Poll> polls)
        {
            this.Polls = polls ?? throw new global::System.ArgumentNullException(nameof(polls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SurveyWithPollsVariant2" /> class.
        /// </summary>
        public SurveyWithPollsVariant2()
        {
        }

    }
}