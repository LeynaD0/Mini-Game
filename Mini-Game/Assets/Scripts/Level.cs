using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public static Level instance { get; private set; }

    [SerializeField] bool levelComplete = false, timer;

    [SerializeField] float time;

    [SerializeField] int speed;

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

    public void CargarSiguienteNivel()
    {
        Debug.Log("Holi");
        //levelComplete = true;
        timer = true;
        if (time <= 0)
        {
            time = 3f;
            ScreensManagerGame.instance.WinOrLose();
            Time.timeScale += 0.2f;
        }
        
        
    }
}
