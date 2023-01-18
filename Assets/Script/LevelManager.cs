using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    int levelUnlocked;
    public Button[] buttons;

    // Start is called before the first frame update
    void Start()
    {
        levelUnlocked = PlayerPrefs.GetInt("levelUnlocked", 1);
        for (int i = 0; i < buttons.Length; i++)

        {
            buttons[i].interactable = false;
        }

        for (int i = 0; i < levelUnlocked; i++)
        {
            buttons[i].interactable = true;
        }

    }
}