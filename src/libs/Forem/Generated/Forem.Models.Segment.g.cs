
#nullable enable

namespace Forem
{
    /// <summary>
    /// A manually managed audience segment
    /// </summary>
    public sealed partial class Segment
    {
        /// <summary>
        /// The ID of the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Marks the segment as manually managed (other types are internal)<br/>
        /// Default Value: manual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.SegmentTypeOfJsonConverter))]
        public global::Forem.SegmentTypeOf? TypeOf { get; set; }

        /// <summary>
        /// The current number of users in the segment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_count")]
        public int? UserCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the segment
        /// </param>
        /// <param name="typeOf">
        /// Marks the segment as manually managed (other types are internal)<br/>
        /// Default Value: manual
        /// </param>
        /// <param name="userCount">
        /// The current number of users in the segment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Segment(
            int? id,
            global::Forem.SegmentTypeOf? typeOf,
            int? userCount)
        {
            this.Id = id;
            this.TypeOf = typeOf;
            this.UserCount = userCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Segment" /> class.
        /// </summary>
        public Segment()
        {
        }

    }
}