// Types extracted from https://discord.com/developers/docs/topics/opcodes-and-status-codes#rpc

namespace Discord.CSharp.APITypes.RPC
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/opcodes-and-status-codes#rpc-rpc-error-codes
    /// </summary>
    public enum RPCErrorCodes
    {
        /// <summary>
        /// An unknown error occurred.
        /// </summary>
        UnknownError = 1000,
        /// <summary>
        /// You sent an invalid payload.
        /// </summary>
        InvalidPayload = 4000,
        /// <summary>
        /// Invalid command name specified.
        /// </summary>
        InvalidCommand = 4002,
        /// <summary>
        /// Invalid guild ID specified.
        /// </summary>
        InvalidGuild,
        /// <summary>
        /// Invalid event name specified.
        /// </summary>
        InvalidEvent,
        /// <summary>
        /// Invalid channel ID specified.
        /// </summary>
        InvalidChannel,
        /// <summary>
        /// You lack permissions to access the given resource.
        /// </summary>
        InvalidPermissions,
        /// <summary>
        /// An invalid OAuth2 application ID was used to authorize or authenticate with.
        /// </summary>
        InvalidClientId,
        /// <summary>
        /// An invalid OAuth2 application origin was used to authorize or authenticate with.
        /// </summary>
        InvalidOrigin,
        /// <summary>
        /// An invalid OAuth2 token was used to authorize or authenticate with.
        /// </summary>
        InvalidToken,
        /// <summary>
        /// The specified user ID was invalid.
        /// </summary>
        InvalidUser,
        /// <summary>
        /// A standard OAuth2 error occurred; check the data object for the OAuth2 error details
        /// </summary>
        OAuth2Error = 5000,
        /// <summary>
        /// An asynchronous <c>SELECT_TEXT_CHANNEL</c>/<c>SELECT_VOICE_CHANNEL</c> command timed out.
        /// </summary>
        SelectChannelTimedOut,
        /// <summary>
        /// An asynchronous <c>GET_GUILD</c> command timed out.
        /// </summary>
        GetGuildTimedOut,
        /// <summary>
        /// You tried to join a user to a voice channel but the user was already in one.
        /// </summary>
        SelectVoiceForceRequired,
        /// <summary>
        /// You tried to capture more than one shortcut key at once.
        /// </summary>
        CaptureShortcutAlreadyListening
    }

    /// <summary>
    /// https://discord.com/developers/docs/topics/opcodes-and-status-codes#rpc-rpc-close-event-codes
    /// </summary>
    public enum RPCCloseEventCodes
    {
        /// <summary>
        /// You connected to the RPC server with an invalid client ID.
        /// </summary>
        InvalidClientId = 4000,
        /// <summary>
        /// You connected to the RPC server with an invalid origin.
        /// </summary>
        InvalidOrigin,
        /// <summary>
        /// You are being rate limited.
        /// </summary>
        RateLimited,
        /// <summary>
        /// The OAuth2 token associated with a connection was revoked, get a new one!
        /// </summary>
        TokenRevoked,
        /// <summary>
        /// The RPC Server version specified in the connection string was not valid.
        /// </summary>
        InvalidVersion,
        /// <summary>
        /// The encoding specified in the connection string was not valid.
        /// </summary>
        InvalidEncoding,

    }
}