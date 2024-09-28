
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of an Article to be created/updated
    /// </summary>
    public sealed partial class Article
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("article")]
        public global::Forem.ArticleArticle1? Article1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}