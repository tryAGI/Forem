
#nullable enable

namespace Forem
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PutAdminUsersNotificationSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Forem.PutAdminUsersNotificationSettingsRequestNotificationSetting NotificationSetting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminUsersNotificationSettingsRequest" /> class.
        /// </summary>
        /// <param name="notificationSetting"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PutAdminUsersNotificationSettingsRequest(
            global::Forem.PutAdminUsersNotificationSettingsRequestNotificationSetting notificationSetting)
        {
            this.NotificationSetting = notificationSetting ?? throw new global::System.ArgumentNullException(nameof(notificationSetting));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutAdminUsersNotificationSettingsRequest" /> class.
        /// </summary>
        public PutAdminUsersNotificationSettingsRequest()
        {
        }

    }
}