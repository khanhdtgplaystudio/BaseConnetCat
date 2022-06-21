using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameEventController : MonoBehaviour
{
    public Board board;
    public BoardUserInput boardUserInput;
  public void InnitState()
    {
        board.Initialize();
        boardUserInput.Initialize();
    }
}
