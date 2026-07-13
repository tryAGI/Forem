#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Forem.JsonConverters
{
    /// <inheritdoc />
    public class SurveyWithPollsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Forem.SurveyWithPolls>
    {
        /// <inheritdoc />
        public override global::Forem.SurveyWithPolls Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("active")) __score0++;
            if (__jsonProps.Contains("allow_resubmission")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("display_title")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("slug")) __score0++;
            if (__jsonProps.Contains("survey_type_of")) __score0++;
            if (__jsonProps.Contains("title")) __score0++;
            if (__jsonProps.Contains("type_of")) __score0++;
            if (__jsonProps.Contains("updated_at")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("polls")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Forem.Survey? survey = default;
            global::Forem.SurveyWithPollsVariant2? surveyWithPollsVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Forem.Survey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Forem.Survey> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Forem.Survey).Name}");
                        survey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Forem.SurveyWithPollsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Forem.SurveyWithPollsVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Forem.SurveyWithPollsVariant2).Name}");
                        surveyWithPollsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (survey == null && surveyWithPollsVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Forem.Survey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Forem.Survey> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Forem.Survey).Name}");
                    survey = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (survey == null && surveyWithPollsVariant2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Forem.SurveyWithPollsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Forem.SurveyWithPollsVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Forem.SurveyWithPollsVariant2).Name}");
                    surveyWithPollsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Forem.SurveyWithPolls(
                survey,

                surveyWithPollsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Forem.SurveyWithPolls value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSurvey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Forem.Survey), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Forem.Survey?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Forem.Survey).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Survey!, typeInfo);
            }
            else if (value.IsSurveyWithPollsVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Forem.SurveyWithPollsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Forem.SurveyWithPollsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Forem.SurveyWithPollsVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SurveyWithPollsVariant2!, typeInfo);
            }
        }
    }
}