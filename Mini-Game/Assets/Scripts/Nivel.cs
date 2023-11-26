using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel : MonoBehaviour
{
    public static Nivel instance { get; private set; }

    public int nivelActual = 1;

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void SumarNivel()
    {
        Debug.Log("holi");
        nivelActual++;
        Level.instance.CargarSiguienteNivel();
    }

    public void ReiniciarNiveles()
    {
        nivelActual = 1;
    }


}
