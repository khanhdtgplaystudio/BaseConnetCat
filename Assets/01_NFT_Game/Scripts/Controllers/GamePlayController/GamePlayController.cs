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
    public Level level;
    public BoardUserInput boardUserInput;
    public GameAssets gameAssets;
    public StateGame state;

    protected override void OnAwake()
    {
        GameController.Instance.currentScene = SceneType.GamePlay;

        Init();
    }

    public void Init()
    {

        level.Init();
        boardUserInput.Initialize();
        //MusicManager.Instance.PlayBGMusic();
    }

    public void InitLevel()
    {
      //  level = Instantiate(Resources.Load<Level>("Levels/Level_" + indexLevel), null);
      //Load ra level theo Json

       
    }
}
