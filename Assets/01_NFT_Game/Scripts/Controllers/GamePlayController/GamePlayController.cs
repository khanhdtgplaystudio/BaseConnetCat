using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StateGame
{
    Playing = 0,
    Win = 1,
    Lose = 2,
    Pause = 2
}

public class GamePlayController  : Singleton<GamePlayController>
{
  

    public PlayerContain playerContain;
    public GameScene gameScene;
    //public CameraFollow cameraFollow;

    public StateGame state;

    protected override void OnAwake()
    {
        GameController.Instance.currentScene = SceneType.GamePlay;

     
    }

    public void Init()
    {
      
       
    
        //MusicManager.Instance.PlayBGMusic();
    }

    public void InitLevel()
    {
      //  level = Instantiate(Resources.Load<Level>("Levels/Level_" + indexLevel), null);
      //Load ra level theo Json

       
    }
}
