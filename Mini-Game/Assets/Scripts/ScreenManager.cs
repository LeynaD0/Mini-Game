using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManager : MonoBehaviour
{
    [SerializeField]
    GameObject buttomPlay, buttomOptions, buttomExit, screenMenu;

    void Start()
    {
        //LeanTween.moveLocalX(buttomPlay, 1233f, 0f);
        //LeanTween.moveLocalX(buttomOptions, 1233f, 0f);
        //LeanTween.moveLocalX(buttomExit, 1233f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(screenMenu == true)
        {
            ScreenMenu();
        }
    }

    public void ScreenMenu()
    {  
            LeanTween.moveLocalX(buttomPlay, 581f, 0.5f);
            LeanTween.moveLocalX(buttomOptions, 581f, 0.8f);
            LeanTween.moveLocalX(buttomExit, 581f, 1.2f);
    }
}
