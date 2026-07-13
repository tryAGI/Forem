
#nullable enable

namespace Forem
{
    /// <summary>
    /// Resource discriminator
    /// </summary>
    public enum PollTextResponseTypeOf
    {
        /// <summary>
        /// 
        /// </summary>
        PollTextResponse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PollTextResponseTypeOfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PollTextResponseTypeOf value)
        {
            return value switch
            {
                PollTextResponseTypeOf.PollTextResponse => "poll_text_response",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PollTextResponseTypeOf? ToEnum(string value)
        {
            return value switch
            {
                "poll_text_response" => PollTextResponseTypeOf.PollTextResponse,
                _ => null,
            };
        }
    }
}