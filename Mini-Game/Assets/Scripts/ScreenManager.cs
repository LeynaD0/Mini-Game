using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    [SerializeField]
    GameObject buttonPlay, buttonOptions, buttonExit, screenMenu, screenOptions;


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
            LeanTween.moveLocalX(buttonPlay, 581f, 0.5f);
            LeanTween.moveLocalX(buttonOptions, 581f, 0.8f);
            LeanTween.moveLocalX(buttonExit, 581f, 1.2f);
    }

    public void ScreenOptions()
    {
        LeanTween.moveLocalX(buttonPlay, 1233f, 0.5f);
        LeanTween.moveLocalX(buttonOptions, 1233f, 0.8f);
        LeanTween.moveLocalX(buttonExit, 1233f, 1.2f).callOnCompletes();
        LeanTween.scale(screenOptions, new Vector3(1f, 1f, 1f), 1.8f);
    }
}
