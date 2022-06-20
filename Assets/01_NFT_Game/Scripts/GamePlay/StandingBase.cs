using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotInStand
{
    public Transform posTrans;
    public int idBirdStand;
    public BirdBase birdOn;
}

public class StandingBase : MonoBehaviour
{
    public List<SlotInStand> slots;

    public void Init(List<int> idBirds)
    {
        int numSlot = slots.Count;
        //for (int i = 0; i < idBirds.Count; i++)
        //{
        //    if (i > numSlot)
        //        break;
        //    if (idBirds[i] > GamePlayController.Instance.birds.Count)
        //        return;
        //    var birdPrefab = GamePlayController.Instance.birds[]
        //    var bird = Instantiate()
        //}
    }    

}
