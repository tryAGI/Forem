
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of an article or post returned in a list
    /// </summary>
    public sealed partial class ArticleIndex
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TypeOf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? CoverImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readable_publish_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReadablePublishDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SocialImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_list")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TagList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canonical_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CanonicalUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("positive_reactions_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PositiveReactionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_reactions_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicReactionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("edited_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? EditedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("crossposted_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? CrosspostedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_comment_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastCommentAt { get; set; }

        /// <summary>
        /// Crossposting or published date time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("published_timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime PublishedTimestamp { get; set; }

        /// <summary>
        /// Reading time, in minutes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reading_time_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReadingTimeMinutes { get; set; }

        /// <summary>
        /// The resource creator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Forem.SharedUser User { get; set; }

        /// <summary>
        /// Flare tag of the article
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flare_tag")]
        public global::Forem.ArticleFlareTag? FlareTag { get; set; }

        /// <summary>
        /// The organization the resource belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public global::Forem.SharedOrganization? Organization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}