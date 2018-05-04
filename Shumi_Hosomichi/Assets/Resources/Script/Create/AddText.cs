using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddText : MonoBehaviour {
    public void AddHeadLine()
    {
        GetComponent<InputField>().text += "<>";
        //GetComponent<InputField>().ActivateInputField();
        //GetComponent<InputField>().MoveTextEnd(false);
        //GetComponent<InputField>().caretPosition--;
    }
	
}
