
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateReactionsToggleReactableType
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
    public static class CreateReactionsToggleReactableTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReactionsToggleReactableType value)
        {
            return value switch
            {
                CreateReactionsToggleReactableType.Comment => "Comment",
                CreateReactionsToggleReactableType.Article => "Article",
                CreateReactionsToggleReactableType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReactionsToggleReactableType? ToEnum(string value)
        {
            return value switch
            {
                "Comment" => CreateReactionsToggleReactableType.Comment,
                "Article" => CreateReactionsToggleReactableType.Article,
                "User" => CreateReactionsToggleReactableType.User,
                _ => null,
            };
        }
    }
}