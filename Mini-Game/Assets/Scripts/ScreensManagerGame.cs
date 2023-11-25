using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreensManagerGame : MonoBehaviour
{
    public static ScreensManagerGame instance;

    [SerializeField] private GameObject screenLeft, screenRight;

    [SerializeField] private GameObject gameManager;
    [SerializeField] private bool timer = true, reload;
    [SerializeField] private float time = 6f, timeReload = 4;

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

    private void Update()
    {
        if (timer)
        {
            time -= Time.deltaTime;
            ScreenTime();
        }

        if (reload)
        {
            timeReload -= Time.deltaTime;
            if(timeReload <= 0)
            {
                SceneManager.LoadScene("Game");
            }
        }
    }

    public void LevelView()
    {
        LeanTween.moveX(screenLeft, -500f, 0.5f);
        LeanTween.moveX(screenRight, 500f, 0.5f);
        timer = false;
    }

    public void WinOrLose()
    {
        LeanTween.moveX(screenLeft, 460f, 0.5f);
        LeanTween.moveX(screenRight, -460f, 0.5f);
        reload = true;
    }

    void ScreenTime()
    {
        if(time <= 0)
        {
            timer = false;
            time = 6f;
            gameManager.SetActive(true);
            LevelView();
            AudioController.instance.PlaySounds();
        }
    }
}
