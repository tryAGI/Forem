
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateReactionsToggleCategory
    {
        /// <summary>
        /// 
        /// </summary>
        Like,
        /// <summary>
        /// 
        /// </summary>
        Unicorn,
        /// <summary>
        /// 
        /// </summary>
        ExplodingHead,
        /// <summary>
        /// 
        /// </summary>
        RaisedHands,
        /// <summary>
        /// 
        /// </summary>
        Fire,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateReactionsToggleCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReactionsToggleCategory value)
        {
            return value switch
            {
                CreateReactionsToggleCategory.Like => "like",
                CreateReactionsToggleCategory.Unicorn => "unicorn",
                CreateReactionsToggleCategory.ExplodingHead => "exploding_head",
                CreateReactionsToggleCategory.RaisedHands => "raised_hands",
                CreateReactionsToggleCategory.Fire => "fire",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReactionsToggleCategory? ToEnum(string value)
        {
            return value switch
            {
                "like" => CreateReactionsToggleCategory.Like,
                "unicorn" => CreateReactionsToggleCategory.Unicorn,
                "exploding_head" => CreateReactionsToggleCategory.ExplodingHead,
                "raised_hands" => CreateReactionsToggleCategory.RaisedHands,
                "fire" => CreateReactionsToggleCategory.Fire,
                _ => null,
            };
        }
    }
}