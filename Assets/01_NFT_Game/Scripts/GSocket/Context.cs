using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context
{
    public static int MAX_LEVEL = 100;

    private static ProfileModel profile;
    public static ProfileModel CurrentUserPlayfabProfile
    {
        get
        {
            if (profile == null) return new ProfileModel();
            return profile;
        }
        set
        {
            profile = value;
        }
    }

    public static void ExitGame()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
