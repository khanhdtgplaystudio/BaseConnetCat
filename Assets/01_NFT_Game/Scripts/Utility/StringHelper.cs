using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StringHelper
{
    public const string ONOFF_SOUND = "ONOFF_SOUND";
    public const string ONOFF_MUSIC = "ONOFF_MUSIC";
    public const string ONOFF_VIBRATION = "ONOFF_VIBRATION";
    public const string FIRST_TIME_INSTALL = "FIRST_TIME_INSTALL";

    public const string VERSION_FIRST_INSTALL = "VERSION_FIRST_INSTALL";

    public const string CURRENT_LEVEL = "CURRENT_LEVEL";
    public const string PATH_CONFIG_LEVEL = "Levels/Level_";
}

public class PathPrefabs
{
    public const string POPUP_REWARD_BASE = "UI/Popups/PopupRewardBase";
    public const string CONFIRM_POPUP = "UI/Popups/ConfirmBox";
    public const string WAITING_BOX = "UI/Popups/WaitingBox";
}

public class SceneName
{
    public const string LOADING_SCENE = "LoadingScene";
    public const string HOME_SCENE = "HomeScene";
    public const string GAME_PLAY = "GamePlay";
}

public class AudioName
{
    public const string bgMainHome = "Music_BG_MainHome";
    public const string bgGamePlay = "Music_BG_GamePlay";

    //Ingame music
    public const string winMusic = "winMusic";
    public const string spawnerPlayerMusic = "spawnerPlayer";

    //Action Player music
    public const string jumpMusic = "jump";
    public const string jumpEndMusic = "jumpEnd";
    public const string swapMusic = "swap";
    public const string pushRockMusic = "pushRock";
    public const string dieMusic = "die";
    public const string reviveMusic = "revive";
    public const string flyMusic = "fly";

    //Collect music
    public const string collectCoinMusic = "collectCoin";
    public const string collectKeyMusic = "collectKey";
    public const string collectItemSound = "collectItem";

    //Level music
    public const string jumpOnWaterMusic = "jumpOnWater";
    public const string collisionDoorMusic = "collisionDoor";
    public const string doorOpenMusic = "doorOpen";
    public const string doorCloseMusic = "doorClose";
    public const string springMusic = "spring";
    public const string touchSwitchMusic = "touchSwitch";
    public const string bridgeMoveMusic = "bridgeMove";
    public const string bridgeMoveEndMusic = "bridgeMoveEnd";
    public const string iceDropFall = "rock1";
    public const string iceDropExplosion = "bigrock";
    public const string activeDiamond = "crystalactive";
    public const string releaseDiamond = "crystalrelease";
    //UI Music
    public const string buttonClick = "buttonClick";
}

public class KeyPref
{
    public const string SERVER_INDEX = "SERVER_INDEX";
}
