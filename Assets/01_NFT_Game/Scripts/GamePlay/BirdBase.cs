using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class BirdBase : MonoBehaviour
{
    protected bool isFlying;
    [SerializeField] protected SpriteRenderer body;
    [SerializeField] protected float speedMove = 5;

    public void Init(Vector3 posStart, Vector3 posSpawn, UnityAction actionCome)
    {
        this.transform.DOKill();
        this.transform.position = posStart;
        FlyCome(posSpawn, actionCome);
    }

    public void FlyCome(Vector3 pos, UnityAction actionCome)
    {
        isFlying = true;

        this.transform.DOKill();
        float timeMove = Vector3.Distance(this.transform.position, pos);
        this.transform.DOMove(pos, timeMove).OnComplete(() => { isFlying = false; actionCome?.Invoke(); });
    }
}
