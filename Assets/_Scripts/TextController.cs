using UnityEngine;
using TMPro;
using System.Collections;

public class TextScroller : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;  // TextMeshProUGUI ���
    public float scrollSpeed = 50f;  // �����ٶ�
    private float curHeight = 0;
    float startPosition;
    float endPosition;

    private RectTransform rectTransform;
    private bool isScrolling = false;  // �����Ƿ������ڽ��еĹ���

    private void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        rectTransform = textMeshPro.GetComponent<RectTransform>();
        textMeshPro.text = "";  // ��ʼ��ʱ�ı�Ϊ��
        startPosition = rectTransform.anchoredPosition.y;
    }

    public void Scroll()
    {
        // ֻ�е�û�����ڽ��еĹ���ʱ�ſ�ʼ�µĹ���
        if (!isScrolling)
        {
            StartCoroutine(ScrollText());
        }
    }

    private IEnumerator ScrollText()
    {
        yield return new WaitUntil(() => isScrolling == false);
        isScrolling = true;  // ���Ϊ���ڹ���

        // ��ȡ�ı��ĸ߶�
        float textHeight = textMeshPro.preferredHeight;

        // ��ȡ�ı���ĸ߶�
        float textBoxHeight = rectTransform.rect.height;

        // ����ı��߶ȴ����ı���߶ȣ���ʼ����
        if (textHeight > textBoxHeight)
        {
            // ���㳬�����ֵĸ߶�
            float overflowHeight = textHeight - textBoxHeight;

            // ����ÿ�ι����ľ��룬ȷ���������������ֵĸ߶�
            float scrollAmount = Mathf.Min(overflowHeight, textBoxHeight);

            // ����Ŀ��λ��
            endPosition = startPosition + scrollAmount;

            // ���� curHeight
            curHeight += scrollAmount;

            // ȷ��������������ı��ĵײ�
            if (curHeight > overflowHeight)
            {
                curHeight = overflowHeight;
                endPosition = startPosition + overflowHeight;  // ��ֹ������Χ
            }

            float journeyLength = Mathf.Abs(endPosition - startPosition);
            float journeyCovered = 0f;

            while (journeyCovered < journeyLength)
            {
                // ��������Ľ���
                journeyCovered += scrollSpeed * Time.deltaTime;

                // ʹ�� Lerp ����ƽ������
                float newPosition = Mathf.Lerp(startPosition, endPosition, journeyCovered / journeyLength);

                // �����ı�λ��
                rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, newPosition);

                yield return null;
            }

            // ȷ����������ı�λ��Ϊ����λ��
            rectTransform.anchoredPosition = new Vector2(rectTransform.anchoredPosition.x, endPosition);
        }
        isScrolling = false;  // ���Ϊ��������
    }
}
