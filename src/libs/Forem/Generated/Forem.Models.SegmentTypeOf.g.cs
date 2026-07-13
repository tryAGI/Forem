
#nullable enable

namespace Forem
{
    /// <summary>
    /// Marks the segment as manually managed (other types are internal)<br/>
    /// Default Value: manual
    /// </summary>
    public enum SegmentTypeOf
    {
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SegmentTypeOfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SegmentTypeOf value)
        {
            return value switch
            {
                SegmentTypeOf.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SegmentTypeOf? ToEnum(string value)
        {
            return value switch
            {
                "manual" => SegmentTypeOf.Manual,
                _ => null,
            };
        }
    }
}