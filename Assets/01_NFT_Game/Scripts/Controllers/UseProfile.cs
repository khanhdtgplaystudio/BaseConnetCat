using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class UseProfile : MonoBehaviour
{

    public static int CurrentLevel
    {
        get
        {
            return PlayerPrefs.GetInt(StringHelper.CURRENT_LEVEL, 1);
        }
        set
        {
            PlayerPrefs.SetInt(StringHelper.CURRENT_LEVEL, value);
            PlayerPrefs.Save();
        }
    }

    public bool OnVibration
    {
        get
        {
            return PlayerPrefs.GetInt(StringHelper.ONOFF_VIBRATION, 1) == 1;
        }
        set
        {
            PlayerPrefs.SetInt(StringHelper.ONOFF_VIBRATION, value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

    public bool OnSound
    {
        get
        {
            return PlayerPrefs.GetInt(StringHelper.ONOFF_SOUND, 1) == 1;
        }
        set
        {
            PlayerPrefs.SetInt(StringHelper.ONOFF_SOUND, value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }

   

    public static bool IsFirstTimeInstall
    {
        get
        {
            return PlayerPrefs.GetInt(StringHelper.FIRST_TIME_INSTALL, 1) == 1;
        }
        set
        {
            PlayerPrefs.SetInt(StringHelper.FIRST_TIME_INSTALL, value ? 1 : 0);
            PlayerPrefs.Save();
        }
    }
}
