// Types extracted from https://discord.com/developers/docs/resources/user

using System.Runtime.Serialization;

namespace Discord.CSharp.APITypes.Payloads
{
    /// <summary>
    /// https://discord.com/developers/docs/resources/user#user-object-user-structure
    /// </summary>
    public class UserStructure
    {
        /// <summary>
        /// The user's id
        /// </summary>
        public required Snowflake Id { get; set; }
        /// <summary>
        /// The user's username, not unique across the platform
        /// </summary>
        public required string Username { get; set; }
        /// <summary>
        /// The user's Discord-tag
        /// </summary>
        public required string Discriminator { get; set; }
        /// <summary>
        /// The user's display name, if it is set. For bots, this is the application name
        /// </summary>
        public string? GlobalName { get; set; }
        /// <summary>
        /// The user's <see href="https://discord.com/developers/docs/reference#image-formatting">avatar hash</see>
        /// </summary>
        public string? Avatar { get; set; }
        /// <summary>
        /// Whether the user belongs to an OAuth2 application
        /// </summary>
        public bool? Bot { get; set; }
        /// <summary>
        /// Whether the user is an Official Discord System user (part of the urgent message system)
        /// </summary>
        public bool? System { get; set; }
        /// <summary>
        /// Whether the user has two factor enabled on their account
        /// </summary>
        public bool? MFAEnabled { get; set; }
        /// <summary>
        /// The user's <see href="https://discord.com/developers/docs/reference#image-formatting">banner hash</see>
        /// </summary>
        public string? Banner { get; set; }
        /// <summary>
        /// The user's banner color encoded as an integer representation of hexadecimal color code
        /// </summary>
        public int? AccentColor { get; set; }
        /// <summary>
        /// The user's chosen <see href="https://discord.com/developers/docs/reference#locales">language option</see>
        /// </summary>
        public string? Locale { get; set; }
        /// <summary>
        /// Whether the email on this account has been verified
        /// </summary>
        public bool? Verified { get; set; }
        /// <summary>
        /// The user's email
        /// </summary>
        public string? Email { get; set; }
        /// <summary>
        /// The flags on a <see href="https://discord.com/developers/docs/resources/user#user-object-user-flags">user's account</see>
        /// </summary>
        public UserFlags? Flags { get; set; }
        /// <summary>
        /// The <see href="https://discord.com/developers/docs/resources/user#user-object-premium-types">type of Nitro subscription</see> on a user's account
        /// </summary>
        public PremiumTypes? PremiumType { get; set; }
        /// <summary>
        /// The public <see href="https://discord.com/developers/docs/resources/user#user-object-user-flags">flags</see> on a user's account
        /// </summary>
        public UserFlags? PublicFlags { get; set; }
        /// <summary>
        /// Data for the user's avatar decoration
        /// </summary>
        public AvatarDecorationDataStructure? AvatarDecorationData { get; set; }
    }

    /// <summary>
    /// https://discord.com/developers/docs/resources/user#user-object-user-flags
    /// </summary>
    [Flags]
    public enum UserFlags
    {
        /// <summary>
        /// Discord Employee
        /// </summary>
        Staff = 1 << 0,
        /// <summary>
        /// Partnered Server Owner
        /// </summary>
        Partner = 1 << 1,
        /// <summary>
        /// HypeSquad Events Member
        /// </summary>
        Hypesquad = 1 << 2,
        /// <summary>
        /// Bug Hunter Level 1
        /// </summary>
        BugHunterLevel1 = 1 << 3,
        /// <summary>
        /// House Bravery Member
        /// </summary>
        HypesquadOnlineHouse1 = 1 << 6,
        /// <summary>
        /// House Brilliance Member
        /// </summary>
        HypesquadOnlineHouse2 = 1 << 7,
        /// <summary>
        /// House Balance Member
        /// </summary>
        HypesquadOnlineHouse3 = 1 << 8,
        /// <summary>
        /// Early Nitro Supporter
        /// </summary>
        PremiumEarlySupporter = 1 << 9,
        /// <summary>
        /// User is a <see href="https://discord.com/developers/docs/topics/teams">team</see>
        /// </summary>
        TeamPseudoUser = 1 << 10,
        /// <summary>
        /// Bug Hunter Level 2
        /// </summary>
        BugHunterLevel2 = 1 << 14,
        /// <summary>
        /// Verified Bot
        /// </summary>
        VerifiedBot = 1 << 16,
        /// <summary>
        /// Early Verified Bot Developer
        /// </summary>
        VerifiedDeveloper = 1 << 17,
        /// <summary>
        /// Moderator Programs Alumni
        /// </summary>
        CertifiedModerator = 1 << 18,
        /// <summary>
        /// Bot uses only <see href="https://discord.com/developers/docs/interactions/receiving-and-responding#receiving-an-interaction">HTTP interactions</see> and is shown in the online member lis
        /// </summary>
        BotHTTPInteractions = 1 << 19,
        /// <summary>
        /// User is an <see href="https://support-dev.discord.com/hc/articles/10113997751447">Active Developer</see>
        /// </summary>
        ActiveDeveloper = 1 << 22,
    }

    /// <summary>
    /// https://discord.com/developers/docs/resources/user#user-object-premium-types
    /// </summary>
    public enum PremiumTypes
    {
        None,
        NitroClassic,
        Nitro,
        NitroBasic,
    }

    /// <summary>
    /// https://discord.com/developers/docs/resources/user#avatar-decoration-data-object-avatar-decoration-data-structure
    /// </summary>
    public class AvatarDecorationDataStructure
    {
        /// <summary>
        /// the <see href="https://discord.com/developers/docs/reference#image-formatting">avatar decoration hash</see>
        /// </summary>
        public string? Asset { get; set; }
        /// <summary>
        /// ID of the avatar decoration's SKU
        /// </summary>
        public string? SKUId { get; set; }
    }
    
    /// <summary>
    /// https://discord.com/developers/docs/resources/user#connection-object-connection-structure
    /// </summary>
    public class ConnectionStructure
    {
        /// <summary>
        /// ID of the connection account
        /// </summary>
        public required string Id { get; set; }
        /// <summary>
        /// The username of the connection account
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// The <see href="https://discord.com/developers/docs/resources/user#connection-object-services">service</see> of this connection
        /// </summary>
        public Services? Type { get; set; }
        /// <summary>
        /// Whether the connection is revoked
        /// </summary>
        public bool? Revoked { get; set; }
        /// <summary>
        /// An array of partial <see href="https://discord.com/developers/docs/resources/guild#integration-object">server integrations</see>
        /// </summary>
        public Array? Integrations { get; set; }
        /// <summary>
        /// Whether the connection is verified
        /// </summary>
        public bool? Verified { get; set; }
        /// <summary>
        /// Whether friend sync is enabled for this connection
        /// </summary>
        public bool? FriendSync { get; set; }
        /// <summary>
        /// Whether activities related to this connection will be shown in presence updates
        /// </summary>
        public bool? ShowActivity { get; set; }
        /// <summary>
        /// Whether this connection has a corresponding third party OAuth2 token
        /// </summary>
        public bool? TwoWayLink { get; set; }
        /// <summary>
        /// <see href="https://discord.com/developers/docs/resources/user#connection-object-visibility-types">Visibility</see> of this connection
        /// </summary>
        public int? Visivility { get; set; }
    }

    /// <summary>
    /// https://discord.com/developers/docs/resources/user#connection-object-services
    /// </summary>
    public enum Services
    {
        [EnumMember(Value = "amazon-music")]
        AmazonMusic,

        [EnumMember(Value = "battlenet")]
        BattleNet,

        [EnumMember(Value = "bluesky")]
        Bluesky,

        [EnumMember(Value = "bungie")]
        BungieNet,

        [EnumMember(Value = "crunchyroll")]
        Crunchyroll,

        [EnumMember(Value = "domain")]
        Domain,

        [EnumMember(Value = "ebay")]
        EBay,

        [EnumMember(Value = "epicgames")]
        EpicGames,

        [EnumMember(Value = "facebook")]
        Facebook,

        [EnumMember(Value = "github")]
        GitHub,

        [EnumMember(Value = "instagram")]
        Instagram,

        [EnumMember(Value = "leagueoflegends")]
        LeagueOfLegends,

        [EnumMember(Value = "mastodon")]
        Mastodon,

        [EnumMember(Value = "paypal")]
        PayPal,

        [EnumMember(Value = "playstation")]
        PlayStationNetwork,

        [EnumMember(Value = "reddit")]
        Reddit,

        [EnumMember(Value = "riotgames")]
        RiotGames,

        [EnumMember(Value = "roblox")]
        Roblox,

        [EnumMember(Value = "spotify")]
        Spotify,

        [EnumMember(Value = "skype")]
        Skype,

        [EnumMember(Value = "steam")]
        Steam,

        [EnumMember(Value = "tiktok")]
        TikTok,

        [EnumMember(Value = "twitch")]
        Twitch,

        [EnumMember(Value = "twitter")]
        X,

        [EnumMember(Value = "xbox")]
        Xbox,

        [EnumMember(Value = "youtube")]
        YouTube
    }

    /// <summary>
    /// https://discord.com/developers/docs/resources/user#connection-object-visibility-types
    /// </summary>
    public enum Visibility1Types
    {
        /// <summary>
        /// Invisible to everyone except the user themselves
        /// </summary>
        None,
        /// <summary>
        /// Visible to everyone
        /// </summary>
        Everyone 
    }

    /// <summary>
    /// https://discord.com/developers/docs/resources/user#application-role-connection-object-application-role-connection-structure
    /// </summary>
    public class ApplicationRoleConnectionStructure
    {
        /// <summary>
        /// The vanity name of the platform a bot has connected (max 50 characters)
        /// </summary>
        public string? PlatformName { get; set; }
        /// <summary>
        /// The username on the platform a bot has connected (max 100 characters)
        /// </summary>
        public string? PlatformUsername { get; set; }
        /// <summary>
        /// Object mapping <see href="https://discord.com/developers/docs/resources/application-role-connection-metadata#application-role-connection-metadata-object">application role connection metadata</see> keys to their <c>string</c>-ified value (max 100 characters) for the user on the platform a bot has connected        
        /// </summary>                 
        public required object Metadata { get; set; }
    }
}