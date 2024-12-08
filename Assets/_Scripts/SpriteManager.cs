using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteManager : MonoBehaviour
{
    public Sprite CardBackSprite; 
    public Sprite ItemBackSprite; 
    //[Header("女孩卡牌图片")]
    //public Sprite BatCardSprite;
    //public Sprite BoomCardSprite; 
    //public Sprite BowCardSprite;
    //public Sprite HammerCardSprite; 
    //public Sprite FireCardSprite; 

    //[Header("梦兽卡牌图片")]
    //public Sprite ChristmasCardSprite; 
    //public Sprite DentalCardSprite;
    //public Sprite DogCardSprite;
    //public Sprite GhostCardSprite;
    //public Sprite JokerCardSprite;

    [Header("道具图片")]
    public Sprite PeekItemSprite; 
    public Sprite ChangeCardItemSprite;
    public Sprite ForceChangeCardItemSprite; 
    public Sprite EncourageItemSprite;
    public Sprite DivinationItemSprite;
    public Sprite SwapCardPointsItemSprite;
    
    public Dictionary<string, Sprite> map = new Dictionary<string, Sprite>();

    public void InitMap()
    {
        map.Add("BackCard", CardBackSprite);
        map.Add("BackItem", ItemBackSprite);

        //map.Add("BatCard", BatCardSprite);
        //map.Add("BoomCard", BoomCardSprite);
        //map.Add("BowCard", BowCardSprite);
        //map.Add("HammerCard", HammerCardSprite);
        //map.Add("FireCard", FireCardSprite);

        //map.Add("ChristmasCard", ChristmasCardSprite);
        //map.Add("DentalCard", DentalCardSprite);
        //map.Add("DogCard", DogCardSprite);
        //map.Add("GhostCard", GhostCardSprite);
        //map.Add("JokerCard", JokerCardSprite);

        map.Add("侦探眼睛", PeekItemSprite);
        map.Add("抓娃娃爪子", ChangeCardItemSprite);
        map.Add("鬼手", ForceChangeCardItemSprite);
        map.Add("壮胆", EncourageItemSprite);
        map.Add("占卜", DivinationItemSprite);
        map.Add("交换", SwapCardPointsItemSprite);
    }

    public void AddMap(string key, Sprite value)
    {
        map.Add(key, value);
    }

    public Sprite FindSprite(string key)
    {
        return map[key];
    }
}
