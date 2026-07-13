
#nullable enable

namespace Forem
{
    /// <summary>
    /// Specifies a group of users who will see this billboard (must match audience_segment_id if both provided)
    /// </summary>
    public enum BillboardAudienceSegmentType
    {
        /// <summary>
        /// 
        /// </summary>
        DarkTheme,
        /// <summary>
        /// 
        /// </summary>
        Experience1,
        /// <summary>
        /// 
        /// </summary>
        Experience2,
        /// <summary>
        /// 
        /// </summary>
        Experience3,
        /// <summary>
        /// 
        /// </summary>
        Experience4,
        /// <summary>
        /// 
        /// </summary>
        Experience5,
        /// <summary>
        /// 
        /// </summary>
        LightTheme,
        /// <summary>
        /// 
        /// </summary>
        Manual,
        /// <summary>
        /// 
        /// </summary>
        NoExperience,
        /// <summary>
        /// 
        /// </summary>
        NoPostsYet,
        /// <summary>
        /// 
        /// </summary>
        Posted,
        /// <summary>
        /// 
        /// </summary>
        Trusted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillboardAudienceSegmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillboardAudienceSegmentType value)
        {
            return value switch
            {
                BillboardAudienceSegmentType.DarkTheme => "dark_theme",
                BillboardAudienceSegmentType.Experience1 => "experience1",
                BillboardAudienceSegmentType.Experience2 => "experience2",
                BillboardAudienceSegmentType.Experience3 => "experience3",
                BillboardAudienceSegmentType.Experience4 => "experience4",
                BillboardAudienceSegmentType.Experience5 => "experience5",
                BillboardAudienceSegmentType.LightTheme => "light_theme",
                BillboardAudienceSegmentType.Manual => "manual",
                BillboardAudienceSegmentType.NoExperience => "no_experience",
                BillboardAudienceSegmentType.NoPostsYet => "no_posts_yet",
                BillboardAudienceSegmentType.Posted => "posted",
                BillboardAudienceSegmentType.Trusted => "trusted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillboardAudienceSegmentType? ToEnum(string value)
        {
            return value switch
            {
                "dark_theme" => BillboardAudienceSegmentType.DarkTheme,
                "experience1" => BillboardAudienceSegmentType.Experience1,
                "experience2" => BillboardAudienceSegmentType.Experience2,
                "experience3" => BillboardAudienceSegmentType.Experience3,
                "experience4" => BillboardAudienceSegmentType.Experience4,
                "experience5" => BillboardAudienceSegmentType.Experience5,
                "light_theme" => BillboardAudienceSegmentType.LightTheme,
                "manual" => BillboardAudienceSegmentType.Manual,
                "no_experience" => BillboardAudienceSegmentType.NoExperience,
                "no_posts_yet" => BillboardAudienceSegmentType.NoPostsYet,
                "posted" => BillboardAudienceSegmentType.Posted,
                "trusted" => BillboardAudienceSegmentType.Trusted,
                _ => null,
            };
        }
    }
}