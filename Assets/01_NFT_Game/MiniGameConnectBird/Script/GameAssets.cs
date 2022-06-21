using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Spine.Unity;

public class GameAssets : MonoBehaviour
{



    #region "Game Resources"
    public Text textLevel;
    public GameObject cellPrefab;
    public Transform catMoveEffectPrefab;
    public Transform heartEffectPrefab;
    public Transform cutOutCirclePrefab;
    public Transform lineHolderPrefab;
    public Transform pathMoveControllerPrefab;
    public Transform heartParticlePrefab;
    public Transform cellBackground;
    public Sprite grid_0;
    public Sprite grid_1;
    public List<GameObject> catPrefabs;
 
    #endregion
}
