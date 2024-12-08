using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTargetArea : MonoBehaviour
{
    private FearCardUI readyToUseCardUI = null;

    public FearCard GetAreaCard()
    {
        return readyToUseCardUI != null ? readyToUseCardUI.card : null;
    }    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Card")) 
        {
            FearCardUI cardUI = other.GetComponent<FearCardUI>();
            if (cardUI != null)
            {
                cardUI.SnapToTarget(transform);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Card"))
        {
            FearCardUI cardUI = other.GetComponent<FearCardUI>();
            if (cardUI != null && cardUI == readyToUseCardUI)
            {
                cardUI.ResetPosition();
                readyToUseCardUI = null;
            }
        }
    }

    public void GetReadyToUseCard(FearCardUI cardUI)
    {
        if (readyToUseCardUI != null)
        {
            readyToUseCardUI.ReturnToHand();
        }
        readyToUseCardUI = cardUI;
    }


    public void ClearReadyToUseCard()
    {
        for (int i = 1; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject);
        }
        readyToUseCardUI = null;
    }

    public void CardUIFlipBack(bool istoback)
    {
        if (readyToUseCardUI == null)
        {
            return;
        }
        readyToUseCardUI.FlipBack(istoback);
    }

    public void UpdatePoint(int point)
    {
        readyToUseCardUI.UpdatePoint(point);
    }

    public void UpdateSprite(FearCard card)
    {
        readyToUseCardUI.UpdateSprite(card.background, card.artSprite);
    }
}
