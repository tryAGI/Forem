#nullable enable

namespace Forem.JsonConverters
{
    /// <inheritdoc />
    public sealed class DisplayAdPlacementAreaNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Forem.DisplayAdPlacementArea?>
    {
        /// <inheritdoc />
        public override global::Forem.DisplayAdPlacementArea? Read(
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
                        return global::Forem.DisplayAdPlacementAreaExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Forem.DisplayAdPlacementArea)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Forem.DisplayAdPlacementArea?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Forem.DisplayAdPlacementArea? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Forem.DisplayAdPlacementAreaExtensions.ToValueString(value.Value));
            }
        }
    }
}
