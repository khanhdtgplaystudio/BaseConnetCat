using System;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using DG.Tweening;

public class PopupRewardBase : BaseBox
{
    private static PopupRewardBase instance;

    [SerializeField] private RewardElement rewardPrefab;
    [SerializeField] private Transform contentPool;

    [SerializeField] private Button claimBtn;

    private List<RewardElement> _poolReward = new List<RewardElement>();
    private List<GiftRewardShow> _reward;
    private Action _actionClaim;
    private bool isX2Reward;

    private bool isClickedClaim;
    private bool isClosing;
    private bool isAddValueItem;

    [SerializeField] private ParticleSystemRenderer[] parslayer;
    [SerializeField] private Canvas canvasRewardContent;

    [HideInInspector] public UnityAction actionMoreClaim;
    public static PopupRewardBase Setup(bool isSaveBox = false, Action actionOpenBoxSave = null)
    {
        if (instance == null)
        {
            instance = Instantiate(Resources.Load<PopupRewardBase>(PathPrefabs.POPUP_REWARD_BASE));
        }
        //instance.Show();
        return instance;

    }

    public void Init()
    {

    }
    IEnumerator showBtnClaimIE;
    public PopupRewardBase Show(List<GiftRewardShow> reward, Action actionClaim = null, float timeShowClaimNow = 0)
    {
        claimBtn.onClick.RemoveAllListeners();
        claimBtn.onClick.AddListener(Claim);
        if (isAnim)
        {
            if (mainPanel != null)
            {
                mainPanel.localScale = Vector3.zero;
                mainPanel.DOScale(1, 0.5f).SetUpdate(true).SetEase(Ease.OutBack).OnComplete(() => { });
            }
        }

        base.Show();
        _actionClaim = actionClaim;
        ClearPool();
        BoxController.Instance.isLockEscape = true;

        canvasRewardContent.sortingOrder = popupCanvas.sortingLayerID + 2;

        for (int i = 0; i < reward.Count; i++)
        {
            RewardElement elem = GetRewardElement();

            if (reward[i].icon == null)
                elem.Init(GetIcon(reward[i].type), reward[i].amount);
            else
                elem.Init(reward[i].icon, reward[i].amount);

            if (GiftDatabase.IsCharacter(reward[i].type))
            {
                elem.iconImg.transform.localScale = 4f * Vector3.one;
            }
            else
            {
                elem.iconImg.transform.localScale = 1.5f * Vector3.one;
            }
        }
        this._reward = reward;

        isClickedClaim = false;
        isClosing = false;

        OnCloseBox = () =>
        {
            isClosing = true;
            Claim();
            if (actionMoreClaim != null)
            {
                actionMoreClaim();
                actionMoreClaim = null;
            }
        };

        claimBtn.gameObject.SetActive(true);
        claimBtn.transform.localScale = Vector3.one;
        isX2Reward = false;

        for (int i = 0; i < parslayer.Length; i++)
        {
            parslayer[i].sortingOrder = popupCanvas.sortingOrder + 1;
        }
        return this;
    }

    private RewardElement GetRewardElement()
    {
        for (int i = 0; i < _poolReward.Count; i++)
        {
            if (!_poolReward[i].gameObject.activeSelf)
            {
                _poolReward[i].gameObject.SetActive(true);
                return _poolReward[i];
            }
        }

        RewardElement element = Instantiate(rewardPrefab, contentPool);
        _poolReward.Add(element);
        return element;
    }

    private void ClearPool()
    {
        foreach (var rewardElement in _poolReward)
        {
            rewardElement.gameObject.SetActive(false);
        }
    }

    public void Claim()
    {
        if (isClickedClaim)
            return;



        ClaimSuccess();
    }

    IEnumerator ClaimWithDelay()
    {
        yield return new WaitForSeconds(0.8f);

        ClaimSuccess();
    }

    public void ClaimSuccess()
    {
        isClickedClaim = true;
        for (int i = 0; i < this._reward.Count; i++)
        {
            var effectController = GameController.Instance.moneyEffectController;
            effectController.SpawnEffect_FlyUp(claimBtn.transform.position, this._reward[i].type, this._reward[i].amount, colorText: Color.white);
        }

        BoxController.Instance.isLockEscape = false;
        if (!isClosing)
            Close();

        if (_actionClaim != null)
            _actionClaim();
    }

    private Sprite GetIcon(GiftType type)
    {
        return GameController.Instance.dataContain.giftDatabase.GetIconItem(type);
    }
}

[System.Serializable]
public class GiftRewardShow
{
    public GiftType type;
    public int amount = 0;
    public Sprite icon = null;
}
