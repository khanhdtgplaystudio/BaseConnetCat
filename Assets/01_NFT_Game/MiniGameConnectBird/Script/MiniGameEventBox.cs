using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class MiniGameEventBox : BaseBox
{
    #region Instance
    private static MiniGameEventBox instance;
    public static MiniGameEventBox Setup(bool CallInstance = false,bool isSaveBox = false, Action actionOpenBoxSave = null)
    {



        if (instance == null)
        {
            instance = Instantiate(Resources.Load<MiniGameEventBox>(""));
            instance.Init();
        }
        if (CallInstance)
        {
            return instance;
        }
        instance.InitState();
        return instance;
    }
  



    #endregion

    #region Variable
    public MiniGameEventController miniGame;
    public GameAssets gameAssets;
    #endregion

    public void Init()
    {

    }
    public void InitState()
    {

    }
}
