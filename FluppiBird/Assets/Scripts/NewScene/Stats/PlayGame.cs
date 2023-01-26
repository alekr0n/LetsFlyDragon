using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayGame : MonoBehaviour
{
    public Text txt;

    void Update()
    {
        txt.text =  "сыграно игр: " + PlayerPrefs.GetInt("PlayGame").ToString();
    }
}
