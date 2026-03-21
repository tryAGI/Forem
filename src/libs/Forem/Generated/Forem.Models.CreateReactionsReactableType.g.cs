
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateReactionsReactableType
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
    public static class CreateReactionsReactableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReactionsReactableType value)
        {
            return value switch
            {
                CreateReactionsReactableType.Comment => "Comment",
                CreateReactionsReactableType.Article => "Article",
                CreateReactionsReactableType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReactionsReactableType? ToEnum(string value)
        {
            return value switch
            {
                "Comment" => CreateReactionsReactableType.Comment,
                "Article" => CreateReactionsReactableType.Article,
                "User" => CreateReactionsReactableType.User,
                _ => null,
            };
        }
    }
}