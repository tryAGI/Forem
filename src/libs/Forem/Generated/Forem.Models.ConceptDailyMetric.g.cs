
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of daily metrics for a concept
    /// </summary>
    public sealed partial class ConceptDailyMetric
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("articles_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ArticlesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comments_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CommentsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_views")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageViews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reactions_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReactionsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("popularity_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float PopularityScore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConceptDailyMetric" /> class.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="articlesCount"></param>
        /// <param name="commentsCount"></param>
        /// <param name="pageViews"></param>
        /// <param name="reactionsCount"></param>
        /// <param name="popularityScore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConceptDailyMetric(
            global::System.DateTime date,
            int articlesCount,
            int commentsCount,
            int pageViews,
            int reactionsCount,
            float popularityScore)
        {
            this.Date = date;
            this.ArticlesCount = articlesCount;
            this.CommentsCount = commentsCount;
            this.PageViews = pageViews;
            this.ReactionsCount = reactionsCount;
            this.PopularityScore = popularityScore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConceptDailyMetric" /> class.
        /// </summary>
        public ConceptDailyMetric()
        {
        }

    }
}