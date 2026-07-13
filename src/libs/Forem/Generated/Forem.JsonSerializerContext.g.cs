
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

            typeof(global::Forem.JsonConverters.BillboardPlacementAreaJsonConverter),

            typeof(global::Forem.JsonConverters.BillboardPlacementAreaNullableJsonConverter),

            typeof(global::Forem.JsonConverters.BillboardAudienceSegmentTypeJsonConverter),

            typeof(global::Forem.JsonConverters.BillboardAudienceSegmentTypeNullableJsonConverter),

            typeof(global::Forem.JsonConverters.BillboardDisplayToJsonConverter),

            typeof(global::Forem.JsonConverters.BillboardDisplayToNullableJsonConverter),

            typeof(global::Forem.JsonConverters.BillboardTypeOfJsonConverter),

            typeof(global::Forem.JsonConverters.BillboardTypeOfNullableJsonConverter),

            typeof(global::Forem.JsonConverters.SegmentTypeOfJsonConverter),

            typeof(global::Forem.JsonConverters.SegmentTypeOfNullableJsonConverter),

            typeof(global::Forem.JsonConverters.PollOptionTypeOfJsonConverter),

            typeof(global::Forem.JsonConverters.PollOptionTypeOfNullableJsonConverter),

            typeof(global::Forem.JsonConverters.PollTypeOfJsonConverter),

            typeof(global::Forem.JsonConverters.PollTypeOfNullableJsonConverter),

            typeof(global::Forem.JsonConverters.PollPollTypeOfJsonConverter),

            typeof(global::Forem.JsonConverters.PollPollTypeOfNullableJsonConverter),

            typeof(global::Forem.JsonConverters.SurveyTypeOfJsonConverter),

            typeof(global::Forem.JsonConverters.SurveyTypeOfNullableJsonConverter),

            typeof(global::Forem.JsonConverters.SurveySurveyTypeOfJsonConverter),

            typeof(global::Forem.JsonConverters.SurveySurveyTypeOfNullableJsonConverter),

            typeof(global::Forem.JsonConverters.PollVoteTypeOfJsonConverter),

            typeof(global::Forem.JsonConverters.PollVoteTypeOfNullableJsonConverter),

            typeof(global::Forem.JsonConverters.PollTextResponseTypeOfJsonConverter),

            typeof(global::Forem.JsonConverters.PollTextResponseTypeOfNullableJsonConverter),

            typeof(global::Forem.JsonConverters.CreateAgentSessionRequestToolNameJsonConverter),

            typeof(global::Forem.JsonConverters.CreateAgentSessionRequestToolNameNullableJsonConverter),

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

            typeof(global::Forem.JsonConverters.SurveyWithPollsJsonConverter),

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.ExtendedUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.MyUser))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Comment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.UserInviteParam))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Billboard))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.BillboardPlacementArea), TypeInfoPropertyName = "BillboardPlacementArea2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.BillboardAudienceSegmentType), TypeInfoPropertyName = "BillboardAudienceSegmentType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.BillboardDisplayTo), TypeInfoPropertyName = "BillboardDisplayTo2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.BillboardTypeOf), TypeInfoPropertyName = "BillboardTypeOf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Segment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.SegmentTypeOf), TypeInfoPropertyName = "SegmentTypeOf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.SegmentUserIds))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.AgentSessionIndex))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.AgentSessionShow))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PollOption))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PollOptionTypeOf), TypeInfoPropertyName = "PollOptionTypeOf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Poll))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PollTypeOf), TypeInfoPropertyName = "PollTypeOf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PollPollTypeOf), TypeInfoPropertyName = "PollPollTypeOf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.PollOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Survey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.SurveyTypeOf), TypeInfoPropertyName = "SurveyTypeOf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.SurveySurveyTypeOf), TypeInfoPropertyName = "SurveySurveyTypeOf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.SurveyWithPolls), TypeInfoPropertyName = "SurveyWithPolls2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.SurveyWithPollsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Poll>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PollVote))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PollVoteTypeOf), TypeInfoPropertyName = "PollVoteTypeOf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PollTextResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PollTextResponseTypeOf), TypeInfoPropertyName = "PollTextResponseTypeOf2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Trend))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Concept))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.ConceptDailyMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.ConceptDailyMetric))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.ConceptTopArticle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.ConceptTopArticle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.RequestRedirect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Badge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.BadgeBadgeImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.BadgeAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.RecommendedArticlesList))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.Subforem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAgentSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAgentSessionRequestToolName), TypeInfoPropertyName = "CreateAgentSessionRequestToolName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateBadgeAchievementsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateBadgeAchievementsRequestBadgeAchievement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateBadgesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateBadgesRequestBadge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchBadgesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchBadgesRequestBadge))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchConceptsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchConceptsRequestConcept))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAdminConceptsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAdminConceptsRequestConcept))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchAdminConceptsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchAdminConceptsRequestConcept))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAdminConceptsTriggerLookbackRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchFeedbackMessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchFeedbackMessagesRequestFeedbackMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateFollowsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreatePagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreatePagesRequestTemplate), TypeInfoPropertyName = "CreatePagesRequestTemplate2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateRecommendedArticlesListsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchRecommendedArticlesListsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAdminRequestRedirectsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAdminRequestRedirectsRequestRequestRedirect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchAdminRequestRedirectsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchAdminRequestRedirectsRequestRequestRedirect))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PatchAdminUsersRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PutAdminUsersEmailRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PutAdminUsersStatusRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PutAdminUsersNotificationSettingsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.PutAdminUsersNotificationSettingsRequestNotificationSetting))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAdminUsersMergeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAdminUsersNotesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAdminUsersIdentitiesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAdminUsersIdentitiesBulkRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.CreateAdminUsersIdentitiesBulkRequestIdentitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateAdminUsersIdentitiesBulkRequestIdentitie))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.GetArticlesState), TypeInfoPropertyName = "GetArticlesState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateReactionsToggleCategory), TypeInfoPropertyName = "CreateReactionsToggleCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateReactionsToggleReactableType), TypeInfoPropertyName = "CreateReactionsToggleReactableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateReactionsCategory), TypeInfoPropertyName = "CreateReactionsCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateReactionsReactableType), TypeInfoPropertyName = "CreateReactionsReactableType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.AgentSessionIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.ArticleIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Segment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.BadgeAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Badge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Billboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Concept>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.FollowedTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.GetFollowersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.GetFollowersResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Forem.CreateFollowsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Page>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.PodcastEpisodeIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.RecommendedArticlesList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.RequestRedirect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Subforem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Survey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.PollVote>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.PollTextResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Tag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.Trend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Forem.VideoArticle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.PollOption>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Poll>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.ConceptDailyMetric>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.ConceptTopArticle>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.CreateAdminUsersIdentitiesBulkRequestIdentitie>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.AgentSessionIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.ArticleIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Segment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.User>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.BadgeAchievement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Badge>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Billboard>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Comment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Concept>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.FollowedTag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.GetFollowersResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Organization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Page>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.PodcastEpisodeIndex>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.RecommendedArticlesList>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.RequestRedirect>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Subforem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Survey>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.PollVote>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.PollTextResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Tag>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.Trend>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Forem.VideoArticle>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}