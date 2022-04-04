using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIText : MonoBehaviour
{
    InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        inputField = GameObject.Find("Name Text").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetInputName()
    {
        string name = inputField.text;

        inputField.text = "";
    }
}
