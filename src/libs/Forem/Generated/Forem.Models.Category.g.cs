
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public enum Category
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
    public static class CategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Category value)
        {
            return value switch
            {
                Category.Like => "like",
                Category.Unicorn => "unicorn",
                Category.ExplodingHead => "exploding_head",
                Category.RaisedHands => "raised_hands",
                Category.Fire => "fire",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Category? ToEnum(string value)
        {
            return value switch
            {
                "like" => Category.Like,
                "unicorn" => Category.Unicorn,
                "exploding_head" => Category.ExplodingHead,
                "raised_hands" => Category.RaisedHands,
                "fire" => Category.Fire,
                _ => null,
            };
        }
    }
}