
#nullable enable

namespace Forem
{
    /// <summary>
    /// Potentially limits visitors to whom the ad is visible<br/>
    /// Default Value: all
    /// </summary>
    public enum BillboardDisplayTo
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        LoggedIn,
        /// <summary>
        /// 
        /// </summary>
        LoggedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillboardDisplayToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillboardDisplayTo value)
        {
            return value switch
            {
                BillboardDisplayTo.All => "all",
                BillboardDisplayTo.LoggedIn => "logged_in",
                BillboardDisplayTo.LoggedOut => "logged_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillboardDisplayTo? ToEnum(string value)
        {
            return value switch
            {
                "all" => BillboardDisplayTo.All,
                "logged_in" => BillboardDisplayTo.LoggedIn,
                "logged_out" => BillboardDisplayTo.LoggedOut,
                _ => null,
            };
        }
    }
}