using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeChat : MonoBehaviour {
    public RectTransform content;
    public RectTransform scrollView;
    public RectTransform scrollParent;
    public bool flag = false;
    float num = 0;
    bool flag1 = false;
    int n = 0;

    void Update()
    {
        if(n == 1)
        {
            num = content.sizeDelta.y;
        }
        if(Mathf.Abs(num - content.sizeDelta.y) > Mathf.Epsilon)
        {
            if (flag)
            {
                num = content.sizeDelta.y;
                flag = false;
                resetSize();
            }
        }
        if(n <= 2)
        {
            n++;
        }
    }

	void resetSize()
    {
        float y = scrollParent.sizeDelta.y + scrollView.sizeDelta.y;
        if (content.sizeDelta.y > y)
        {
            //Debug.Log(content.sizeDelta.y - scrollView.sizeDelta.y);
            content.localPosition = new Vector3(content.localPosition.x, content.sizeDelta.y - y, 0);
            //Debug.Log(content.localPosition.y);
        }
    }
}
