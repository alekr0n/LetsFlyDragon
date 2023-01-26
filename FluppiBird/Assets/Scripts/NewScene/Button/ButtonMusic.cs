using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMusic : MonoBehaviour
{
    public Image im;
    public Sprite pict1, pict2;

    void Start()
    {
        im = GetComponent<Image>();

        if (PlayerPrefs.GetInt("On") == 0)
        {
            GetComponent<AudioSource>().Pause();
            im.sprite = pict2;
        }
        else if (PlayerPrefs.GetInt("On") == 1)
        {
            GetComponent<AudioSource>().Play();
            im.sprite = pict1;
        }
    }

    void OnMouseDown()
    {

        if (PlayerPrefs.GetInt("On") == 0)
        {
            im.sprite = pict1;
            GetComponent<AudioSource>().Play();
            PlayerPrefs.SetInt("On", 1);
            PlayerPrefs.Save();
        }
        else if (PlayerPrefs.GetInt("On") == 1)
        {
            im.sprite = pict2;
            GetComponent<AudioSource>().Pause();
            PlayerPrefs.SetInt("On", 0);
            PlayerPrefs.Save();
        }

    }
}
