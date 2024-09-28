
#nullable enable

namespace Forem
{
    /// <summary>
    /// Access Forem articles, users and other resources via API.<br/>
    ///         For a real-world example of Forem in action, check out [DEV](https://www.dev.to).<br/>
    ///         All endpoints can be accessed with the 'api-key' header and a accept header, but<br/>
    ///         some of them are accessible publicly without authentication.<br/>
    ///         Dates and date times, unless otherwise specified, must be in<br/>
    ///         the [RFC 3339](https://tools.ietf.org/html/rfc3339) format.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class ForemClient : global::Forem.IForemClient, global::System.IDisposable
    {
        /// <summary>
        /// Production server
        /// </summary>
        public const string BaseUrl = "https://dev.to/api";

        private readonly global::System.Net.Http.HttpClient _httpClient;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::Forem.SourceGenerationContext.Default;


        /// <summary>
        /// 
        /// </summary>
        public ArticlesClient Articles => new ArticlesClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments => new CommentsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public DisplayAdsClient DisplayAds => new DisplayAdsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public FollowedTagsClient FollowedTags => new FollowedTagsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public TagsClient Tags => new TagsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public FollowersClient Followers => new FollowersClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PagesClient Pages => new PagesClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PodcastEpisodesClient PodcastEpisodes => new PodcastEpisodesClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProfileImagesClient ProfileImages => new ProfileImagesClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ReactionsClient Reactions => new ReactionsClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public ReadinglistClient Readinglist => new ReadinglistClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public VideosClient Videos => new VideosClient(_httpClient)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the ForemClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param> 
        public ForemClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}