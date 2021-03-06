public enum EventID
{
    NONE,
    CELL_CLICK,
    MOVE_NOT_CATMOVE_COMPLETED,
    MOVE_COMPLETED,
    CONNECT_COMPLETED,
    CAT_MOVE_ON_BOARD_BEGIN,
    CAT_MOVE_ON_BOARD_COMPLETED,
    BOMB_EXPLODED,

    WIN_LEVEL,
    LOSE_LEVEL,

    PLAYER_DEAD = 1,
    PLAYER_RESPAWN = 2,
    DISABLE_OUTLINE_BIRD = 3,
    BUY_PRODUCT_SUCCESS_FIRST = 4,
    BUY_PRODUCT_SUCCESS = 5,
    CHANGE_LANGUAGE = 6,
    REMOVE_ADS = 7,
    FLY_OUT_RANDOM = 8,
}
