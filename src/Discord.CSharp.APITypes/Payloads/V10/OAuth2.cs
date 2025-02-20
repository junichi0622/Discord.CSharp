

namespace Discord.CSharp.APITypes.Payloads
{   
    /// <summary>
    /// https://discord.com/developers/docs/topics/oauth2
    /// </summary>
    public static class OAuth2Scopes
    {
        /// <summary>
        /// Allows your app to fetch data from a user's "Now Playing/Recently Played" list — not currently available for apps
        /// </summary>
        public const string ActivitiesRead = "activities.read";
        /// <summary>
        /// Allows your app to update a user's activity - not currently available for apps (NOT REQUIRED FOR <see href="https://discord.com/developers/docs/developer-tools/game-sdk#activities">GAMESDK ACTIVITY MANAGER)</see>
        /// </summary>
        public const string ActivitiesWrite = "activities.write";
        /// <summary>
        /// Allows your app to read build data for a user's applications
        /// </summary>
        public const string ApplicationsBuildsRead = "applications.builds.read";
        /// <summary>
        /// Allows your app to upload/update builds for a user's applications - requires Discord approval
        /// </summary>
        public const string ApplicationsBuildsUpload = "applications.builds.upload";
        /// <summary>
        /// Allows your app to add <see href="https://discord.com/developers/docs/interactions/application-commands">commands</see> to a guild - included by default with the <c>bot</c> scope
        /// </summary>
        public const string ApplicationsCommands = "applications.commands";
        /// <summary>
        /// Allows your app to update its <see href="https://discord.com/developers/docs/interactions/application-commands">commands</see> using a Bearer token - <see href="https://discord.com/developers/docs/topics/oauth2#client-credentials-grant">client credentials grant</see> only
        /// </summary>
        public const string ApplicationsCommandsUpdate = "applications.commands.update";
        /// <summary>
        /// Allows your app to update <see href="https://discord.com/developers/docs/interactions/application-commands#permissions">permissions for its commands</see> in a guild a user has permissions to
        /// </summary>
        public const string ApplicationsCommandsPermissionsUpdate = "applications.commands.permissions.update";
        /// <summary>
        /// Allows your app to read entitlements for a user's applications
        /// </summary>
        public const string ApplicationsEntitlements = "applications.entitlements";
        /// <summary>
        /// Allows your app to read and update store data (SKUs, store listings, achievements, etc.) for a user's applications
        /// </summary>
        public const string ApplicationsStoreUpdate = "applications.store.update";
        /// <summary>
        /// For oauth2 bots, this puts the bot in the user's selected guild by default
        /// </summary>
        public const string Bot = "bot";
        /// <summary>
        /// Allows <see href="https://discord.com/developers/docs/resources/user#get-current-user-connections">/users/@me/connections</see> to return linked third-party accounts
        /// </summary>
        public const string Connections = "connections";
        /// <summary>
        /// Allows your app to see information about the user's DMs and group DMs - requires Discord approval
        /// </summary>
        public const string DMChannelsRead = "dm_channels.read";
        /// <summary>
        /// Enables <see href="https://discord.com/developers/docs/resources/user#get-current-user">/users/@me</see> to return an <c>email</c>
        /// </summary>
        public const string Email = "email";
        /// <summary>
        /// Allows your app to <see href="https://discord.com/developers/docs/resources/channel#group-dm-add-recipient">join users to a group dm</see>
        /// </summary>
        public const string GDMJoin = "gdm.join";
        /// <summary>
        /// Allows <see href="https://discord.com/developers/docs/resources/user#get-current-user-guilds">/users/@me/guilds</see> to return basic information about all of a user's guilds
        /// </summary>
        public const string Guilds = "guilds";
        /// <summary>
        /// Allows <see href="https://discord.com/developers/docs/resources/guild#add-guild-member">/guilds/{guild.id}/members/{user.id}</see> to be used for joining users to a guild
        /// </summary>
        public const string GuildsJoin = "guilds.join";
        /// <summary>
        /// Allows <see href="https://discord.com/developers/docs/resources/user#get-current-user-guild-member">/users/@me/guilds/{guild.id}/member</see> to return a user's member information in a guild
        /// </summary>
        public const string GuildsMembersRead = "guilds.members.read";
        /// <summary>
        /// Allows <see href="https://discord.com/developers/docs/resources/user#get-current-user">/users/@me</see> without <c>email</c>
        /// </summary>
        public const string Identify = "identify";
        /// <summary>
        /// For local rpc server api access, this allows you to read messages from all client channels (otherwise restricted to channels/guilds your app creates)
        /// </summary>
        public const string MessagesRead = "messages.read";
        /// <summary>
        /// Allows your app to know a user's friends and implicit relationships - requires Discord approval
        /// </summary>
        public const string RelationshipsRead = "relationships.read";
        /// <summary>
        /// Allows your app to update a user's connection and metadata for the app
        /// </summary>
        public const string RoleConnectionsWrite = "role_connections.write";
        /// <summary>
        /// For local rpc server access, this allows you to control a user's local Discord client - requires Discord approval
        /// </summary>
        public const string RPC = "rpc";
        /// <summary>
        /// For local rpc server access, this allows you to update a user's activity - requires Discord approval
        /// </summary>
        public const string RPCActivitiesWrite = "rpc.activities.write";
        /// <summary>
        /// For local rpc server access, this allows you to receive notifications pushed out to the user - requires Discord approval
        /// </summary>
        public const string RPCNotificationsRead = "rpc.notifications.read";
        /// <summary>
        /// For local rpc server access, this allows you to read a user's voice settings and listen for voice events - requires Discord approval
        /// </summary>
        public const string RPCVoiceRead = "rpc.voice.read";
        /// <summary>
        /// For local rpc server access, this allows you to update a user's voice settings - requires Discord approval
        /// </summary>
        public const string RPCVoiceWrite = "rpc.voice.write";
        /// <summary>
        /// Allows your app to connect to voice on user's behalf and see all the voice members - requires Discord approval
        /// </summary>
        public const string Voice = "voice";
        /// <summary>
        /// This generates a webhook that is returned in the oauth token response for authorization code grants
        /// </summary>
        public const string WebhookIncoming = "webhook.incoming";
    }
}