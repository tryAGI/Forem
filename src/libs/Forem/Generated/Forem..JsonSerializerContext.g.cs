
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Forem.JsonConverters.PageTemplateJsonConverter),

            typeof(global::Forem.JsonConverters.PageTemplateNullableJsonConverter),

            typeof(global::Forem.JsonConverters.DisplayAdPlacementAreaJsonConverter),

            typeof(global::Forem.JsonConverters.DisplayAdPlacementAreaNullableJsonConverter),

            typeof(global::Forem.JsonConverters.DisplayAdAudienceSegmentTypeJsonConverter),

            typeof(global::Forem.JsonConverters.DisplayAdAudienceSegmentTypeNullableJsonConverter),

            typeof(global::Forem.JsonConverters.DisplayAdDisplayToJsonConverter),

            typeof(global::Forem.JsonConverters.DisplayAdDisplayToNullableJsonConverter),

            typeof(global::Forem.JsonConverters.DisplayAdTypeOfJsonConverter),

            typeof(global::Forem.JsonConverters.DisplayAdTypeOfNullableJsonConverter),

            typeof(global::Forem.JsonConverters.CreatePagesRequestTemplateJsonConverter),

            typeof(global::Forem.JsonConverters.CreatePagesRequestTemplateNullableJsonConverter),

            typeof(global::Forem.JsonConverters.GetArticlesStateJsonConverter),

            typeof(global::Forem.JsonConverters.GetArticlesStateNullableJsonConverter),

            typeof(global::Forem.JsonConverters.CreateReactionsToggleCategoryJsonConverter),

            typeof(global::Forem.JsonConverters.CreateReactionsToggleCategoryNullableJsonConverter),

            typeof(global::Forem.JsonConverters.CreateReactionsToggleReactableTypeJsonConverter),

            typeof(global::Forem.JsonConverters.CreateReactionsToggleReactableTypeNullableJsonConverter),

            typeof(global::Forem.JsonConverters.CreateReactionsCategoryJsonConverter),

            typeof(global::Forem.JsonConverters.CreateReactionsCategoryNullableJsonConverter),

            typeof(global::Forem.JsonConverters.CreateReactionsReactableTypeJsonConverter),

            typeof(global::Forem.JsonConverters.CreateReactionsReactableTypeNullableJsonConverter),

            typeof(global::Forem.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.ArticleFlareTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.ArticleIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.SharedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.SharedOrganization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.VideoArticle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.VideoArticleUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Article))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.ArticleArticle1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Organization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.FollowedTag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Tag))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Page))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PageTemplate), TypeInfoPropertyName = "PageTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PodcastEpisodeIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.SharedPodcast))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.ProfileImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.User))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.UserInviteParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.DisplayAd))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.DisplayAdPlacementArea), TypeInfoPropertyName = "DisplayAdPlacementArea2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.DisplayAdAudienceSegmentType), TypeInfoPropertyName = "DisplayAdAudienceSegmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.DisplayAdDisplayTo), TypeInfoPropertyName = "DisplayAdDisplayTo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.DisplayAdTypeOf), TypeInfoPropertyName = "DisplayAdTypeOf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreatePagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreatePagesRequestTemplate), TypeInfoPropertyName = "CreatePagesRequestTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.GetArticlesState), TypeInfoPropertyName = "GetArticlesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateReactionsToggleCategory), TypeInfoPropertyName = "CreateReactionsToggleCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateReactionsToggleReactableType), TypeInfoPropertyName = "CreateReactionsToggleReactableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateReactionsCategory), TypeInfoPropertyName = "CreateReactionsCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateReactionsReactableType), TypeInfoPropertyName = "CreateReactionsReactableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.ArticleIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.DisplayAd>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.FollowedTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.GetFollowersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.GetFollowersResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Page>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.PodcastEpisodeIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Tag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.VideoArticle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.ArticleIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.DisplayAd>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.FollowedTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.GetFollowersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Page>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.PodcastEpisodeIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Tag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.VideoArticle>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}