
#nullable enable

namespace Forem
{
    /// <summary>
    /// Poll question type: single_choice, multiple_choice, scale, or text_input
    /// </summary>
    public enum PollPollTypeOf
    {
        /// <summary>
        /// single_choice, multiple_choice, scale, or text_input
        /// </summary>
        MultipleChoice,
        /// <summary>
        /// single_choice, multiple_choice, scale, or text_input
        /// </summary>
        Scale,
        /// <summary>
        /// single_choice, multiple_choice, scale, or text_input
        /// </summary>
        SingleChoice,
        /// <summary>
        /// single_choice, multiple_choice, scale, or text_input
        /// </summary>
        TextInput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PollPollTypeOfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PollPollTypeOf value)
        {
            return value switch
            {
                PollPollTypeOf.MultipleChoice => "multiple_choice",
                PollPollTypeOf.Scale => "scale",
                PollPollTypeOf.SingleChoice => "single_choice",
                PollPollTypeOf.TextInput => "text_input",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PollPollTypeOf? ToEnum(string value)
        {
            return value switch
            {
                "multiple_choice" => PollPollTypeOf.MultipleChoice,
                "scale" => PollPollTypeOf.Scale,
                "single_choice" => PollPollTypeOf.SingleChoice,
                "text_input" => PollPollTypeOf.TextInput,
                _ => null,
            };
        }
    }
}