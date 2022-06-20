using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Datas/GiftDatabase", fileName = "GiftDatabase.asset")]
public class GiftDatabase : SerializedScriptableObject
{
    public Dictionary<GiftType, Gift> giftList;

    public bool GetGift(GiftType giftType, out Gift gift)
    {
        return giftList.TryGetValue(giftType, out gift);
    }

    public Sprite GetIconItem(GiftType giftType)
    {
        Gift gift = null;
        //if (IsCharacter(giftType))
        //{
        //    var Char = GameController.Instance.dataContain.dataSkins.GetSkinInfo(giftType);
        //    if (Char != null)
        //        return Char.iconSkin;
        //}
        bool isGetGift = GetGift(giftType, out gift);
        return isGetGift ? gift.getGiftSprite : null;
    }

    public void Claim(GiftType giftType, int amount, Reason reason = Reason.none)
    {
        //if (IsCharacter(giftType))
        //{
        //    var character = GameController.Instance.dataContain.dataSkins.GetSkinInfo(giftType);

        //    if (character != null)
        //    {
        //        character.IsUnlocked = true;
        //        GameController.Instance.useProfile.CurrentPlayerChoice = character.id;
        //        EventDispatcher.EventDispatcher.Instance.PostEvent(EventID.UNLOCK_NEW_SKIN);
        //    }

        //    return;
        //}

        switch (giftType)
        {
            case GiftType.Coin:
               // GameController.Instance.useProfile.Coin += amount;
                break;
            case GiftType.Health:
              //  GameController.Instance.useProfile.Health += amount;
                break;
        }
    }

    public static bool IsCharacter(GiftType giftType)
    {
        switch (giftType)
        {
            case GiftType.RandomSkin:
                return true;
        }
        return false;
    }
}

public class Gift
{
    [SerializeField] private Sprite giftSprite;
    public virtual Sprite getGiftSprite => giftSprite;
}

public enum GiftType
{
    None = 0,
    Coin = 1,
    Health = 2,

    RandomSkin = 4,
}

public enum Reason
{
    none = 0,
    play_with_item = 1,
    watch_video_claim_item_main_home = 2,
    daily_login = 3,
    lucky_spin = 4,
    unlock_skin_in_special_gift = 5,
    reward_accumulate = 6,
}

[Serializable]
public class RewardRandom
{
    public int id;
    public GiftType typeItem;
    public int amount;
    public int weight;

    public RewardRandom()
    {
    }
    public RewardRandom(GiftType item, int amount, int weight = 0)
    {
        this.typeItem = item;
        this.amount = amount;
        this.weight = weight;
    }

    public GiftRewardShow GetReward()
    {
        GiftRewardShow rew = new GiftRewardShow();
        rew.type = typeItem;
        rew.amount = amount;

        return rew;
    }
}
