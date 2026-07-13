
#nullable enable

namespace Forem
{
    /// <summary>
    /// Survey category
    /// </summary>
    public enum SurveySurveyTypeOf
    {
        /// <summary>
        /// 
        /// </summary>
        CommunityPulse,
        /// <summary>
        /// 
        /// </summary>
        Fun,
        /// <summary>
        /// 
        /// </summary>
        Industry,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SurveySurveyTypeOfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SurveySurveyTypeOf value)
        {
            return value switch
            {
                SurveySurveyTypeOf.CommunityPulse => "community_pulse",
                SurveySurveyTypeOf.Fun => "fun",
                SurveySurveyTypeOf.Industry => "industry",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SurveySurveyTypeOf? ToEnum(string value)
        {
            return value switch
            {
                "community_pulse" => SurveySurveyTypeOf.CommunityPulse,
                "fun" => SurveySurveyTypeOf.Fun,
                "industry" => SurveySurveyTypeOf.Industry,
                _ => null,
            };
        }
    }
}