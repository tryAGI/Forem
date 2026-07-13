
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutAdminUsersNotificationSettingsRequestNotificationSetting
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_newsletter")]
        public bool? EmailNewsletter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminUsersNotificationSettingsRequestNotificationSetting" /> class.
        /// </summary>
        /// <param name="emailNewsletter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutAdminUsersNotificationSettingsRequestNotificationSetting(
            bool? emailNewsletter)
        {
            this.EmailNewsletter = emailNewsletter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminUsersNotificationSettingsRequestNotificationSetting" /> class.
        /// </summary>
        public PutAdminUsersNotificationSettingsRequestNotificationSetting()
        {
        }

    }
}