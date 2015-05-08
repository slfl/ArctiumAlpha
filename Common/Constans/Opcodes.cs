﻿public enum Opcodes : ushort
{
    SMSG_AUTH_CHALLENGE         = 0x1DD,
    SMSG_AUTH_RESPONSE          = 0x1DF,
    CMSG_AUTH_SESSION           = 0x1DE,
    CMSG_CHAR_CREATE            = 0x036,
    SMSG_CHAR_CREATE            = 0x03A,
    CMSG_CHAR_DELETE            = 0x038,
    SMSG_CHAR_DELETE            = 0x03C,
    CMSG_CHAR_ENUM              = 0x037,
    SMSG_CHAR_ENUM              = 0x03B,
    CMSG_PING                   = 0x1CD,
    SMSG_PONG                   = 0x1CE,
    CMSG_PLAYER_LOGIN           = 0x03D,
    SMSG_UPDATE_OBJECT          = 0x0A9,

    // NameCache
    CMSG_NAME_QUERY             = 0x050,
    SMSG_NAME_QUERY_RESPONSE    = 0x051,

    // Chat
    CMSG_MESSAGECHAT            = 0x095,
    SMSG_MESSAGECHAT            = 0x096,

    // Logout
    CMSG_LOGOUT_REQUEST         = 0x04B,
    SMSG_LOGOUT_RESPONSE        = 0x04C,
    SMSG_LOGOUT_COMPLETE        = 0x04D,

    // Teleport
    CMSG_WORLD_TELEPORT         = 0x008,
    SMSG_NEW_WORLD              = 0x03E,

    // Movement
    MSG_MOVE_START_FORWARD      = 0x0B5,
    MSG_MOVE_START_BACKWARD     = 0x0B6,
    MSG_MOVE_STOP               = 0x0B7,
    MSG_MOVE_START_STRAFE_LEFT  = 0x0B8,
    MSG_MOVE_START_STRAFE_RIGHT = 0x0B9,
    MSG_MOVE_STOP_STRAFE        = 0x0BA,
    MSG_MOVE_JUMP               = 0x0BB,
    MSG_MOVE_START_TURN_LEFT    = 0x0BC,
    MSG_MOVE_START_TURN_RIGHT   = 0x0BD,
    MSG_MOVE_STOP_TURN          = 0x0BE,
    MSG_MOVE_START_PITCH_UP     = 0x0BF,
    MSG_MOVE_START_PITCH_DOWN   = 0x0C0,
    MSG_MOVE_STOP_PITCH         = 0x0C1,
    MSG_MOVE_SET_RUN_MODE       = 0x0C2,
    MSG_MOVE_SET_WALK_MODE      = 0x0C3,
    MSG_MOVE_START_SWIM         = 0x0CB,
    MSG_MOVE_STOP_SWIM          = 0x0CC,
    MSG_MOVE_SET_FACING         = 0x0D7,
    MSG_MOVE_SET_PITCH          = 0x0D8,
    MSG_MOVE_ROOT               = 0x0E7,
    MSG_MOVE_UNROOT             = 0x0E8,
    MSG_MOVE_HEARTBEAT          = 0x0E9,

    SMSG_MOVE_WORLDPORT_ACK     = 0x0C7,
    MSG_MOVE_WORLDPORT_ACK      = 0x0D9,

    // Unknown
    // 447                      = 0x1BF, // Leight: 0
    // 496                      = 0x1F0, // Leight: 0
    // 485                      = 0x1E5, // Leight: 4
    // 271                      = 0x10F, // Leight: 0
    // 201                      = 0x0C9, // Leight: 60

}
