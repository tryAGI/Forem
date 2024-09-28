
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public enum Category2
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
    public static class Category2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Category2 value)
        {
            return value switch
            {
                Category2.Like => "like",
                Category2.Unicorn => "unicorn",
                Category2.ExplodingHead => "exploding_head",
                Category2.RaisedHands => "raised_hands",
                Category2.Fire => "fire",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Category2? ToEnum(string value)
        {
            return value switch
            {
                "like" => Category2.Like,
                "unicorn" => Category2.Unicorn,
                "exploding_head" => Category2.ExplodingHead,
                "raised_hands" => Category2.RaisedHands,
                "fire" => Category2.Fire,
                _ => null,
            };
        }
    }
}