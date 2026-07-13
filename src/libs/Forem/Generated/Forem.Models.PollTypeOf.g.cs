
#nullable enable

namespace Forem
{
    /// <summary>
    /// Resource discriminator
    /// </summary>
    public enum PollTypeOf
    {
        /// <summary>
        /// 
        /// </summary>
        Poll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PollTypeOfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PollTypeOf value)
        {
            return value switch
            {
                PollTypeOf.Poll => "poll",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PollTypeOf? ToEnum(string value)
        {
            return value switch
            {
                "poll" => PollTypeOf.Poll,
                _ => null,
            };
        }
    }
}