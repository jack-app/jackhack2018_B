using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveShumiObject : MonoBehaviour {
    public GameObject canvas;
    public GameObject oldObject;
    bool scrollflag = true;

    public void MoveAnimation()
    {
        if(canvas != null)
        {
            canvas.GetComponent<Animator>().SetBool("ClearStatus", true);
            canvas.GetComponent<TransShumi>().SetGoFlag(false);
        }
        GetComponent<Animator>().SetBool("UpFlag", true);
    }

    public void BackAnimation()
    {
        if(canvas != null)
        {
            canvas.GetComponent<Animator>().SetBool("ClearStatus", false);
            canvas.GetComponent<TransShumi>().SetGoFlag(true);
        }
        GetComponent<Animator>().SetBool("UpFlag", false);
    }

    public void SetScrollPosition()
    {
        GetComponentInChildren<ScrollRect>().content.localPosition = new Vector2(0, 0);
        GetComponentInChildren<ScrollRect>().vertical = scrollflag;
        scrollflag = !scrollflag;
    }

    public void destroy()
    {
        Destroy(oldObject);
    }
    
}
