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
        canvas.GetComponent<Animator>().SetBool("ClearStatus", true);
        GetComponent<Animator>().SetBool("UpFlag", true);
        canvas.GetComponent<TransShumi>().SetGoFlag(false);
    }

    public void BackAnimation()
    {
        canvas.GetComponent<Animator>().SetBool("ClearStatus", false);
        GetComponent<Animator>().SetBool("UpFlag", false);
        canvas.GetComponent<TransShumi>().SetGoFlag(true);
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
