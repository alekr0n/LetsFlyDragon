using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class Player : MonoBehaviour
{
    public float force = 0f;
    private Rigidbody2D rb;
    public static int PlayGame = 0;

    void Start()
    {
        if (Advertisement.isSupported)
        {
            Advertisement.Initialize("3965097", false);
        }

        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.velocity = Vector2.up * force;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Block" || collision.collider.tag == "DeadZone")
        {
            PlayGame = PlayerPrefs.GetInt("PlayGame") + 1;
            PlayerPrefs.SetInt("PlayGame", PlayGame);
            /*if(PlayerPrefs.GetInt("PlayGame") % 3 == 0)
            {
                if (Advertisement.IsReady())
                {
                    Advertisement.Show("video");
                }
            }*/
            
            SceneManager.LoadScene(0);
        }
    }
}
