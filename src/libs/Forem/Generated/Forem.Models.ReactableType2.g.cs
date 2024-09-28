
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactableType2
    {
        /// <summary>
        /// 
        /// </summary>
        Comment,
        /// <summary>
        /// 
        /// </summary>
        Article,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReactableType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactableType2 value)
        {
            return value switch
            {
                ReactableType2.Comment => "Comment",
                ReactableType2.Article => "Article",
                ReactableType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactableType2? ToEnum(string value)
        {
            return value switch
            {
                "Comment" => ReactableType2.Comment,
                "Article" => ReactableType2.Article,
                "User" => ReactableType2.User,
                _ => null,
            };
        }
    }
}