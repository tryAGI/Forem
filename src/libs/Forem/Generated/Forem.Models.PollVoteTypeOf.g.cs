
#nullable enable

namespace Forem
{
    /// <summary>
    /// Resource discriminator
    /// </summary>
    public enum PollVoteTypeOf
    {
        /// <summary>
        /// 
        /// </summary>
        PollVote,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PollVoteTypeOfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PollVoteTypeOf value)
        {
            return value switch
            {
                PollVoteTypeOf.PollVote => "poll_vote",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PollVoteTypeOf? ToEnum(string value)
        {
            return value switch
            {
                "poll_vote" => PollVoteTypeOf.PollVote,
                _ => null,
            };
        }
    }
}