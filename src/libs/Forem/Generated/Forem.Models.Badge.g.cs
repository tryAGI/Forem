
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of a badge
    /// </summary>
    public sealed partial class Badge
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("badge_image")]
        public global::Forem.BadgeBadgeImage? BadgeImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credits_awarded")]
        public int? CreditsAwarded { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_multiple_awards")]
        public bool? AllowMultipleAwards { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Badge" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="slug"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="badgeImage"></param>
        /// <param name="creditsAwarded"></param>
        /// <param name="allowMultipleAwards"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Badge(
            long id,
            string title,
            string slug,
            string description,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Forem.BadgeBadgeImage? badgeImage,
            int? creditsAwarded,
            bool? allowMultipleAwards)
        {
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.BadgeImage = badgeImage;
            this.CreditsAwarded = creditsAwarded;
            this.AllowMultipleAwards = allowMultipleAwards;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Badge" /> class.
        /// </summary>
        public Badge()
        {
        }

    }
}