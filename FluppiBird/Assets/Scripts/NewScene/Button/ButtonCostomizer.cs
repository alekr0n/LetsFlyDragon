using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCostomizer : MonoBehaviour
{
    public int levelLoad;

    void OnMouseDown()
    {
        SceneManager.LoadScene(levelLoad);
    }
}
