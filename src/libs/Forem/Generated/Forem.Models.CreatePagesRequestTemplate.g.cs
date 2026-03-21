
#nullable enable

namespace Forem
{
    /// <summary>
    /// Controls what kind of layout the page is rendered in<br/>
    /// Default Value: contained
    /// </summary>
    public enum CreatePagesRequestTemplate
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
    public static class CreatePagesRequestTemplateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreatePagesRequestTemplate value)
        {
            return value switch
            {
                CreatePagesRequestTemplate.Contained => "contained",
                CreatePagesRequestTemplate.FullWithinLayout => "full_within_layout",
                CreatePagesRequestTemplate.NavBarIncluded => "nav_bar_included",
                CreatePagesRequestTemplate.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreatePagesRequestTemplate? ToEnum(string value)
        {
            return value switch
            {
                "contained" => CreatePagesRequestTemplate.Contained,
                "full_within_layout" => CreatePagesRequestTemplate.FullWithinLayout,
                "nav_bar_included" => CreatePagesRequestTemplate.NavBarIncluded,
                "json" => CreatePagesRequestTemplate.Json,
                _ => null,
            };
        }
    }
}