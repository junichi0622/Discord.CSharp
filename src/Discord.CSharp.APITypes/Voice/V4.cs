/// https://discord.com/developers/docs/topics/opcodes-and-status-codes#voice

namespace Discord.CSharp.APITypes.Voice
{
    /// <summary>
    /// https://discord.com/developers/docs/topics/opcodes-and-status-codes#voice-voice-opcodes
    /// </summary>
    public enum VoiceOpcodes
    {
        /// <summary>
        /// Begin a voice websocket connection.
        /// </summary>
        Identify,
        /// <summary>
        /// Select the voice protocol.
        /// </summary>
        SelectProtocol,
        /// <summary>
        /// Complete the websocket handshake.
        /// </summary>
        Ready,
        /// <summary>
        /// Keep the websocket connection alive.
        /// </summary>
        Heartbeat,
        /// <summary>
        /// Describe the session.
        /// </summary>
    	SessionDescription,
        /// <summary>
        /// Indicate which users are speaking.
        /// </summary>
        Speaking,
        /// <summary>
        /// Sent to acknowledge a received client heartbeat.
        /// </summary>
        HeartbeatACK,
        /// <summary>
        /// Resume a connection.
        /// </summary>
        Resume,
        /// <summary>
        /// Time to wait between sending heartbeats in milliseconds.
        /// </summary>
        Hello,
        /// <summary>
        /// Acknowledge a successful session resume.
        /// </summary>
        Resumed,
        /// <summary>
        /// One or more clients have connected to the voice channel
        /// </summary>
        ClientsConnect = 11,
        /// <summary>
        /// A client has disconnected from the voice channel
        /// </summary>
        ClientDisconnect = 13,
        /// <summary>
        /// A downgrade from the DAVE protocol is upcoming
        /// </summary>
        DAVEPrepareTransition = 21,
        /// <summary>
        /// Execute a previously announced protocol transition
        /// </summary>
        DAVEExecuteTransition,
        /// <summary>
        /// Acknowledge readiness previously announced transition
        /// </summary>
        DAVETransitionReady,
        /// <summary>
        /// A DAVE protocol version or group change is upcoming
        /// </summary>
        DAVEPrepareEpoch ,
        /// <summary>
        /// Credential and public key for MLS external sender
        /// </summary>
        DAVEMLSExternalSender,
        /// <summary>
        /// MLS Key Package for pending group member
        /// </summary>
        DAVEMLSKeyPackage,
        /// <summary>
        /// MLS Proposals to be appended or revoked
        /// </summary>
        DAVEMLSProposals,
        /// <summary>
        /// MLS Commit with optional MLS Welcome messages
        /// </summary>
        DAVEMLSCommitWelcome,
        /// <summary>
        /// MLS Commit to be processed for upcoming transition
        /// </summary>
        DAVEMLSAnnounceCommitTransition,
        /// <summary>
        /// MLS Welcome to group for upcoming transition
        /// </summary>
        DAVEMLSWelcome,
        /// <summary>
        /// Flag invalid commit or welcome, request re-add
        /// </summary>
        DAVEMLSInvalidCommitWelcome
    }

    public enum VoiceCloseEventCodes
    {
        /// <summary>
        /// You sent an invalid <see href="https://discord.com/developers/docs/topics/opcodes-and-status-codes#voice-voice-opcodes">opcode</see>.
        /// </summary>
        UnknownOpcode = 4001,
        /// <summary>
        /// You sent an invalid payload in your <see href="https://discord.com/developers/docs/events/gateway-events#identify">identifying</see> to the Gateway.
        /// </summary>
        FailedToDecodePayload,
        /// <summary>
        /// You sent a payload before <see href="https://discord.com/developers/docs/events/gateway-events#identify">identifying</see> with the Gateway.
        /// </summary>
        NotAuthenticated,
        /// <summary>
        /// The token you sent in your <see href="https://discord.com/developers/docs/events/gateway-events#identify">identify</see> payload is incorrect.
        /// </summary>
        AuthenticationFailed,
        /// <summary>
        /// You sent more than one <see href="https://discord.com/developers/docs/events/gateway-events#identify">identify</see> payload. Stahp.
        /// </summary>
        AlreadyAuthenticated,
        /// <summary>
        /// Your session is no longer valid.
        /// </summary>
        SessionNoLongerValid,
        /// <summary>
        /// Your session has timed out.
        /// </summary>
        SessionTimeout = 4009,
        /// <summary>
        /// We can't find the server you're trying to connect to. 
        /// </summary>
        ServerNotFound = 4011,
        /// <summary>
        /// We didn't recognize the <see href="https://discord.com/developers/docs/topics/voice-connections#establishing-a-voice-udp-connection-example-select-protocol-payload">protocol</see> you sent.
        /// </summary>
        UnknownProtocol,
        /// <summary>
        /// Channel was deleted, you were kicked, voice server changed, or the main gateway session was dropped. Should not reconnect.
        /// </summary>
        Disconnected = 4014,
        /// <summary>
        /// The server crashed. Our bad! Try <see href="https://discord.com/developers/docs/topics/voice-connections#resuming-voice-connection">resuming</see>.
        /// </summary>
        VoiceServerCrashed,
        /// <summary>
        /// We didn't recognize your <see href="https://discord.com/developers/docs/topics/voice-connections#transport-encryption-and-sending-voice">encryption</see>.
        /// </summary>
        UnknownEncryptionMode,
        /// <summary>
        /// You sent a malformed request
        /// </summary>
        BadRequest = 4020
    }
}