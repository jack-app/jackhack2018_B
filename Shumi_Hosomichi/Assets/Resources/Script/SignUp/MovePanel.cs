using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanel : MonoBehaviour {

	// Use this for initialization
	public void slidepanel () {
        this.transform.localPosition += new Vector3(-1500, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
