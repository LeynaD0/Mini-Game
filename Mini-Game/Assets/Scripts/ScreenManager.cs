using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    [SerializeField] private ScreenManager Instance;
    public static ScreenManager instance { get; private set; }

    [SerializeField]
    GameObject buttonPlay, buttonOptions, buttonExit, screenMenu, screenOptions, screenControls;
    [SerializeField]
    GameObject logo;
    [SerializeField]
    float logoSpeed;
    [SerializeField]
    float timerForPlay;
    [SerializeField]
    bool onPlay;

    
    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
        Time.timeScale = 1;
        ScreenMenu();
    }

    // Update is called once per frame
    void Update()
    {
        if(onPlay != false)
        {
            timerForPlay -= Time.deltaTime * 1f;

            if (timerForPlay <= 0)
            {
                SceneManager.LoadScene("Game");
            }
        }
    }

    public void ScreenMenu()
    {
        LeanTween.scale(logo, new Vector3(75f, 75f, 75f), 0.4f).setOnComplete(MusicLogo);
        LeanTween.moveLocalX(logo, -375.1f, 0.4f);
        LeanTween.moveLocalX(buttonPlay, 581f, 0.6f);
        LeanTween.moveLocalX(buttonOptions, 581f, 0.8f);
        LeanTween.moveLocalX(buttonExit, 581f, 1f);
        LeanTween.scale(screenOptions, new Vector3(0.01f, 0.01f, 0.01f), 0.3f);
    }

    public void ScreenOptions()
    {
        LeanTween.scale(logo, new Vector3(0.01f, 0.01f, 0.01f), 0.3f);
        LeanTween.moveLocalX(logo,-1568f, 0.3f);
        LeanTween.moveLocalX(buttonPlay, 1233f, 0.5f);
        LeanTween.moveLocalX(buttonOptions, 1233f, 0.8f);
        LeanTween.moveLocalX(buttonExit, 1233f, 1f);
        LeanTween.scale(screenOptions, new Vector3(1f, 1f, 1f), 1.8f);
    }

    public void MusicLogo()
    {
        LeanTween.scale(logo, new Vector3(80f, 80f, 80f), logoSpeed).setLoopPingPong();
    }

    public void PlayScreen()
    {
        onPlay = true;
        LeanTween.moveX(screenControls, 0f, 0.5f);
        
    }

    public void Exit()
    {
        Application.Quit();
    }
}
