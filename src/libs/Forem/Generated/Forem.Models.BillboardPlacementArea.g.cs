
#nullable enable

namespace Forem
{
    /// <summary>
    /// Identifies which area of site layout the ad can appear in
    /// </summary>
    public enum BillboardPlacementArea
    {
        /// <summary>
        /// 
        /// </summary>
        DigestFirst,
        /// <summary>
        /// 
        /// </summary>
        DigestSecond,
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
        Footer,
        /// <summary>
        /// 
        /// </summary>
        HomeHero,
        /// <summary>
        /// 
        /// </summary>
        PageFixedBottom,
        /// <summary>
        /// 
        /// </summary>
        PostBodyBottom,
        /// <summary>
        /// 
        /// </summary>
        PostComments,
        /// <summary>
        /// 
        /// </summary>
        PostCommentsMid,
        /// <summary>
        /// 
        /// </summary>
        PostFixedBottom,
        /// <summary>
        /// 
        /// </summary>
        PostSidebar,
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
        SidebarRightSecond,
        /// <summary>
        /// 
        /// </summary>
        SidebarRightThird,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BillboardPlacementAreaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BillboardPlacementArea value)
        {
            return value switch
            {
                BillboardPlacementArea.DigestFirst => "digest_first",
                BillboardPlacementArea.DigestSecond => "digest_second",
                BillboardPlacementArea.FeedFirst => "feed_first",
                BillboardPlacementArea.FeedSecond => "feed_second",
                BillboardPlacementArea.FeedThird => "feed_third",
                BillboardPlacementArea.Footer => "footer",
                BillboardPlacementArea.HomeHero => "home_hero",
                BillboardPlacementArea.PageFixedBottom => "page_fixed_bottom",
                BillboardPlacementArea.PostBodyBottom => "post_body_bottom",
                BillboardPlacementArea.PostComments => "post_comments",
                BillboardPlacementArea.PostCommentsMid => "post_comments_mid",
                BillboardPlacementArea.PostFixedBottom => "post_fixed_bottom",
                BillboardPlacementArea.PostSidebar => "post_sidebar",
                BillboardPlacementArea.SidebarLeft => "sidebar_left",
                BillboardPlacementArea.SidebarLeft2 => "sidebar_left_2",
                BillboardPlacementArea.SidebarRight => "sidebar_right",
                BillboardPlacementArea.SidebarRightSecond => "sidebar_right_second",
                BillboardPlacementArea.SidebarRightThird => "sidebar_right_third",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BillboardPlacementArea? ToEnum(string value)
        {
            return value switch
            {
                "digest_first" => BillboardPlacementArea.DigestFirst,
                "digest_second" => BillboardPlacementArea.DigestSecond,
                "feed_first" => BillboardPlacementArea.FeedFirst,
                "feed_second" => BillboardPlacementArea.FeedSecond,
                "feed_third" => BillboardPlacementArea.FeedThird,
                "footer" => BillboardPlacementArea.Footer,
                "home_hero" => BillboardPlacementArea.HomeHero,
                "page_fixed_bottom" => BillboardPlacementArea.PageFixedBottom,
                "post_body_bottom" => BillboardPlacementArea.PostBodyBottom,
                "post_comments" => BillboardPlacementArea.PostComments,
                "post_comments_mid" => BillboardPlacementArea.PostCommentsMid,
                "post_fixed_bottom" => BillboardPlacementArea.PostFixedBottom,
                "post_sidebar" => BillboardPlacementArea.PostSidebar,
                "sidebar_left" => BillboardPlacementArea.SidebarLeft,
                "sidebar_left_2" => BillboardPlacementArea.SidebarLeft2,
                "sidebar_right" => BillboardPlacementArea.SidebarRight,
                "sidebar_right_second" => BillboardPlacementArea.SidebarRightSecond,
                "sidebar_right_third" => BillboardPlacementArea.SidebarRightThird,
                _ => null,
            };
        }
    }
}