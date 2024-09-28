
#nullable enable

namespace Forem
{
    /// <summary>
    /// Controls what kind of layout the page is rendered in<br/>
    /// Default Value: contained
    /// </summary>
    public enum PageTemplate
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
    public static class PageTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PageTemplate value)
        {
            return value switch
            {
                PageTemplate.Contained => "contained",
                PageTemplate.FullWithinLayout => "full_within_layout",
                PageTemplate.NavBarIncluded => "nav_bar_included",
                PageTemplate.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PageTemplate? ToEnum(string value)
        {
            return value switch
            {
                "contained" => PageTemplate.Contained,
                "full_within_layout" => PageTemplate.FullWithinLayout,
                "nav_bar_included" => PageTemplate.NavBarIncluded,
                "json" => PageTemplate.Json,
                _ => null,
            };
        }
    }
}