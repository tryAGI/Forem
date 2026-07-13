#nullable enable

namespace Forem.JsonConverters
{
    /// <inheritdoc />
    public sealed class SurveyTypeOfNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Forem.SurveyTypeOf?>
    {
        /// <inheritdoc />
        public override global::Forem.SurveyTypeOf? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Forem.SurveyTypeOfExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Forem.SurveyTypeOf)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Forem.SurveyTypeOf?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Forem.SurveyTypeOf? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Forem.SurveyTypeOfExtensions.ToValueString(value.Value));
            }
        }
    }
}
