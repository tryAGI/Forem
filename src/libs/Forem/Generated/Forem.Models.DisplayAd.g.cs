
#nullable enable

namespace Forem
{
    /// <summary>
    /// A Display Ad, aka Billboard, aka Widget
    /// </summary>
    public sealed partial class DisplayAd
    {
        /// <summary>
        /// The ID of the Display Ad
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// For internal use, helps distinguish ads from one another
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The text (in markdown) of the ad (required)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_markdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BodyMarkdown { get; set; }

        /// <summary>
        /// Ad must be both published and approved to be in rotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("approved")]
        public bool? Approved { get; set; }

        /// <summary>
        /// Ad must be both published and approved to be in rotation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published")]
        public bool? Published { get; set; }

        /// <summary>
        /// Identifies the organization to which the ad belongs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Identifies the user who created the ad.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_id")]
        public int? CreatorId { get; set; }

        /// <summary>
        /// Identifies which area of site layout the ad can appear in
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement_area")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.DisplayAdPlacementAreaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Forem.DisplayAdPlacementArea PlacementArea { get; set; }

        /// <summary>
        /// Tags on which this ad can be displayed (blank is all/any tags)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_list")]
        public string? TagList { get; set; }

        /// <summary>
        /// Articles this ad should *not* appear on (blank means no articles are disallowed, and this ad can appear next to any/all articles). Comma-separated list of integer Article IDs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("article_exclude_ids")]
        public string? ArticleExcludeIds { get; set; }

        /// <summary>
        /// Specifies an group of users to show this ad to (only works with logged-in users)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audience_segment_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.DisplayAdAudienceSegmentTypeJsonConverter))]
        public global::Forem.DisplayAdAudienceSegmentType? AudienceSegmentType { get; set; }

        /// <summary>
        /// Potentially limits visitors to whom the ad is visible<br/>
        /// Default Value: all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_to")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.DisplayAdDisplayToJsonConverter))]
        public global::Forem.DisplayAdDisplayTo? DisplayTo { get; set; } = global::Forem.DisplayAdDisplayTo.All;

        /// <summary>
        /// Types of the billboards:<br/>
        /// in_house (created by admins),<br/>
        /// community (created by an entity, appears on entity's content),<br/>
        /// external ( created by an entity, or a non-entity, can appear everywhere)<br/>
        /// Default Value: in_house
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.DisplayAdTypeOfJsonConverter))]
        public global::Forem.DisplayAdTypeOf? TypeOf { get; set; } = global::Forem.DisplayAdTypeOf.InHouse;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::Forem.DisplayAd? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Forem.DisplayAd),
                jsonSerializerContext) as global::Forem.DisplayAd;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Forem.DisplayAd? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Forem.DisplayAd>(
                json,
                jsonSerializerOptions);
        }

    }
}