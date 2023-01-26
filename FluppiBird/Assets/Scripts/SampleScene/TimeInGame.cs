using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeInGame : MonoBehaviour
{
    private int seconds, minutes, hourse;

    void Start()
    {
        StartCoroutine(Timer());

        if (PlayerPrefs.GetInt("On") == 0)
        {
            GetComponent<AudioSource>().Pause();
        }
        else if (PlayerPrefs.GetInt("On") == 1)
        {
            GetComponent<AudioSource>().Play();
        }
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
