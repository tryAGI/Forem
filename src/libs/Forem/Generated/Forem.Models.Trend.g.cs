
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of a trend
    /// </summary>
    public sealed partial class Trend
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
        [global::System.Text.Json.Serialization.JsonPropertyName("key_questions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> KeyQuestions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required float Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("articles_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ArticlesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image")]
        public string? CoverImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_observed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime FirstObservedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_observed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastObservedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="Trend" /> class.
        /// </summary>
        /// <param name="typeOf"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="keyQuestions"></param>
        /// <param name="score"></param>
        /// <param name="articlesCount"></param>
        /// <param name="firstObservedAt"></param>
        /// <param name="lastObservedAt"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
        /// <param name="coverImage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Trend(
            string typeOf,
            long id,
            string name,
            string slug,
            global::System.Collections.Generic.IList<string> keyQuestions,
            float score,
            int articlesCount,
            global::System.DateTime firstObservedAt,
            global::System.DateTime lastObservedAt,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            string? coverImage)
        {
            this.TypeOf = typeOf ?? throw new global::System.ArgumentNullException(nameof(typeOf));
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Description = description;
            this.KeyQuestions = keyQuestions ?? throw new global::System.ArgumentNullException(nameof(keyQuestions));
            this.Score = score;
            this.ArticlesCount = articlesCount;
            this.CoverImage = coverImage;
            this.FirstObservedAt = firstObservedAt;
            this.LastObservedAt = lastObservedAt;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trend" /> class.
        /// </summary>
        public Trend()
        {
        }

    }
}