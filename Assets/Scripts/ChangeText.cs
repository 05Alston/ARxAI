using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    //protected string input;
    public TextMeshPro tmp;

    private void Start()
    {
        tmp = GameObject.FindGameObjectWithTag("STT").GetComponent<TextMeshPro>();
    }
    public void ReadString(string str)
    {
        //input = str;

    }
    public void SetString()
    {
        tmp.text = "Hey Guys, Alston here.";
        //Clear input field
    }
    public void ResetString()
    {
        tmp.text = "Hello World!";
        //Clear input field
    }
}
