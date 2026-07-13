
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatchRecommendedArticlesListsRequest
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
        public string? PlacementArea { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

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
        /// Initializes a new instance of the <see cref="PatchRecommendedArticlesListsRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="placementArea"></param>
        /// <param name="expiresAt"></param>
        /// <param name="userId"></param>
        /// <param name="articleIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchRecommendedArticlesListsRequest(
            string? name,
            string? placementArea,
            global::System.DateTime? expiresAt,
            int? userId,
            global::System.Collections.Generic.IList<int>? articleIds)
        {
            this.Name = name;
            this.PlacementArea = placementArea;
            this.ExpiresAt = expiresAt;
            this.UserId = userId;
            this.ArticleIds = articleIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchRecommendedArticlesListsRequest" /> class.
        /// </summary>
        public PatchRecommendedArticlesListsRequest()
        {
        }

    }
}