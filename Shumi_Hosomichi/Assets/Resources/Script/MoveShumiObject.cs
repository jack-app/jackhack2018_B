using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShumiObject : MonoBehaviour {
    public Animator canvas;

    public void MoveAnimation()
    {
        canvas.Play("shumiKiji");
    }

    public void destroy()
    {
        Destroy(gameObject);
    }
    
}
