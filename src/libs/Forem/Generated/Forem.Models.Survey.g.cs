
#nullable enable

namespace Forem
{
    /// <summary>
    /// Representation of a survey
    /// </summary>
    public sealed partial class Survey
    {
        /// <summary>
        /// Resource discriminator
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_of")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.SurveyTypeOfJsonConverter))]
        public global::Forem.SurveyTypeOf TypeOf { get; set; }

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
        /// Survey category
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("survey_type_of")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Forem.JsonConverters.SurveySurveyTypeOfJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Forem.SurveySurveyTypeOf SurveyTypeOf { get; set; }

        /// <summary>
        /// Whether the survey is currently active
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Whether to show the title to respondents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool DisplayTitle { get; set; }

        /// <summary>
        /// Whether users can submit multiple times
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_resubmission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowResubmission { get; set; }

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
        /// Initializes a new instance of the <see cref="Survey" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="slug"></param>
        /// <param name="surveyTypeOf">
        /// Survey category
        /// </param>
        /// <param name="displayTitle">
        /// Whether to show the title to respondents
        /// </param>
        /// <param name="allowResubmission">
        /// Whether users can submit multiple times
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="typeOf">
        /// Resource discriminator
        /// </param>
        /// <param name="active">
        /// Whether the survey is currently active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Survey(
            long id,
            string title,
            string slug,
            global::Forem.SurveySurveyTypeOf surveyTypeOf,
            bool displayTitle,
            bool allowResubmission,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Forem.SurveyTypeOf typeOf,
            bool? active)
        {
            this.TypeOf = typeOf;
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.SurveyTypeOf = surveyTypeOf;
            this.Active = active;
            this.DisplayTitle = displayTitle;
            this.AllowResubmission = allowResubmission;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Survey" /> class.
        /// </summary>
        public Survey()
        {
        }

    }
}