#nullable enable

namespace Forem.JsonConverters
{
    /// <inheritdoc />
    public sealed class DisplayAdDisplayToJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Forem.DisplayAdDisplayTo>
    {
        /// <inheritdoc />
        public override global::Forem.DisplayAdDisplayTo Read(
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
                        return global::Forem.DisplayAdDisplayToExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Forem.DisplayAdDisplayTo)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Forem.DisplayAdDisplayTo);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Forem.DisplayAdDisplayTo value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Forem.DisplayAdDisplayToExtensions.ToValueString(value));
        }
    }
}
