using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreensManagerGame : MonoBehaviour
{
    public static ScreensManagerGame instance;

    [SerializeField] private GameObject screenLeft, screenRight;

    [SerializeField] private GameObject gameManager;
    [SerializeField] private bool timer = true, reload;
    [SerializeField] private float time = 6f, timeReload = 4;
    [SerializeField] public TextMeshProUGUI levelText;

    int nivel;

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

    private void Start()
    {
        LeanTween.moveLocalX(screenLeft, -500f, 0f);
        LeanTween.moveLocalX(screenRight, 500f, 0f);

        nivel = Nivel.instance.nivelActual;
        levelText.text = nivel.ToString();
    }

    private void Update()
    {
        if (timer)
        {
            time -= Time.deltaTime;
            levelText.text = nivel.ToString();
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
        LeanTween.moveLocalX(screenLeft, -1460f, 0.5f);
        LeanTween.moveLocalX(screenRight, 1460f, 0.5f);
        timer = false;
    }

    public void WinOrLose()
    {
        LeanTween.moveLocalX(screenLeft, -500f, 0.5f);
        LeanTween.moveLocalX(screenRight, 500f, 0.5f);
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
