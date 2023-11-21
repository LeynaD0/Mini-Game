using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    [SerializeField]
    GameObject buttonPlay, buttonOptions, buttonExit, screenMenu, screenOptions;
    [SerializeField]
    GameObject logo;


    void Start()
    {
        ScreenMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScreenMenu()
    {
        LeanTween.scale(logo, new Vector3(75f, 75f, 75f), 0.3f);
        LeanTween.moveLocalX(buttonPlay, 581f, 0.5f);
        LeanTween.moveLocalX(buttonOptions, 581f, 0.8f);
        LeanTween.moveLocalX(buttonExit, 581f, 1f);
        LeanTween.scale(screenOptions, new Vector3(0.01f, 0.01f, 0.01f), 0.3f);
        
    }

    public void ScreenOptions()
    {
        LeanTween.scale(logo, new Vector3(0.01f, 0.01f, 0.01f), 0.3f);
        LeanTween.moveLocalX(buttonPlay, 1233f, 0.5f);
        LeanTween.moveLocalX(buttonOptions, 1233f, 0.8f);
        LeanTween.moveLocalX(buttonExit, 1233f, 1f);
        LeanTween.scale(screenOptions, new Vector3(1f, 1f, 1f), 1.8f);
    }

    public void PlayScreen()
    {
        SceneManager.LoadScene("Game");
    }
}
