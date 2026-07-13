
#nullable enable

namespace Forem
{
    /// <summary>
    /// Resource discriminator
    /// </summary>
    public enum PollOptionTypeOf
    {
        /// <summary>
        /// 
        /// </summary>
        PollOption,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PollOptionTypeOfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PollOptionTypeOf value)
        {
            return value switch
            {
                PollOptionTypeOf.PollOption => "poll_option",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PollOptionTypeOf? ToEnum(string value)
        {
            return value switch
            {
                "poll_option" => PollOptionTypeOf.PollOption,
                _ => null,
            };
        }
    }
}