
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentUserIds
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<int>? UserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentUserIds" /> class.
        /// </summary>
        /// <param name="userIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SegmentUserIds(
            global::System.Collections.Generic.IList<int>? userIds)
        {
            this.UserIds = userIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentUserIds" /> class.
        /// </summary>
        public SegmentUserIds()
        {
        }

    }
}