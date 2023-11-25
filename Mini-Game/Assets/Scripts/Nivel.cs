using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nivel : MonoBehaviour
{
    public static Nivel instance { get; private set; }

    [SerializeField] int nivelActual = 1;

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
        nivelActual++;
    }

    public void ReiniciarNiveles()
    {
        nivelActual = 1;
    }


}
