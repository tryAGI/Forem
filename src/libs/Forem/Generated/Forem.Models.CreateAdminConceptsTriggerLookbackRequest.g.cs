
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAdminConceptsTriggerLookbackRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Days { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminConceptsTriggerLookbackRequest" /> class.
        /// </summary>
        /// <param name="days"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAdminConceptsTriggerLookbackRequest(
            int days)
        {
            this.Days = days;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAdminConceptsTriggerLookbackRequest" /> class.
        /// </summary>
        public CreateAdminConceptsTriggerLookbackRequest()
        {
        }

    }
}