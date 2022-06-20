using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Config
{
    public static string settingProductName = "NFT_PIGGY_IO";

    public const string settingKeyStore = "piggyio";
    public static string keyaliasPass = "12345678one";
    public static string keystorePass = "12345678one";
    public static string settingAliasName = "piggyio";

    public const string settingLogo = "GAME_ICON"; 

    public static int versionCode = 2021111001;//sua
    public static string versionName = "1.0.1";//sua
    public static int settingVersionCode = 2021111001;//sua
    public static string settingVersionName = "1.0.1";//sua

    public static string productNameBuild = "Piggy IO";

    public static int VersionCodeAll
    {
        get
        {
            return versionCode / 100;
        }
    }

    public static int VersionFirstInstall
    {
        get
        {
            int data = PlayerPrefs.GetInt(StringHelper.VERSION_FIRST_INSTALL, 0);
            if (data == 0)
            {
                PlayerPrefs.SetInt(StringHelper.VERSION_FIRST_INSTALL, versionCode);
                data = versionCode;
            }

            return data;
        }
    }

    public static string inappAndroidKeyHash
        = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAm16r/oNWaM3z2GKVqgMHWVIVMR3JClRNlRzEIxrTBYWD4ZxW4CBSramC3ZgyLLDmf4ba5Au40ha6yIJWp0AIgJ7Gf55heen9SClUXvMGK1OZ3zze5jY2jkkkuVUQwtp9bdLn65wJcBowyNtgrWStuOBmREFlAoEAeqF1m2rmyMoEgamG5J0DxMcAf022WqtNwGkSff9geXANvYjDLxPRADdSg5x80StUqdJaZX5TwZuO6GkIwg9/36SRCHRLeXCrF4/qQBnbLBhoysF1BEqmXAsVvRuP+FQ6Ky0d6q/fdMwRlcm1/j+OLitx1Mi/FdQyeHhyCl3Ja6vt+wHZgmXxmwIDAQAB";
#if UNITY_ANDROID
    public const string package_name = "com.redstickman.duelist.puzzlegame";
#else
    public const string package_name = "com.stickmansuperduo.redbluegame";
#endif



#if UNITY_ANDROID
    public static string OPEN_LINK_RATE = "market://details?id=" + package_name;
#else
    public static string OPEN_LINK_RATE = "itms-apps://itunes.apple.com/app/id1245548580";
#endif

    public static string FanpageLinkWeb = "https://www.facebook.com/groups/402513540729752/";
    public static string FanpageLinkApp = "https://www.facebook.com/groups/402513540729752/";

    public static string LinkFeedback = "https://www.facebook.com/groups/402513540729752/";
    public static string LinkPolicy = "https://sites.google.com/view/mini-game-puzzle-fun-policy/";
    public static string LinkTerm = "https://sites.google.com/view/mini-game-puzzle-fun-policy/";

#if UNITY_ANDROID
    public const string IRONSOURCE_DEV_KEY = "114b4ecbd";
#else
 public const string IRONSOURCE_DEV_KEY = "114b59955";
#endif


#if UNITY_ANDROID
    public const string ADJUST_APP_TOKEN = "65vm9dtdiozk";
#else
    public const string ADJUST_APP_TOKEN = "9gi8zjgxmnls";
#endif
}
