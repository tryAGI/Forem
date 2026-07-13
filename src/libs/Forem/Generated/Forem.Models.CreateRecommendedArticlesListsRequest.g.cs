
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRecommendedArticlesListsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placement_area")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PlacementArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("article_ids")]
        public global::System.Collections.Generic.IList<int>? ArticleIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecommendedArticlesListsRequest" /> class.
        /// </summary>
        /// <param name="placementArea"></param>
        /// <param name="userId"></param>
        /// <param name="name"></param>
        /// <param name="expiresAt"></param>
        /// <param name="articleIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRecommendedArticlesListsRequest(
            string placementArea,
            int userId,
            string? name,
            global::System.DateTime? expiresAt,
            global::System.Collections.Generic.IList<int>? articleIds)
        {
            this.Name = name;
            this.PlacementArea = placementArea ?? throw new global::System.ArgumentNullException(nameof(placementArea));
            this.ExpiresAt = expiresAt;
            this.UserId = userId;
            this.ArticleIds = articleIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRecommendedArticlesListsRequest" /> class.
        /// </summary>
        public CreateRecommendedArticlesListsRequest()
        {
        }

    }
}