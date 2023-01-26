using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HourseInGame : MonoBehaviour
{
    public Text txt;
    private int seconds, minutes, hourse;

    void Start()
    {
        StartCoroutine(Timer());
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("seconds") == 60)
        {
            minutes = PlayerPrefs.GetInt("minutes") + 1;
            PlayerPrefs.SetInt("minutes", minutes);
            PlayerPrefs.SetInt("seconds", 0);
            PlayerPrefs.Save();
        }
        if (PlayerPrefs.GetInt("minutes") == 60)
        {
            hourse = PlayerPrefs.GetInt("hourse") + 1;
            PlayerPrefs.SetInt("hourse", hourse);
            PlayerPrefs.SetInt("minutes", 0);
            PlayerPrefs.Save();
        }

        if(PlayerPrefs.GetInt("minutes") < 10)
        {
            txt.text = "общее игровое время: " + PlayerPrefs.GetInt("hourse").ToString() + ":0" + PlayerPrefs.GetInt("minutes").ToString();
        }
        else
        {
            txt.text = "общее игровое время: " + PlayerPrefs.GetInt("hourse").ToString() + ":" + PlayerPrefs.GetInt("minutes").ToString();
        }
    }

    IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            seconds = PlayerPrefs.GetInt("seconds") + 1;
            PlayerPrefs.SetInt("seconds", seconds);
            PlayerPrefs.Save();
        }
    }
}
