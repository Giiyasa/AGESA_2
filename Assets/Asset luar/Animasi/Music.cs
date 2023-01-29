using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Music : MonoBehaviour
{
    public static Music Instance { get; set; }
    public AudioSource audioMusic;
    public AudioClip[] clipMusic;

    private void Awake()
    {
        if (Instance == null)
        {
            //If I am the first instance, make me the Singleton
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void ChangeMusic()
    {
        for (int i = 0; i < clipMusic.Length; i++)
        {
            if (i == SceneManager.GetActiveScene().buildIndex)
            {
                audioMusic.Stop();
                audioMusic.clip = clipMusic[i];
                audioMusic.Play();


                break;
            }

        }
    }
}