
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of a page object
    /// </summary>
    public sealed partial class Page
    {
        /// <summary>
        /// Title of the page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Used to link to this page in URLs, must be unique and URL-safe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Slug { get; set; }

        /// <summary>
        /// For internal use, helps similar pages from one another
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The text (in markdown) of the ad (required)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_markdown")]
        public string? BodyMarkdown { get; set; }

        /// <summary>
        /// For JSON pages, the JSON body
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_json")]
        public string? BodyJson { get; set; }

        /// <summary>
        /// If true, the page is available at '/{slug}' instead of '/page/{slug}', use with caution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_top_level_path")]
        public bool? IsTopLevelPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("social_image")]
        public object? SocialImage { get; set; }

        /// <summary>
        /// Controls what kind of layout the page is rendered in<br/>
        /// Default Value: contained
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.PageTemplateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Forem.PageTemplate Template { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}