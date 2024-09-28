
#nullable enable

namespace Forem
{
    /// <summary>
    /// Controls what kind of layout the page is rendered in<br/>
    /// Default Value: contained
    /// </summary>
    public enum RequestTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        Contained,
        /// <summary>
        /// 
        /// </summary>
        FullWithinLayout,
        /// <summary>
        /// 
        /// </summary>
        NavBarIncluded,
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestTemplate value)
        {
            return value switch
            {
                RequestTemplate.Contained => "contained",
                RequestTemplate.FullWithinLayout => "full_within_layout",
                RequestTemplate.NavBarIncluded => "nav_bar_included",
                RequestTemplate.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestTemplate? ToEnum(string value)
        {
            return value switch
            {
                "contained" => RequestTemplate.Contained,
                "full_within_layout" => RequestTemplate.FullWithinLayout,
                "nav_bar_included" => RequestTemplate.NavBarIncluded,
                "json" => RequestTemplate.Json,
                _ => null,
            };
        }
    }
}