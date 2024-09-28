
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetArticlesState
    {
        /// <summary>
        /// 
        /// </summary>
        Fresh,
        /// <summary>
        /// 
        /// </summary>
        Rising,
        /// <summary>
        /// 
        /// </summary>
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetArticlesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetArticlesState value)
        {
            return value switch
            {
                GetArticlesState.Fresh => "fresh",
                GetArticlesState.Rising => "rising",
                GetArticlesState.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetArticlesState? ToEnum(string value)
        {
            return value switch
            {
                "fresh" => GetArticlesState.Fresh,
                "rising" => GetArticlesState.Rising,
                "all" => GetArticlesState.All,
                _ => null,
            };
        }
    }
}