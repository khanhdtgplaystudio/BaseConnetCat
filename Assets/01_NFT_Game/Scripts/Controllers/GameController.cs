using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public MoneyEffectController moneyEffectController;
    public UseProfile useProfile;
    public DataContain dataContain;
 
    [HideInInspector] public SceneType currentScene;
   
    protected void Awake()
    {
        Instance = this;
        Init();
        DontDestroyOnLoad(this);

    }

    public void Init()
    {
        Application.targetFrameRate = 60;
        dataContain.Initialize();
    }

    public void LoadScene(string sceneName)
    {
        Initiate.Fade(sceneName.ToString(), Color.black, 2f);
    }    
}
public enum SceneType
{
    StartLoading = 0,
    MainHome = 1,
    GamePlay = 2
}