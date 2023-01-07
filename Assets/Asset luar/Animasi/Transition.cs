using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
    public Animator animator;
    public float transitionDelayTime = 1.0f;

    void Awake()
    {
        animator = GameObject.Find("black Fade").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
          if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            LoadLevel();
        }
    }

    public void LoadLevel()
    {
        StartCoroutine(DelayLoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator DelayLoadLevel(int index)
    {
        animator.SetTrigger("FadeOut");
        yield return new WaitForSeconds(transitionDelayTime);
        SceneManager.LoadScene(index);
    }
}