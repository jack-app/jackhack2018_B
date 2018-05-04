using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransPreview : MonoBehaviour {

	public void GoPreview()
    {
        GetComponent<RectTransform>().localPosition += new Vector3(-1500, 0, 0);
    }

    public void BackPreview()
    {
        GetComponent<RectTransform>().localPosition += new Vector3(1500, 0, 0);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene("shumi_menu");
    }
}
