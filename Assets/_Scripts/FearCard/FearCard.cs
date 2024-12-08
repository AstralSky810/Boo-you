using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FearCard 
{
    public string cardName;
    public Sprite background;
    public Sprite artSprite;
    public Sprite back;
    public int point;

    //��ʤ�߿���Ϊ׼���غϽ���ʤ������ʤ�߿���ʤ���İ������߲���ʤ�߿���ʧ���İ�
    public string victoryDescription;
    public string defeatDescription;
    //ƽ�������ޣ���ң��Ȳ������޿���ƽ���İ���Ȼ��Ů�������ˣ�����Ů������ƽ���İ�
    public string tieDescription;
    public FearCardSO fearCardData;

    public bool isUsed;

    public FearCard(FearCardSO fearCardData)
    {
        this.fearCardData = fearCardData;
        this.isUsed = false;
    }

    public FearCard(string name, Sprite background, Sprite art, Sprite back, int point, string victoryDescription, string defeatDescription, string tieDescription)
    {
        this.cardName = name;
        this.background = background;
        this.artSprite = art;
        this.point = point;
        this.back = back;
        this.victoryDescription = victoryDescription;
        this.defeatDescription = defeatDescription;
        this.tieDescription = tieDescription;
    }
}
