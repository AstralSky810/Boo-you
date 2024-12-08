using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public AudioSource bgm;
    public AudioSource audioSource;
    [Header("女孩卡牌音效")]
    public AudioClip BatCardSound;
    public AudioClip BoomCardSound; 
    public AudioClip BowCardSound; 
    public AudioClip HammerCardSound; 
    public AudioClip FireCardSound; 

    [Header("梦兽卡牌音效")]
    public AudioClip ChristmasCardSound;
    public AudioClip DentalCardSound;
    public AudioClip DogCardSound;
    public AudioClip GhostCardSound; 
    public AudioClip JokerCardSound; 

    [Header("道具音效")]
    public AudioClip PeekItemSound; 
    public AudioClip ChangeCardItemSound; 
    public AudioClip ForceChangeCardItemSound; 
    public AudioClip EncourageItemSound; 
    public AudioClip DivinationItemSound; 
    public AudioClip SwapCardPointsItemSound; 

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public Dictionary<string, AudioClip> map = new Dictionary<string, AudioClip>();

    public void InitMap()
    {
        map.Add("BatCard", BatCardSound);
        map.Add("BoomCard", BoomCardSound);
        map.Add("BowCard", BowCardSound);
        map.Add("HammerCard", HammerCardSound);
        map.Add("FireCard", FireCardSound);

        map.Add("ChristmasCard", ChristmasCardSound);
        map.Add("DentalCard", DentalCardSound);
        map.Add("DogCard", DogCardSound);
        map.Add("GhostCard", GhostCardSound);
        map.Add("JokerCard", JokerCardSound);

        map.Add("侦探眼睛", PeekItemSound);
        map.Add("抓娃娃爪子", ChangeCardItemSound);
        map.Add("鬼手", ForceChangeCardItemSound);
        map.Add("壮胆", EncourageItemSound);
        map.Add("占卜", DivinationItemSound);
        map.Add("交换", SwapCardPointsItemSound);
    }

    public void AddMap(string key, AudioClip value)
    {
        map.Add(key, value);
    }

    public AudioClip FindSound(string key)
    {
        return map[key];
    }

    public void PlayCardSound(string cardName)
    {
        AudioClip clipToPlay = FindSound(cardName);

        if (clipToPlay != null)
        {
            audioSource.PlayOneShot(clipToPlay);
        }
    }

    public void PlayItemSound(string itemName)
    {
        AudioClip clipToPlay = FindSound(itemName);

        if (clipToPlay != null)
        {
            audioSource.PlayOneShot(clipToPlay);
        }
    }
}
