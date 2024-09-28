
#nullable enable

namespace Forem
{
    /// <summary>
    /// Identifies which area of site layout the ad can appear in
    /// </summary>
    public enum DisplayAdPlacementArea
    {
        /// <summary>
        /// 
        /// </summary>
        SidebarLeft,
        /// <summary>
        /// 
        /// </summary>
        SidebarLeft2,
        /// <summary>
        /// 
        /// </summary>
        SidebarRight,
        /// <summary>
        /// 
        /// </summary>
        FeedFirst,
        /// <summary>
        /// 
        /// </summary>
        FeedSecond,
        /// <summary>
        /// 
        /// </summary>
        FeedThird,
        /// <summary>
        /// 
        /// </summary>
        PostSidebar,
        /// <summary>
        /// 
        /// </summary>
        PostComments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DisplayAdPlacementAreaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DisplayAdPlacementArea value)
        {
            return value switch
            {
                DisplayAdPlacementArea.SidebarLeft => "sidebar_left",
                DisplayAdPlacementArea.SidebarLeft2 => "sidebar_left_2",
                DisplayAdPlacementArea.SidebarRight => "sidebar_right",
                DisplayAdPlacementArea.FeedFirst => "feed_first",
                DisplayAdPlacementArea.FeedSecond => "feed_second",
                DisplayAdPlacementArea.FeedThird => "feed_third",
                DisplayAdPlacementArea.PostSidebar => "post_sidebar",
                DisplayAdPlacementArea.PostComments => "post_comments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DisplayAdPlacementArea? ToEnum(string value)
        {
            return value switch
            {
                "sidebar_left" => DisplayAdPlacementArea.SidebarLeft,
                "sidebar_left_2" => DisplayAdPlacementArea.SidebarLeft2,
                "sidebar_right" => DisplayAdPlacementArea.SidebarRight,
                "feed_first" => DisplayAdPlacementArea.FeedFirst,
                "feed_second" => DisplayAdPlacementArea.FeedSecond,
                "feed_third" => DisplayAdPlacementArea.FeedThird,
                "post_sidebar" => DisplayAdPlacementArea.PostSidebar,
                "post_comments" => DisplayAdPlacementArea.PostComments,
                _ => null,
            };
        }
    }
}