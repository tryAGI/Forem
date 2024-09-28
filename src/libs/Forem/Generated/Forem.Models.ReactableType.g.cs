
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReactableType
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
    public static class ReactableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReactableType value)
        {
            return value switch
            {
                ReactableType.Comment => "Comment",
                ReactableType.Article => "Article",
                ReactableType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReactableType? ToEnum(string value)
        {
            return value switch
            {
                "Comment" => ReactableType.Comment,
                "Article" => ReactableType.Article,
                "User" => ReactableType.User,
                _ => null,
            };
        }
    }
}