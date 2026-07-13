
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateBadgesRequestBadge
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_badge_image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RemoteBadgeImageUrl { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBadgesRequestBadge" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="remoteBadgeImageUrl"></param>
        /// <param name="creditsAwarded"></param>
        /// <param name="allowMultipleAwards"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBadgesRequestBadge(
            string title,
            string description,
            string remoteBadgeImageUrl,
            int? creditsAwarded,
            bool? allowMultipleAwards)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.RemoteBadgeImageUrl = remoteBadgeImageUrl ?? throw new global::System.ArgumentNullException(nameof(remoteBadgeImageUrl));
            this.CreditsAwarded = creditsAwarded;
            this.AllowMultipleAwards = allowMultipleAwards;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBadgesRequestBadge" /> class.
        /// </summary>
        public CreateBadgesRequestBadge()
        {
        }

    }
}