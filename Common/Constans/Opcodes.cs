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
    CMSG_ADD_FRIEND             = 0x069, // Leight: 1,  (leight nick)+1, Add Friend.
    CMSG_DEL_FRIEND             = 0x06A, // Leight: 1,  Delete Friend.
    CMSG_EMOTE                  = 0x0F7, // Leight: 12, All emote's.
    CMSG_CONTACT_LIST           = 0x066, // Leight: 0,  Open Friend list.
    CMSG_WHO                    = 0x062, // Leight: 26, Who > use button [Refresh].
    CMSG_ADD_IGNORE             = 0x06C, // Leight: 1,  (leight nick)+1, Add ignore player.
    MSG_MOVE_FALL_LAND          = 0x0C9, // Leight: 60, Use move and jump...


    // 447                      = 0x1BF, // Leight: 0,  From Login(Enter world).
    // 496                      = 0x1F0, // Leight: 0,  From Login(Enter world)
    // 485                      = 0x1E5, // Leight: 4,  Change location.
    // 271                      = 0x10F, // Leight: 0,  From logout.
    // 304                      = 0x130, // Leight: 8,  Target character use F1
    // 497                      = 0x1F1, // Leight: 4,  Who > I would like to join a group.
    // 468                      = 0x1D4, // Leight: 4,  Speech > all speech..
    // 418                      = 0x1A2, // Leight: 8,  Open Talents.
}
