
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateReactionsCategory
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
    public static class CreateReactionsCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateReactionsCategory value)
        {
            return value switch
            {
                CreateReactionsCategory.Like => "like",
                CreateReactionsCategory.Unicorn => "unicorn",
                CreateReactionsCategory.ExplodingHead => "exploding_head",
                CreateReactionsCategory.RaisedHands => "raised_hands",
                CreateReactionsCategory.Fire => "fire",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateReactionsCategory? ToEnum(string value)
        {
            return value switch
            {
                "like" => CreateReactionsCategory.Like,
                "unicorn" => CreateReactionsCategory.Unicorn,
                "exploding_head" => CreateReactionsCategory.ExplodingHead,
                "raised_hands" => CreateReactionsCategory.RaisedHands,
                "fire" => CreateReactionsCategory.Fire,
                _ => null,
            };
        }
    }
}