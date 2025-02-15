// Types extracted from https://discord.com/developers/docs/topics/permissions

namespace Discord.CSharp.APITypes.Payloads
{   
    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-structure
    /// </summary>
    public class Role
    {
        /// <summary>
        /// Role id
        /// </summary>
        public required string Id { get; set; }
        /// <summary>
        /// Role name
        /// </summary>
        public required string Name { get; set; }
        /// <summary>
        /// Integer representation of hexadecimal color code
        /// </summary>
        public int Color { get; set; }
        /// <summary>
        /// If this role is pinned in the user listing
        /// </summary>
        public bool Hoist { get ; set; }
        /// <summary>
        /// Role <see href="https://discord.com/developers/docs/reference#image-formatting">icon hash</see>
        /// </summary>
        public string? Icon { get; set; }
        /// <summary>
        /// Role unicode emoji
        /// </summary>
        public string? UnicodeEmoji { get; set; }
        /// <summary>
        /// Position of this role (roles with the same position are sorted by id)
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// Permission bit set
        /// </summary>
        public required string Permissions { get; set; }
        /// <summary>
        /// Whether this role is managed by an integration
        /// </summary>
        public bool Managed { get; set; }
        /// <summary>
        /// Whether this role is mentionable
        /// </summary>
        public bool Mentionable { get; set; }
        /// <summary>
        /// The tags this role has
        /// </summary>
        public RoleTags? Tags { get; set; }
        /// <summary>
        /// <see href="https://discord.com/developers/docs/topics/permissions#role-object-role-flags">Role flags</see> combined as a <see href="https://en.wikipedia.org/wiki/Bit_field">bitfield</see>
        /// </summary>
        public int Flags { get; set; }
    }

    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-tags-structure
    /// </summary>
    public class RoleTags
    {
        /// <summary>
        /// The id of the bot this role belongs to
        /// </summary>
        public string? BotId { get; set; }
        /// <summary>
        /// The id of the integration this role belongs to
        /// </summary>
        public string? IntegrationId { get; set; }
        /// <summary>
        /// Whether this is the guild's Booster role
        /// </summary>
        public bool? PremiumSubscriber { get; set; }
        /// <summary>
        /// The id of this role's subscription sku and listing
        /// </summary>
        public string? SubscriptionListingId { get; set; }
        /// <summary>
        /// Whether this role is available for purchase
        /// </summary>
        public bool? AvailableForPurchase { get; set; }
        /// <summary>
        /// Whether this role is a guild's linked role
        /// </summary>
        public bool? GuildConnections { get; set; }
    }

    /// <summary>
    /// https://discord.com/developers/docs/topics/permissions#role-object-role-flags
    /// </summary>
    public enum RoleFlags {
        /// <summary>
        /// Role can be selected by members in an <see href="https://discord.com/developers/docs/resources/guild#guild-onboarding-object">onboarding</see> prompt
        /// </summary>
        InPrompt = 1 << 0
    }
}