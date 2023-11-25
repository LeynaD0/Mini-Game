using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public static Level instance { get; private set; }

    [SerializeField] bool levelComplete = false;

    [SerializeField] float time;

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
        if (levelComplete)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                CargarSiguienteNivel();
            }
        }
    }

    public void WinLevel()
    {
        if (!levelComplete)
        {
            levelComplete = true;
            Nivel.instance.SumarNivel();
            
        }
    }

    void CargarSiguienteNivel()
    {
        levelComplete = false;
        time = 3f;
        ScreensManagerGame.instance.WinOrLose();
    }
}
