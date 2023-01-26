using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastScore : MonoBehaviour
{
    public Text txt;

    void Update()
    {
        if(Player.PlayGame > 0)
        {
            txt.text = "счет: " + Score.score.ToString();
        }
    }
}
