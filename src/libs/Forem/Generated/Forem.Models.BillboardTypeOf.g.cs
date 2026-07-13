
#nullable enable

namespace Forem
{
    /// <summary>
    /// Types of the billboards:<br/>
    /// in_house (created by admins),<br/>
    /// community (created by an entity, appears on entity's content),<br/>
    /// external ( created by an entity, or a non-entity, can appear everywhere)<br/>
    /// Default Value: in_house
    /// </summary>
    public enum BillboardTypeOf
    {
        /// <summary>
        /// 
        /// </summary>
        Community,
        /// <summary>
        /// 
        /// </summary>
        External,
        /// <summary>
        /// 
        /// </summary>
        InHouse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillboardTypeOfExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillboardTypeOf value)
        {
            return value switch
            {
                BillboardTypeOf.Community => "community",
                BillboardTypeOf.External => "external",
                BillboardTypeOf.InHouse => "in_house",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillboardTypeOf? ToEnum(string value)
        {
            return value switch
            {
                "community" => BillboardTypeOf.Community,
                "external" => BillboardTypeOf.External,
                "in_house" => BillboardTypeOf.InHouse,
                _ => null,
            };
        }
    }
}