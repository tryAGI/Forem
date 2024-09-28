
#nullable enable

namespace Forem
{
    /// <summary>
    /// Flare tag of the article
    /// </summary>
    public sealed partial class ArticleFlareTag
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Background color (hexadecimal)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bg_color_hex")]
        public string? BgColorHex { get; set; }

        /// <summary>
        /// Text color (hexadecimal)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_color_hex")]
        public string? TextColorHex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}