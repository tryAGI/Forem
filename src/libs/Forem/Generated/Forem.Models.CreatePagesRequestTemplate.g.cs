
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
        Css,
        /// <summary>
        /// 
        /// </summary>
        FullWithinLayout,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        NavBarIncluded,
        /// <summary>
        /// 
        /// </summary>
        Txt,
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
                CreatePagesRequestTemplate.Css => "css",
                CreatePagesRequestTemplate.FullWithinLayout => "full_within_layout",
                CreatePagesRequestTemplate.Json => "json",
                CreatePagesRequestTemplate.NavBarIncluded => "nav_bar_included",
                CreatePagesRequestTemplate.Txt => "txt",
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
                "css" => CreatePagesRequestTemplate.Css,
                "full_within_layout" => CreatePagesRequestTemplate.FullWithinLayout,
                "json" => CreatePagesRequestTemplate.Json,
                "nav_bar_included" => CreatePagesRequestTemplate.NavBarIncluded,
                "txt" => CreatePagesRequestTemplate.Txt,
                _ => null,
            };
        }
    }
}