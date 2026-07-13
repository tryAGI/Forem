
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of a concept
    /// </summary>
    public sealed partial class Concept
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public long? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("similarity_threshold")]
        public float? SimilarityThreshold { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daily_metrics")]
        public global::System.Collections.Generic.IList<global::Forem.ConceptDailyMetric>? DailyMetrics { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_articles")]
        public global::System.Collections.Generic.IList<global::Forem.ConceptTopArticle>? TopArticles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Concept" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="parentId"></param>
        /// <param name="score"></param>
        /// <param name="similarityThreshold"></param>
        /// <param name="dailyMetrics"></param>
        /// <param name="topArticles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Concept(
            long id,
            string name,
            string slug,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            long? parentId,
            float? score,
            float? similarityThreshold,
            global::System.Collections.Generic.IList<global::Forem.ConceptDailyMetric>? dailyMetrics,
            global::System.Collections.Generic.IList<global::Forem.ConceptTopArticle>? topArticles)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description;
            this.ParentId = parentId;
            this.Score = score;
            this.SimilarityThreshold = similarityThreshold;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DailyMetrics = dailyMetrics;
            this.TopArticles = topArticles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Concept" /> class.
        /// </summary>
        public Concept()
        {
        }

    }
}