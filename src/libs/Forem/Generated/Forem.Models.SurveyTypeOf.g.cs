
#nullable enable

namespace Forem
{
    /// <summary>
    /// Resource discriminator
    /// </summary>
    public enum SurveyTypeOf
    {
        /// <summary>
        /// 
        /// </summary>
        Survey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SurveyTypeOfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SurveyTypeOf value)
        {
            return value switch
            {
                SurveyTypeOf.Survey => "survey",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SurveyTypeOf? ToEnum(string value)
        {
            return value switch
            {
                "survey" => SurveyTypeOf.Survey,
                _ => null,
            };
        }
    }
}