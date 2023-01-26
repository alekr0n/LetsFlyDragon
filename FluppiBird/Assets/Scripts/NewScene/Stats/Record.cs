using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Record : MonoBehaviour
{
    public Text record;

    void Update()
    {
        if(PlayerPrefs.GetInt("Rec") < Score.score)
        {
            PlayerPrefs.SetInt("Rec", Score.score);
            PlayerPrefs.Save();
        }
        record.text = "рекорд: " + PlayerPrefs.GetInt("Rec").ToString();
    }
}
