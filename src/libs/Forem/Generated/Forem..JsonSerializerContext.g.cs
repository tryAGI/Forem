
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[] 
        { 
            typeof(global::Forem.JsonConverters.PageTemplateJsonConverter),
            typeof(global::Forem.JsonConverters.PageTemplateNullableJsonConverter),
            typeof(global::Forem.JsonConverters.DisplayAdPlacementAreaJsonConverter),
            typeof(global::Forem.JsonConverters.DisplayAdPlacementAreaNullableJsonConverter),
            typeof(global::Forem.JsonConverters.DisplayAdAudienceSegmentTypeJsonConverter),
            typeof(global::Forem.JsonConverters.DisplayAdAudienceSegmentTypeNullableJsonConverter),
            typeof(global::Forem.JsonConverters.DisplayAdDisplayToJsonConverter),
            typeof(global::Forem.JsonConverters.DisplayAdDisplayToNullableJsonConverter),
            typeof(global::Forem.JsonConverters.DisplayAdTypeOfJsonConverter),
            typeof(global::Forem.JsonConverters.DisplayAdTypeOfNullableJsonConverter),
            typeof(global::Forem.JsonConverters.RequestTemplateJsonConverter),
            typeof(global::Forem.JsonConverters.RequestTemplateNullableJsonConverter),
            typeof(global::Forem.JsonConverters.GetArticlesStateJsonConverter),
            typeof(global::Forem.JsonConverters.GetArticlesStateNullableJsonConverter),
            typeof(global::Forem.JsonConverters.CategoryJsonConverter),
            typeof(global::Forem.JsonConverters.CategoryNullableJsonConverter),
            typeof(global::Forem.JsonConverters.ReactableTypeJsonConverter),
            typeof(global::Forem.JsonConverters.ReactableTypeNullableJsonConverter),
            typeof(global::Forem.JsonConverters.Category2JsonConverter),
            typeof(global::Forem.JsonConverters.Category2NullableJsonConverter),
            typeof(global::Forem.JsonConverters.ReactableType2JsonConverter),
            typeof(global::Forem.JsonConverters.ReactableType2NullableJsonConverter),
            typeof(global::Forem.JsonConverters.UnixTimestampJsonConverter),
        })]

    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.JsonSerializerContextTypes))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}